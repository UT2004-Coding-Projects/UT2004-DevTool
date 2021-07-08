using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UT2004UCCAdvanced
{
    public partial class MainPage : Form
    {
        private string _launchOptions;
        private bool _useLaunchOptions;
        private StringBuilder _uccProcOutput;
        private List<string> _debugPackages = new List<string>
        {
            "BonusPack.u",
            "Core.u",
            "Editor.u",
            "Engine.u",
            "Fire.u",
            "GamePlay.u",
            "GUI2K4.u",
            "IpDrv.u",
            "Onslaught.u",
            "OnslaughtBP.u",
            "OnslaughtFull.u",
            "SkaarjPack.u",
            "SkaarjPack_rc.u",
            "StreamlineFX.u",
            "UnrealEd.u",
            "UnrealGame.u",
            "UT2k4Assault.u",
            "UT2k4AssaultFull.u",
            "UTClassic.u",
            "UTV2004c.u",
            "UTV2004s.u",
            "UWeb.u",
            "Vehicles.u",
            "XAdmin.u",
            "XEffects.u",
            "XGame.u",
            "XGame_rc.u",
            "XInterface.u",
            "XPickups.u",
            "XPickups_rc.u",
            "xVoting.u",
            "XWeapons.u",
            "XWeapons_rc.u",
            "XWebAdmin.u"
        };

        public MainPage()
        {
            InitializeComponent();
            this._uccProcOutput = new StringBuilder("Beginning Compile...");
            this.textBoxProjectFolderPath.Text = Properties.Settings.Default.settingLastProjectFolder;
            this.textBoxSystemFolderPath.Text = Properties.Settings.Default.settingLastSystemFolder;
            this.textBoxInstall.Text = Properties.Settings.Default.settingLastInstall;
            this.textboxDevEnv.Text = Properties.Settings.Default.settingLastDevEnv;
            this.textBoxProjectIni.Text = Properties.Settings.Default.settingLastIni;
            this.checkBoxWindowed.Checked = Properties.Settings.Default.settingLastWindowed;
            this.textBoxXRes.Text = Properties.Settings.Default.settingLastXRes;
            this.textBoxYRes.Text = Properties.Settings.Default.settingLastYRes;

            if (Properties.Settings.Default.settingLaunchOptions)
                this._useLaunchOptions = true;
            else
                this._useLaunchOptions = false;

            this.buttonApplyDebugLaunchOptions_Click(this, new EventArgs());
        }

        private void buttonProjectFolder_Click(object sender, EventArgs e)
        {
            DialogResult dRes = this.folderBrowserDialogProjectFolder.ShowDialog();

            if (dRes == DialogResult.OK)
            {
                this.textBoxProjectFolderPath.Text = this.folderBrowserDialogProjectFolder.SelectedPath;
                Properties.Settings.Default.settingLastProjectFolder = this.textBoxProjectFolderPath.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void buttonSystemFolder_Click(object sender, EventArgs e)
        {
            DialogResult dRes = this.folderBrowserDialogSystemFolder.ShowDialog();

            if (dRes == DialogResult.OK)
            {
                this.textBoxSystemFolderPath.Text = this.folderBrowserDialogSystemFolder.SelectedPath;
                Properties.Settings.Default.settingLastSystemFolder = this.textBoxSystemFolderPath.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void buttonProjectIni_Click(object sender, EventArgs e)
        {
            DialogResult dRes = this.openFileDialogProjectIni.ShowDialog();

            if (dRes == DialogResult.OK)
            {
                this.textBoxProjectIni.Text = this.openFileDialogProjectIni.FileName;
                Properties.Settings.Default.settingLastIni = this.textBoxProjectIni.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void buttonCompile_Click(object sender, EventArgs e)
        {
            string uccParams = "make";

            if (this.checkBoxDebug.Checked)
                uccParams += " -debug";

            uccParams += " ini=\"" + this.textBoxProjectIni.Text + "\"";

            Process uccProc = new Process();
            uccProc.StartInfo.FileName = this.textBoxSystemFolderPath.Text + "\\ucc.exe";
            uccProc.StartInfo.Arguments = uccParams;
            uccProc.StartInfo.CreateNoWindow = true;

            uccProc.StartInfo.RedirectStandardOutput = true;
            uccProc.StartInfo.UseShellExecute = false;
            uccProc.OutputDataReceived += new DataReceivedEventHandler(uccProcOutputHandler);
            this.textBoxUccCmd.Text = uccProc.StartInfo.FileName + " " + uccParams;
            this.richTextBoxOutput.Text = this._uccProcOutput.ToString();

            uccProc.Start();
            uccProc.BeginOutputReadLine();
            while (!uccProc.HasExited)
            {
                Application.DoEvents();
            }
        }

        private void uccProcOutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (this.richTextBoxOutput.InvokeRequired)
            {
                this.richTextBoxOutput.BeginInvoke(new DataReceivedEventHandler(uccProcOutputHandler), new[] { sendingProcess, outLine });
            }
            else
            {
                this._uccProcOutput.Clear();
                this._uccProcOutput.Append(Environment.NewLine + "[" + "ucc.exe" + "] - " + outLine.Data);
                this.richTextBoxOutput.AppendText(this._uccProcOutput.ToString());

                richTextBoxOutput.SelectionStart = richTextBoxOutput.Text.Length;
                richTextBoxOutput.ScrollToCaret();
            }
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void MainPage_Exit(object sender, EventArgs e)
        {
            Properties.Settings.Default.settingLastProjectFolder = this.textBoxProjectFolderPath.Text;
            Properties.Settings.Default.settingLastSystemFolder = this.textBoxSystemFolderPath.Text;
            Properties.Settings.Default.settingLastDevEnv = this.textBoxInstall.Text;
            Properties.Settings.Default.settingLastDevEnv = this.textboxDevEnv.Text;
            Properties.Settings.Default.settingLastIni = this.textBoxProjectIni.Text;
            Properties.Settings.Default.settingLastWindowed = this.checkBoxWindowed.Checked;
            Properties.Settings.Default.settingLastXRes = this.textBoxXRes.Text;
            Properties.Settings.Default.settingLastYRes = this.textBoxYRes.Text;
            Properties.Settings.Default.Save();
        }

        private void buttonChooseDevEnv_Click(object sender, EventArgs e)
        {
            DialogResult dRes = this.folderBrowserDialogProjectFolder.ShowDialog();

            if (dRes == DialogResult.OK)
            {
                this.textboxDevEnv.Text = this.folderBrowserDialogProjectFolder.SelectedPath;
                Properties.Settings.Default.settingLastDevEnv = this.textboxDevEnv.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void buttonChooseUT2004_Click(object sender, EventArgs e)
        {
            DialogResult dRes = this.folderBrowserDialogProjectFolder.ShowDialog();

            if (dRes == DialogResult.OK)
            {
                this.textBoxInstall.Text = this.folderBrowserDialogProjectFolder.SelectedPath;
                Properties.Settings.Default.settingLastInstall = this.textBoxInstall.Text;
                Properties.Settings.Default.Save();
            }
        }

        private void buttonCreateLocalDev_Click(object sender, EventArgs e)
        {
            DirectoryCopy(this.textBoxInstall.Text, this.textboxDevEnv.Text, true);

            var assembly = Assembly.GetExecutingAssembly();

            foreach (var pack in this._debugPackages)
            {
                Stream resourceInput = assembly.GetManifestResourceStream("UT2004UCCAdvanced.Resources." + pack);
                resourceInput.CopyTo(File.Create(this.textboxDevEnv.Text + "\\System\\" + pack));
            }
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }

        private void buttonLaunchUdebugger_Click(object sender, EventArgs e)
        {
            Process udebug = new Process();
            udebug.StartInfo.FileName = this.textBoxSystemFolderPath.Text + "\\UDebugger.exe";


            //udebug.StartInfo.Arguments = "-windowed '-width 1280' '-height 720'";
            udebug.StartInfo.Arguments = this._launchOptions;


            udebug.Start();
            while (!udebug.HasExited)
            {
                Application.DoEvents();
            }
        }

        private void buttonLaunchUT2004_Click(object sender, EventArgs e)
        {
            Process uccProc = new Process();
            uccProc.StartInfo.FileName = this.textBoxSystemFolderPath.Text + "\\UT2004.exe";

            uccProc.Start();
            while (!uccProc.HasExited)
            {
                Application.DoEvents();
            }
        }

        private void buttonApplyDebugLaunchOptions_Click(object sender, EventArgs e)
        {
            if (this._useLaunchOptions)
            {
                this.richTextBoxDebugOptions.Text = "Launch Options: ON";
                this.richTextBoxDebugOptions.ForeColor = Color.Green;
                this.buttonApplyDebugLaunchOptions.Text = "Remove Debug Launch Options";

                Properties.Settings.Default.settingLastWindowed = this.checkBoxWindowed.Checked;
                Properties.Settings.Default.settingLastXRes = this.textBoxXRes.Text;
                Properties.Settings.Default.settingLastYRes = this.textBoxYRes.Text;
                Properties.Settings.Default.settingLaunchOptions = true;
                Properties.Settings.Default.Save();

                this._launchOptions = "";

                if (this.checkBoxWindowed.Checked)
                    this._launchOptions += "-windowed ";

                if (this.textBoxXRes.Text != "" && this.textBoxYRes.Text != "")
                {
                    string res = "";
                    res += "'-setres ";
                    res += this.textBoxXRes.Text;
                    res += "x";
                    res += this.textBoxYRes.Text;
                    res += "'";
                    this._launchOptions += res;
                }

                this._useLaunchOptions = false;
            }
            else
            {
                this.richTextBoxDebugOptions.Text = "Launch Options: OFF";
                this.richTextBoxDebugOptions.ForeColor = Color.Red;
                this.buttonApplyDebugLaunchOptions.Text = "Apply Debug Launch Options";

                this._launchOptions = "";
                Properties.Settings.Default.settingLaunchOptions = false;
                Properties.Settings.Default.Save();

                this._useLaunchOptions = true;
            }
        }

        private void buttonExportAll_Click(object sender, EventArgs e)
        {      
            foreach(var pack in this._debugPackages)
            {
                string[] packNoExt = pack.Split(".".ToCharArray());
                string uccParams = "batchexport " + packNoExt[0] + " class uc ..\\" + packNoExt[0] + "\\Classes";

                Process uccProc = new Process();
                uccProc.StartInfo.FileName = this.textBoxSystemFolderPath.Text + "\\ucc.exe";
                uccProc.StartInfo.Arguments = uccParams;
                uccProc.StartInfo.CreateNoWindow = true;

                uccProc.StartInfo.RedirectStandardOutput = true;
                uccProc.StartInfo.UseShellExecute = false;
                uccProc.OutputDataReceived += new DataReceivedEventHandler(uccProcOutputHandler);
                this.textBoxUccCmd.Text = uccProc.StartInfo.FileName + " " + uccParams;
                this.richTextBoxOutput.Text = this._uccProcOutput.ToString();

                uccProc.Start();
                uccProc.BeginOutputReadLine();
                while (!uccProc.HasExited)
                {
                    Application.DoEvents();
                }
            }
        }
    }
}
