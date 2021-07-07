
namespace UT2004UCCAdvanced
{
    partial class MainPage
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
            this.buttonProjectFolder = new System.Windows.Forms.Button();
            this.buttonSystemFolder = new System.Windows.Forms.Button();
            this.textBoxProjectFolderPath = new System.Windows.Forms.TextBox();
            this.textBoxSystemFolderPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogProjectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogSystemFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxProjectIni = new System.Windows.Forms.TextBox();
            this.buttonProjectIni = new System.Windows.Forms.Button();
            this.openFileDialogProjectIni = new System.Windows.Forms.OpenFileDialog();
            this.buttonCompile = new System.Windows.Forms.Button();
            this.checkBoxDebug = new System.Windows.Forms.CheckBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.textBoxUccCmd = new System.Windows.Forms.TextBox();
            this.buttonCreateLocalDev = new System.Windows.Forms.Button();
            this.textboxDevEnv = new System.Windows.Forms.TextBox();
            this.buttonApplyDebugLaunchOptions = new System.Windows.Forms.Button();
            this.checkBoxWindowed = new System.Windows.Forms.CheckBox();
            this.textBoxXRes = new System.Windows.Forms.TextBox();
            this.labelXRes = new System.Windows.Forms.Label();
            this.labelYRes = new System.Windows.Forms.Label();
            this.textBoxYRes = new System.Windows.Forms.TextBox();
            this.textBoxInstall = new System.Windows.Forms.TextBox();
            this.buttonChooseUT2004 = new System.Windows.Forms.Button();
            this.buttonChooseDevEnv = new System.Windows.Forms.Button();
            this.buttonLaunchUdebugger = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxDebugOptions = new System.Windows.Forms.RichTextBox();
            this.buttonLaunchUT2004 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonExportAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonProjectFolder
            // 
            this.buttonProjectFolder.Location = new System.Drawing.Point(16, 58);
            this.buttonProjectFolder.Name = "buttonProjectFolder";
            this.buttonProjectFolder.Size = new System.Drawing.Size(120, 40);
            this.buttonProjectFolder.TabIndex = 0;
            this.buttonProjectFolder.Text = "Choose Project Folder";
            this.buttonProjectFolder.UseVisualStyleBackColor = true;
            this.buttonProjectFolder.Click += new System.EventHandler(this.buttonProjectFolder_Click);
            // 
            // buttonSystemFolder
            // 
            this.buttonSystemFolder.Location = new System.Drawing.Point(16, 150);
            this.buttonSystemFolder.Name = "buttonSystemFolder";
            this.buttonSystemFolder.Size = new System.Drawing.Size(120, 40);
            this.buttonSystemFolder.TabIndex = 1;
            this.buttonSystemFolder.Text = "Choose UT2004 System Folder";
            this.buttonSystemFolder.UseVisualStyleBackColor = true;
            this.buttonSystemFolder.Click += new System.EventHandler(this.buttonSystemFolder_Click);
            // 
            // textBoxProjectFolderPath
            // 
            this.textBoxProjectFolderPath.Location = new System.Drawing.Point(142, 69);
            this.textBoxProjectFolderPath.Name = "textBoxProjectFolderPath";
            this.textBoxProjectFolderPath.Size = new System.Drawing.Size(448, 20);
            this.textBoxProjectFolderPath.TabIndex = 2;
            // 
            // textBoxSystemFolderPath
            // 
            this.textBoxSystemFolderPath.Location = new System.Drawing.Point(142, 161);
            this.textBoxSystemFolderPath.Name = "textBoxSystemFolderPath";
            this.textBoxSystemFolderPath.Size = new System.Drawing.Size(448, 20);
            this.textBoxSystemFolderPath.TabIndex = 3;
            // 
            // textBoxProjectIni
            // 
            this.textBoxProjectIni.Location = new System.Drawing.Point(142, 115);
            this.textBoxProjectIni.Name = "textBoxProjectIni";
            this.textBoxProjectIni.Size = new System.Drawing.Size(448, 20);
            this.textBoxProjectIni.TabIndex = 5;
            // 
            // buttonProjectIni
            // 
            this.buttonProjectIni.Location = new System.Drawing.Point(16, 104);
            this.buttonProjectIni.Name = "buttonProjectIni";
            this.buttonProjectIni.Size = new System.Drawing.Size(120, 40);
            this.buttonProjectIni.TabIndex = 4;
            this.buttonProjectIni.Text = "Choose Project .ini";
            this.buttonProjectIni.UseVisualStyleBackColor = true;
            this.buttonProjectIni.Click += new System.EventHandler(this.buttonProjectIni_Click);
            // 
            // openFileDialogProjectIni
            // 
            this.openFileDialogProjectIni.FileName = "make.ini";
            // 
            // buttonCompile
            // 
            this.buttonCompile.Location = new System.Drawing.Point(16, 196);
            this.buttonCompile.Name = "buttonCompile";
            this.buttonCompile.Size = new System.Drawing.Size(120, 43);
            this.buttonCompile.TabIndex = 6;
            this.buttonCompile.Text = "Compile";
            this.buttonCompile.UseVisualStyleBackColor = true;
            this.buttonCompile.Click += new System.EventHandler(this.buttonCompile_Click);
            // 
            // checkBoxDebug
            // 
            this.checkBoxDebug.AutoSize = true;
            this.checkBoxDebug.Location = new System.Drawing.Point(142, 196);
            this.checkBoxDebug.Name = "checkBoxDebug";
            this.checkBoxDebug.Size = new System.Drawing.Size(59, 17);
            this.checkBoxDebug.TabIndex = 7;
            this.checkBoxDebug.Text = "-debug";
            this.checkBoxDebug.UseVisualStyleBackColor = true;
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxOutput.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(717, 173);
            this.richTextBoxOutput.TabIndex = 8;
            this.richTextBoxOutput.Text = "";
            // 
            // textBoxUccCmd
            // 
            this.textBoxUccCmd.Location = new System.Drawing.Point(142, 219);
            this.textBoxUccCmd.Name = "textBoxUccCmd";
            this.textBoxUccCmd.ReadOnly = true;
            this.textBoxUccCmd.Size = new System.Drawing.Size(448, 20);
            this.textBoxUccCmd.TabIndex = 9;
            // 
            // buttonCreateLocalDev
            // 
            this.buttonCreateLocalDev.Location = new System.Drawing.Point(586, 13);
            this.buttonCreateLocalDev.Name = "buttonCreateLocalDev";
            this.buttonCreateLocalDev.Size = new System.Drawing.Size(145, 40);
            this.buttonCreateLocalDev.TabIndex = 10;
            this.buttonCreateLocalDev.Text = "Create Local Dev Env";
            this.buttonCreateLocalDev.UseVisualStyleBackColor = true;
            this.buttonCreateLocalDev.Click += new System.EventHandler(this.buttonCreateLocalDev_Click);
            // 
            // textboxDevEnv
            // 
            this.textboxDevEnv.Location = new System.Drawing.Point(132, 34);
            this.textboxDevEnv.Name = "textboxDevEnv";
            this.textboxDevEnv.Size = new System.Drawing.Size(448, 20);
            this.textboxDevEnv.TabIndex = 11;
            // 
            // buttonApplyDebugLaunchOptions
            // 
            this.buttonApplyDebugLaunchOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonApplyDebugLaunchOptions.Location = new System.Drawing.Point(6, 198);
            this.buttonApplyDebugLaunchOptions.Name = "buttonApplyDebugLaunchOptions";
            this.buttonApplyDebugLaunchOptions.Size = new System.Drawing.Size(120, 40);
            this.buttonApplyDebugLaunchOptions.TabIndex = 12;
            this.buttonApplyDebugLaunchOptions.Text = "Apply Debug Launch Options";
            this.buttonApplyDebugLaunchOptions.UseVisualStyleBackColor = true;
            this.buttonApplyDebugLaunchOptions.Click += new System.EventHandler(this.buttonApplyDebugLaunchOptions_Click);
            // 
            // checkBoxWindowed
            // 
            this.checkBoxWindowed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxWindowed.AutoSize = true;
            this.checkBoxWindowed.Location = new System.Drawing.Point(132, 212);
            this.checkBoxWindowed.Name = "checkBoxWindowed";
            this.checkBoxWindowed.Size = new System.Drawing.Size(77, 17);
            this.checkBoxWindowed.TabIndex = 13;
            this.checkBoxWindowed.Text = "-windowed";
            this.checkBoxWindowed.UseVisualStyleBackColor = true;
            // 
            // textBoxXRes
            // 
            this.textBoxXRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxXRes.Location = new System.Drawing.Point(215, 198);
            this.textBoxXRes.Name = "textBoxXRes";
            this.textBoxXRes.Size = new System.Drawing.Size(77, 20);
            this.textBoxXRes.TabIndex = 14;
            // 
            // labelXRes
            // 
            this.labelXRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelXRes.AutoSize = true;
            this.labelXRes.Location = new System.Drawing.Point(298, 201);
            this.labelXRes.Name = "labelXRes";
            this.labelXRes.Size = new System.Drawing.Size(36, 13);
            this.labelXRes.TabIndex = 15;
            this.labelXRes.Text = "X Res";
            // 
            // labelYRes
            // 
            this.labelYRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelYRes.AutoSize = true;
            this.labelYRes.Location = new System.Drawing.Point(298, 221);
            this.labelYRes.Name = "labelYRes";
            this.labelYRes.Size = new System.Drawing.Size(36, 13);
            this.labelYRes.TabIndex = 17;
            this.labelYRes.Text = "Y Res";
            // 
            // textBoxYRes
            // 
            this.textBoxYRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxYRes.Location = new System.Drawing.Point(215, 218);
            this.textBoxYRes.Name = "textBoxYRes";
            this.textBoxYRes.Size = new System.Drawing.Size(77, 20);
            this.textBoxYRes.TabIndex = 16;
            // 
            // textBoxInstall
            // 
            this.textBoxInstall.Location = new System.Drawing.Point(132, 14);
            this.textBoxInstall.Name = "textBoxInstall";
            this.textBoxInstall.Size = new System.Drawing.Size(448, 20);
            this.textBoxInstall.TabIndex = 18;
            // 
            // buttonChooseUT2004
            // 
            this.buttonChooseUT2004.Location = new System.Drawing.Point(6, 13);
            this.buttonChooseUT2004.Name = "buttonChooseUT2004";
            this.buttonChooseUT2004.Size = new System.Drawing.Size(120, 21);
            this.buttonChooseUT2004.TabIndex = 19;
            this.buttonChooseUT2004.Text = "Choose UT2004 Install";
            this.buttonChooseUT2004.UseVisualStyleBackColor = true;
            this.buttonChooseUT2004.Click += new System.EventHandler(this.buttonChooseUT2004_Click);
            // 
            // buttonChooseDevEnv
            // 
            this.buttonChooseDevEnv.Location = new System.Drawing.Point(6, 33);
            this.buttonChooseDevEnv.Name = "buttonChooseDevEnv";
            this.buttonChooseDevEnv.Size = new System.Drawing.Size(120, 21);
            this.buttonChooseDevEnv.TabIndex = 20;
            this.buttonChooseDevEnv.Text = "Choose Dev Env";
            this.buttonChooseDevEnv.UseVisualStyleBackColor = true;
            this.buttonChooseDevEnv.Click += new System.EventHandler(this.buttonChooseDevEnv_Click);
            // 
            // buttonLaunchUdebugger
            // 
            this.buttonLaunchUdebugger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLaunchUdebugger.Location = new System.Drawing.Point(478, 198);
            this.buttonLaunchUdebugger.Name = "buttonLaunchUdebugger";
            this.buttonLaunchUdebugger.Size = new System.Drawing.Size(120, 40);
            this.buttonLaunchUdebugger.TabIndex = 21;
            this.buttonLaunchUdebugger.Text = "Launch UDEbugger";
            this.buttonLaunchUdebugger.UseVisualStyleBackColor = true;
            this.buttonLaunchUdebugger.Click += new System.EventHandler(this.buttonLaunchUdebugger_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.richTextBoxDebugOptions);
            this.groupBox1.Controls.Add(this.buttonLaunchUT2004);
            this.groupBox1.Controls.Add(this.buttonLaunchUdebugger);
            this.groupBox1.Controls.Add(this.buttonApplyDebugLaunchOptions);
            this.groupBox1.Controls.Add(this.checkBoxWindowed);
            this.groupBox1.Controls.Add(this.textBoxXRes);
            this.groupBox1.Controls.Add(this.labelYRes);
            this.groupBox1.Controls.Add(this.labelXRes);
            this.groupBox1.Controls.Add(this.textBoxYRes);
            this.groupBox1.Controls.Add(this.richTextBoxOutput);
            this.groupBox1.Location = new System.Drawing.Point(12, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 244);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // richTextBoxDebugOptions
            // 
            this.richTextBoxDebugOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxDebugOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDebugOptions.ForeColor = System.Drawing.Color.Red;
            this.richTextBoxDebugOptions.Location = new System.Drawing.Point(340, 209);
            this.richTextBoxDebugOptions.Name = "richTextBoxDebugOptions";
            this.richTextBoxDebugOptions.ReadOnly = true;
            this.richTextBoxDebugOptions.Size = new System.Drawing.Size(132, 22);
            this.richTextBoxDebugOptions.TabIndex = 23;
            this.richTextBoxDebugOptions.Text = "Launch Options: OFF";
            // 
            // buttonLaunchUT2004
            // 
            this.buttonLaunchUT2004.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLaunchUT2004.Enabled = false;
            this.buttonLaunchUT2004.Location = new System.Drawing.Point(604, 198);
            this.buttonLaunchUT2004.Name = "buttonLaunchUT2004";
            this.buttonLaunchUT2004.Size = new System.Drawing.Size(120, 40);
            this.buttonLaunchUT2004.TabIndex = 22;
            this.buttonLaunchUT2004.Text = "Launch UT2004";
            this.buttonLaunchUT2004.UseVisualStyleBackColor = true;
            this.buttonLaunchUT2004.Click += new System.EventHandler(this.buttonLaunchUT2004_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(593, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 39);
            this.label1.TabIndex = 23;
            this.label1.Text = "DEBUG - Add To UT2004.ini:\r\n[Editor.EditorEngine]\r\nEditPackages=3SPNCv42102\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCreateLocalDev);
            this.groupBox2.Controls.Add(this.buttonChooseUT2004);
            this.groupBox2.Controls.Add(this.textboxDevEnv);
            this.groupBox2.Controls.Add(this.buttonChooseDevEnv);
            this.groupBox2.Controls.Add(this.textBoxInstall);
            this.groupBox2.Location = new System.Drawing.Point(10, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(732, 65);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // buttonExportAll
            // 
            this.buttonExportAll.Location = new System.Drawing.Point(597, 150);
            this.buttonExportAll.Name = "buttonExportAll";
            this.buttonExportAll.Size = new System.Drawing.Size(145, 40);
            this.buttonExportAll.TabIndex = 21;
            this.buttonExportAll.Text = "Export All Base Unreal Classes";
            this.buttonExportAll.UseVisualStyleBackColor = true;
            this.buttonExportAll.Click += new System.EventHandler(this.buttonExportAll_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 501);
            this.Controls.Add(this.buttonExportAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxUccCmd);
            this.Controls.Add(this.checkBoxDebug);
            this.Controls.Add(this.buttonCompile);
            this.Controls.Add(this.textBoxProjectIni);
            this.Controls.Add(this.buttonProjectIni);
            this.Controls.Add(this.textBoxSystemFolderPath);
            this.Controls.Add(this.textBoxProjectFolderPath);
            this.Controls.Add(this.buttonSystemFolder);
            this.Controls.Add(this.buttonProjectFolder);
            this.Controls.Add(this.groupBox2);
            this.Icon = global::UT2004UCCAdvanced.Properties.Resources.UnrealEd;
            this.Name = "MainPage";
            this.Text = "Unreal Tournament 2004 UCC Advanced User Interface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_Exit);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProjectFolder;
        private System.Windows.Forms.Button buttonSystemFolder;
        private System.Windows.Forms.TextBox textBoxProjectFolderPath;
        private System.Windows.Forms.TextBox textBoxSystemFolderPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogProjectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSystemFolder;
        private System.Windows.Forms.TextBox textBoxProjectIni;
        private System.Windows.Forms.Button buttonProjectIni;
        private System.Windows.Forms.OpenFileDialog openFileDialogProjectIni;
        private System.Windows.Forms.Button buttonCompile;
        private System.Windows.Forms.CheckBox checkBoxDebug;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.TextBox textBoxUccCmd;
        private System.Windows.Forms.Button buttonCreateLocalDev;
        private System.Windows.Forms.TextBox textboxDevEnv;
        private System.Windows.Forms.Button buttonApplyDebugLaunchOptions;
        private System.Windows.Forms.CheckBox checkBoxWindowed;
        private System.Windows.Forms.TextBox textBoxXRes;
        private System.Windows.Forms.Label labelXRes;
        private System.Windows.Forms.Label labelYRes;
        private System.Windows.Forms.TextBox textBoxYRes;
        private System.Windows.Forms.TextBox textBoxInstall;
        private System.Windows.Forms.Button buttonChooseUT2004;
        private System.Windows.Forms.Button buttonChooseDevEnv;
        private System.Windows.Forms.Button buttonLaunchUdebugger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonLaunchUT2004;
        private System.Windows.Forms.RichTextBox richTextBoxDebugOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonExportAll;
    }
}

