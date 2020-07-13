using System;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Microsoft.SqlServer.Server;

namespace WDTEdit
{
    public partial class Form1 : Form 
    {
        
        public struct WDT 
        {
            public uint magic;
            public uint size;
            public uint version;
            public uint header;
        }
        WDT wdt = new WDT();

        

        enum mphd_flags
        {
            wdt_uses_global_map_obj       = 0x0001, // Use global map object definition.
            adt_has_mccv                  = 0x0002, // Use Vertex Shading
            adt_has_big_alpha             = 0x0004, // shader = 2. Decides whether to use _env terrain shaders or not: funky and if MCAL has 4096 instead of 2048(?)
            adt_doodadrefs_sorted_by_size = 0x0008, // if enabled, the ADT's MCRF(m2 only)/MCRD chunks need to be sorted by size category
            adt_has_mclv                  = 0x0010, // ≥ Cata adds second color: ADT.MCNK.MCLV -- This appears to be deprecated and forbidden in 8.x?
            adt_has_upside_down_ground    = 0x0020, // ≥ Cata Flips the ground display upside down to create a ceiling
            unk_0x0040                    = 0x0040, // ≥ Mists ??? -- Only found on Firelands2.wdt (but only since MoP) before Legion
            adt_has_height_texturing      = 0x0080, // ≥ Mists shader = 6. Decides whether to influence alpha maps by _h+MTXP: (without with)
            unk_0x0100                    = 0x0100, // ≥ Legion implicitly sets 0x8000
            wdt_has_maid                  = 0x0200, // ≥ Battle (8.1.0.28294) client will load ADT using FileDataID instead of filename formatted with "%s\\%s_%d_%d.adt"
            unk_0x0400                    = 0x0400,
            unk_0x0800                    = 0x0800,
            unk_0x1000                    = 0x1000,
            unk_0x2000                    = 0x2000,
            unk_0x4000                    = 0x4000,
            unk_0x8000                    = 0x8000, // ≥ Legion implicitly set for map ids 0, 1, 571, 870, 1116 (continents). Affects the rendering of _lod.adt

        };
        
        OpenFileDialog openFileDialog = new OpenFileDialog

        {
            InitialDirectory = "",
            RestoreDirectory = true,
            Filter = "WDT files (*.wdt)|*.wdt"
        };

#region Load Button
        private void BtnLoad_Click_1(object sender, EventArgs e)
        {
            const string conHeader = "[HEADER] ";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
            
                using (BinaryReader reader = new BinaryReader(File.OpenRead(openFileDialog.FileName)))
                {
                    
                    uint MPHD = Helper.MagicToSignature("MPHD");
                    
                    wdt.magic = reader.ReadUInt32();
                    txtLog.AppendText(string.Concat(conHeader, wdt.magic, "\n"));
                    wdt.size = reader.ReadUInt32();
                    wdt.version = reader.ReadUInt32();
                    wdt.header = reader.ReadUInt32();
                    

                    if (wdt.header == MPHD)
                    {
                        txtLog.AppendText("WDT Loaded");
                        EnableAllItems();
                    }
                    else
                    {
                        txtLog.AppendText("WDT file is corrupted");
                        DisableAllItems();
                    }

                }
      
            }
            
        }
#endregion


        

        public Form1()
        {
            InitializeComponent();
        }


        #region Save Button

        private void BtnSave_Click(object sender, EventArgs e)
        {

            using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(openFileDialog.FileName)))
            {
                uint MPHDFlags = 0;
                if (chkGlobalObj.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.wdt_uses_global_map_obj;
                }
                if (chkMCCV.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.adt_has_mccv;
                }
                if (chkBigAlpha.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.adt_has_big_alpha;
                    
                }
                if (chkDoodadSortSize.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.adt_doodadrefs_sorted_by_size;
                }
                if (chkMCLV.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.adt_has_mclv;
                }
                if (chkFlipMap.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.adt_has_upside_down_ground;
                }
                if (chkUnk40.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.unk_0x0040;
                }
                if (chkHeightTex.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.adt_has_height_texturing;
                }
                if (chkUnk100.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.unk_0x0100;
                }
                if (chkFDID.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.wdt_has_maid;
                }
                if (chkUnk400.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.unk_0x0400;
                }
                if (chkUnk800.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.unk_0x0800;
                }
                if (chkUnk1000.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.unk_0x1000;
                }
                if (chkUnk2000.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.unk_0x2000;
                }
                if (chkUnk4000.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.unk_0x4000;
                }
                if (chkUnk8000.Checked)
                {
                    MPHDFlags += (uint)mphd_flags.unk_0x8000;
                }
                writer.Seek(0x14, SeekOrigin.Begin);
                writer.Write(MPHDFlags);
                


            }



        }


#endregion


        private void BtnCreate_Click(object sender, EventArgs e)
        {

            // TODO
        }

        public void EnableAllItems()
        {
            chkBigAlpha.Enabled = true;
            chkFlipMap.Enabled = true;
            chkGlobalObj.Enabled = true;
            chkHeightTex.Enabled = true;
            chkMCCV.Enabled = true;
            chkMCLV.Enabled = true;
            chkUnk100.Enabled = true;
            chkUnk1000.Enabled = true;
            chkFDID.Enabled = true;
            chkUnk2000.Enabled = true;
            chkUnk40.Enabled = true;
            chkUnk400.Enabled = true;
            chkUnk800.Enabled = true;
            chkUnk8000.Enabled = true;
            chkUnk4000.Enabled = true;
            chkDoodadSortSize.Enabled = true;
        }

        public void DisableAllItems()
        {
            chkBigAlpha.Enabled = false;
            chkFlipMap.Enabled = false;
            chkGlobalObj.Enabled = false;
            chkHeightTex.Enabled = false;
            chkMCCV.Enabled = false;
            chkMCLV.Enabled = false;
            chkUnk100.Enabled = false;
            chkUnk1000.Enabled = false;
            chkFDID.Enabled = false;
            chkUnk2000.Enabled = false;
            chkUnk40.Enabled = false;
            chkUnk400.Enabled = false;
            chkUnk800.Enabled = false;
            chkUnk8000.Enabled = false;
            chkUnk4000.Enabled = false;
            chkDoodadSortSize.Enabled = false;
        }

        private void chkGlobalObj_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("azeroth.wdt", FileMode.Open, FileAccess.Read, FileShare.Read);
            WDT obj = (WDT)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine("n1: {0}", obj.magic);
            Console.WriteLine("n2: {0}", obj.size);
            Console.WriteLine("str: {0}", obj.version);
        }
    }
}
