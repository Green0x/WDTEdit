namespace WDTEdit
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSave = new System.Windows.Forms.Button();
            this.chkFlipMap = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkMCLV = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkHeightTex = new System.Windows.Forms.CheckBox();
            this.chkUnk40 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkUnk4000 = new System.Windows.Forms.CheckBox();
            this.chkUnk8000 = new System.Windows.Forms.CheckBox();
            this.chkUnk2000 = new System.Windows.Forms.CheckBox();
            this.chkUnk1000 = new System.Windows.Forms.CheckBox();
            this.chkUnk800 = new System.Windows.Forms.CheckBox();
            this.chkUnk400 = new System.Windows.Forms.CheckBox();
            this.chkUnk100 = new System.Windows.Forms.CheckBox();
            this.chkFDID = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkMCCV = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkDoodadSortSize = new System.Windows.Forms.CheckBox();
            this.chkBigAlpha = new System.Windows.Forms.CheckBox();
            this.chkGlobalObj = new System.Windows.Forms.CheckBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAbout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(530, 488);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 44);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // chkFlipMap
            // 
            this.chkFlipMap.AutoSize = true;
            this.chkFlipMap.Enabled = false;
            this.chkFlipMap.Location = new System.Drawing.Point(15, 19);
            this.chkFlipMap.Name = "chkFlipMap";
            this.chkFlipMap.Size = new System.Drawing.Size(65, 17);
            this.chkFlipMap.TabIndex = 1;
            this.chkFlipMap.Text = "Flip map";
            this.chkFlipMap.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMCLV);
            this.groupBox1.Controls.Add(this.chkFlipMap);
            this.groupBox1.Location = new System.Drawing.Point(21, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cata";
            // 
            // chkMCLV
            // 
            this.chkMCLV.AutoSize = true;
            this.chkMCLV.Enabled = false;
            this.chkMCLV.Location = new System.Drawing.Point(15, 42);
            this.chkMCLV.Name = "chkMCLV";
            this.chkMCLV.Size = new System.Drawing.Size(177, 17);
            this.chkMCLV.TabIndex = 2;
            this.chkMCLV.Text = "Add vertex color lighting (MCLV)";
            this.chkMCLV.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkHeightTex);
            this.groupBox2.Controls.Add(this.chkUnk40);
            this.groupBox2.Location = new System.Drawing.Point(21, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mists";
            // 
            // chkHeightTex
            // 
            this.chkHeightTex.AutoSize = true;
            this.chkHeightTex.Enabled = false;
            this.chkHeightTex.Location = new System.Drawing.Point(15, 42);
            this.chkHeightTex.Name = "chkHeightTex";
            this.chkHeightTex.Size = new System.Drawing.Size(120, 17);
            this.chkHeightTex.TabIndex = 2;
            this.chkHeightTex.Text = "Has height texturing";
            this.chkHeightTex.UseVisualStyleBackColor = true;
            // 
            // chkUnk40
            // 
            this.chkUnk40.AutoSize = true;
            this.chkUnk40.Enabled = false;
            this.chkUnk40.Location = new System.Drawing.Point(15, 19);
            this.chkUnk40.Name = "chkUnk40";
            this.chkUnk40.Size = new System.Drawing.Size(85, 17);
            this.chkUnk40.TabIndex = 1;
            this.chkUnk40.Text = "unk_0x0040";
            this.chkUnk40.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkUnk4000);
            this.groupBox3.Controls.Add(this.chkUnk8000);
            this.groupBox3.Controls.Add(this.chkUnk2000);
            this.groupBox3.Controls.Add(this.chkUnk1000);
            this.groupBox3.Controls.Add(this.chkUnk800);
            this.groupBox3.Controls.Add(this.chkUnk400);
            this.groupBox3.Controls.Add(this.chkUnk100);
            this.groupBox3.Location = new System.Drawing.Point(21, 307);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 173);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Legion";
            // 
            // chkUnk4000
            // 
            this.chkUnk4000.AutoSize = true;
            this.chkUnk4000.Enabled = false;
            this.chkUnk4000.Location = new System.Drawing.Point(15, 133);
            this.chkUnk4000.Name = "chkUnk4000";
            this.chkUnk4000.Size = new System.Drawing.Size(85, 17);
            this.chkUnk4000.TabIndex = 8;
            this.chkUnk4000.Text = "unk_0x4000";
            this.chkUnk4000.UseVisualStyleBackColor = true;
            // 
            // chkUnk8000
            // 
            this.chkUnk8000.AutoSize = true;
            this.chkUnk8000.Enabled = false;
            this.chkUnk8000.Location = new System.Drawing.Point(15, 156);
            this.chkUnk8000.Name = "chkUnk8000";
            this.chkUnk8000.Size = new System.Drawing.Size(85, 17);
            this.chkUnk8000.TabIndex = 7;
            this.chkUnk8000.Text = "unk_0x8000";
            this.chkUnk8000.UseVisualStyleBackColor = true;
            // 
            // chkUnk2000
            // 
            this.chkUnk2000.AutoSize = true;
            this.chkUnk2000.Enabled = false;
            this.chkUnk2000.Location = new System.Drawing.Point(15, 110);
            this.chkUnk2000.Name = "chkUnk2000";
            this.chkUnk2000.Size = new System.Drawing.Size(85, 17);
            this.chkUnk2000.TabIndex = 6;
            this.chkUnk2000.Text = "unk_0x2000";
            this.chkUnk2000.UseVisualStyleBackColor = true;
            // 
            // chkUnk1000
            // 
            this.chkUnk1000.AutoSize = true;
            this.chkUnk1000.Enabled = false;
            this.chkUnk1000.Location = new System.Drawing.Point(15, 85);
            this.chkUnk1000.Name = "chkUnk1000";
            this.chkUnk1000.Size = new System.Drawing.Size(85, 17);
            this.chkUnk1000.TabIndex = 5;
            this.chkUnk1000.Text = "unk_0x1000";
            this.chkUnk1000.UseVisualStyleBackColor = true;
            // 
            // chkUnk800
            // 
            this.chkUnk800.AutoSize = true;
            this.chkUnk800.Enabled = false;
            this.chkUnk800.Location = new System.Drawing.Point(15, 62);
            this.chkUnk800.Name = "chkUnk800";
            this.chkUnk800.Size = new System.Drawing.Size(85, 17);
            this.chkUnk800.TabIndex = 4;
            this.chkUnk800.Text = "unk_0x0800";
            this.chkUnk800.UseVisualStyleBackColor = true;
            // 
            // chkUnk400
            // 
            this.chkUnk400.AutoSize = true;
            this.chkUnk400.Enabled = false;
            this.chkUnk400.Location = new System.Drawing.Point(15, 40);
            this.chkUnk400.Name = "chkUnk400";
            this.chkUnk400.Size = new System.Drawing.Size(85, 17);
            this.chkUnk400.TabIndex = 3;
            this.chkUnk400.Text = "unk_0x0400";
            this.chkUnk400.UseVisualStyleBackColor = true;
            // 
            // chkUnk100
            // 
            this.chkUnk100.AutoSize = true;
            this.chkUnk100.Enabled = false;
            this.chkUnk100.Location = new System.Drawing.Point(15, 19);
            this.chkUnk100.Name = "chkUnk100";
            this.chkUnk100.Size = new System.Drawing.Size(85, 17);
            this.chkUnk100.TabIndex = 1;
            this.chkUnk100.Text = "unk_0x0100";
            this.chkUnk100.UseVisualStyleBackColor = true;
            // 
            // chkFDID
            // 
            this.chkFDID.AutoSize = true;
            this.chkFDID.Enabled = false;
            this.chkFDID.Location = new System.Drawing.Point(15, 19);
            this.chkFDID.Name = "chkFDID";
            this.chkFDID.Size = new System.Drawing.Size(117, 17);
            this.chkFDID.TabIndex = 2;
            this.chkFDID.Text = "Load by FileDataID";
            this.chkFDID.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkMCCV);
            this.groupBox4.Location = new System.Drawing.Point(21, 115);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 44);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "WotLK";
            // 
            // chkMCCV
            // 
            this.chkMCCV.AutoSize = true;
            this.chkMCCV.Enabled = false;
            this.chkMCCV.Location = new System.Drawing.Point(15, 19);
            this.chkMCCV.Name = "chkMCCV";
            this.chkMCCV.Size = new System.Drawing.Size(142, 17);
            this.chkMCCV.TabIndex = 1;
            this.chkMCCV.Text = "Add vertex color (MCCV)";
            this.chkMCCV.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkDoodadSortSize);
            this.groupBox5.Controls.Add(this.chkBigAlpha);
            this.groupBox5.Controls.Add(this.chkGlobalObj);
            this.groupBox5.Location = new System.Drawing.Point(21, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 86);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "All WDT\'s";
            // 
            // chkDoodadSortSize
            // 
            this.chkDoodadSortSize.AutoSize = true;
            this.chkDoodadSortSize.Enabled = false;
            this.chkDoodadSortSize.Location = new System.Drawing.Point(15, 63);
            this.chkDoodadSortSize.Name = "chkDoodadSortSize";
            this.chkDoodadSortSize.Size = new System.Drawing.Size(166, 17);
            this.chkDoodadSortSize.TabIndex = 3;
            this.chkDoodadSortSize.Text = "Doodadrefs are sorted by size";
            this.chkDoodadSortSize.UseVisualStyleBackColor = true;
            // 
            // chkBigAlpha
            // 
            this.chkBigAlpha.AutoSize = true;
            this.chkBigAlpha.Enabled = false;
            this.chkBigAlpha.Location = new System.Drawing.Point(15, 42);
            this.chkBigAlpha.Name = "chkBigAlpha";
            this.chkBigAlpha.Size = new System.Drawing.Size(91, 17);
            this.chkBigAlpha.TabIndex = 2;
            this.chkBigAlpha.Text = "Has big alpha";
            this.chkBigAlpha.UseVisualStyleBackColor = true;
            // 
            // chkGlobalObj
            // 
            this.chkGlobalObj.AutoSize = true;
            this.chkGlobalObj.Enabled = false;
            this.chkGlobalObj.Location = new System.Drawing.Point(15, 19);
            this.chkGlobalObj.Name = "chkGlobalObj";
            this.chkGlobalObj.Size = new System.Drawing.Size(176, 17);
            this.chkGlobalObj.TabIndex = 1;
            this.chkGlobalObj.Text = "Use global map object definition";
            this.chkGlobalObj.UseVisualStyleBackColor = true;
            this.chkGlobalObj.CheckedChanged += new System.EventHandler(this.chkGlobalObj_CheckedChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(391, 488);
            this.btnLoad.MaximumSize = new System.Drawing.Size(100, 100);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(79, 44);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click_1);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.SystemColors.Control;
            this.txtLog.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtLog.Location = new System.Drawing.Point(244, 27);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(498, 403);
            this.txtLog.TabIndex = 7;
            this.txtLog.Text = "";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(244, 488);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(79, 44);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkFDID);
            this.groupBox6.Location = new System.Drawing.Point(21, 486);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 45);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "BFA";
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(663, 487);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(79, 44);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 562);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WDT Editor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

#endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.CheckBox chkMCLV;
        protected System.Windows.Forms.CheckBox chkUnk40;
        protected System.Windows.Forms.CheckBox chkFlipMap;
        protected System.Windows.Forms.CheckBox chkFDID;
        protected System.Windows.Forms.CheckBox chkUnk100;
        protected System.Windows.Forms.CheckBox chkUnk400;
        protected System.Windows.Forms.CheckBox chkUnk800;
        protected System.Windows.Forms.CheckBox chkUnk1000;
        protected System.Windows.Forms.CheckBox chkUnk2000;
        protected System.Windows.Forms.CheckBox chkUnk8000;
        protected System.Windows.Forms.GroupBox groupBox4;
        protected System.Windows.Forms.CheckBox chkMCCV;
        protected System.Windows.Forms.GroupBox groupBox5;
        protected System.Windows.Forms.CheckBox chkGlobalObj;
        protected System.Windows.Forms.CheckBox chkHeightTex;
        protected System.Windows.Forms.CheckBox chkBigAlpha;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox6;
        protected System.Windows.Forms.CheckBox chkDoodadSortSize;
        protected System.Windows.Forms.CheckBox chkUnk4000;
        private System.Windows.Forms.Button btnAbout;
    }
}

