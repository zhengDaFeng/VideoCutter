using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoCutter
{
    public partial class Form1 : Form
    {
        #region Default



        #endregion

        #region Properties



        #endregion

        #region Constructor

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Button Click

        private void BtnBrowseFfmpeg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TxtFfmpegFile.Text = openFileDialog.FileName;
                }
            }
        }

        private void BtnClipBrowseInput_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TxtClipInputFile.Text = openFileDialog.FileName;
                }
            }
        }

        private void BtnClipBrowseOutput_Click(object sender, EventArgs e)
        {
            if (!CheckFile(TxtClipInputFile.Text))
            {
                return;
            }

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    var folder = folderBrowserDialog.SelectedPath;
                    var nameOld = Path.GetFileNameWithoutExtension(TxtClipInputFile.Text);
                    var nameNew = TxtClipInputFile.Text.Replace(nameOld, nameOld + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_clip");
                    TxtClipOutputFile.Text = Path.Combine(folder, nameNew);
                }
            }
        }

        /// <summary>
        /// 剪辑视频
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClipVideo_Click(object sender, EventArgs e)
        {
            if (!CheckFile(TxtFfmpegFile.Text) || !CheckFile(TxtClipInputFile.Text))
            {
                return;
            }

            DateTime startTime = DateTime.Parse($"{NudStartHour.Value.ToString("00")}:" +
                $"{NudStartMinute.Value.ToString("00")}:{NudStartSecond.Value.ToString("00")}");
            DateTime endTime = DateTime.Parse($"{NudEndHour.Value.ToString("00")}:" +
                $"{NudEndMinute.Value.ToString("00")}:{NudEndSecond.Value.ToString("00")}");
            TimeSpan spanTime = endTime - startTime;

            if (spanTime.TotalSeconds <= 0)
            {
                MessageBox.Show("End-time must be bigger than start-time!");
                return;
            }

            progressBar2.Maximum = (int)spanTime.TotalSeconds;

            var start = startTime.ToString("HH:mm:ss");
            var span = spanTime.ToString();
            
            var strCmd = string.Format($"{TxtFfmpegFile.Text} -ss {start} -t {span} " +
                $"-i {TxtClipInputFile.Text} -vcodec copy -acodec copy {TxtClipOutputFile.Text}");
            ExecutCmdProcess(strCmd);
        }

        private void BtnMergeBrowseInput_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] files = openFileDialog.FileNames;
                    TxtMergeInputFile.Text = "";
                    foreach (var item in files)
                    {
                        TxtMergeInputFile.Text += item;
                        TxtMergeInputFile.Text += ";\r\n";
                    }
                }
            }
        }

        private void BtnMergeAddInput_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] files = openFileDialog.FileNames;
                    foreach (var item in files)
                    {
                        TxtMergeInputFile.Text += item;
                        TxtMergeInputFile.Text += "; ";
                    }
                }
            }
        }

        private void BtnMergeBrowseOutput_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    var folder = folderBrowserDialog.SelectedPath;
                    var first = TxtMergeInputFile.Text.Replace("\r\n", "").Split(';')[0];
                    var nameOld = Path.GetFileNameWithoutExtension(first);
                    var nameNew = first.Replace(nameOld, nameOld + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + "_merge");
                    TxtMergeOutputFile.Text = Path.Combine(folder, nameNew);
                }
            }
        }

        /// <summary>
        /// 合并按钮：点击事件
        /// 命令格式：ffmpeg -i "concat:input1.mpg|input2.mpg|input3.mpg" -c copy output.mpg
        /// 已知问题：必需在同一文件夹内
        /// </summary>
        private void BtnMergeVideo_Click(object sender, EventArgs e)
        {
            var files = TxtMergeInputFile.Text.Replace("\r\n", "").Split(';');
            var temp = "";
            foreach (var item in files)
            {
                if (item != "")
                {
                    temp += "file " + item + "\r\n";
                }
            }

            var listfile = string.Format(Path.Combine(Path.GetDirectoryName(files[0]), "list.txt"));
            try
            {
                using (StreamWriter sw = new StreamWriter(listfile, false))
                {
                    sw.Write(temp);
                    sw.Flush();
                    sw.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

            progressBar2.Maximum = 200;

            var cmd = string.Format($"{TxtFfmpegFile.Text} -f concat -safe 0 -i {listfile} -c copy {TxtMergeOutputFile.Text}");
            ExecutCmdProcess(cmd);
        }

        #endregion

        #region Private Method

        private bool CheckFile(string file)
        {
            if (file == "")
            {
                MessageBox.Show($"Please set all the file path!");
                return false;
            }

            if (!File.Exists(file))
            {
                MessageBox.Show($"Cannot find {file}!");
                return false;
            }

            return true;
        }

        private void ExecutCmdProcess(string cmd)
        {
            using (Process CommandProcess = new Process())
            {
                CommandProcess.StartInfo.FileName = "cmd.exe";
                CommandProcess.StartInfo.Arguments = "/c " + cmd;
                CommandProcess.StartInfo.RedirectStandardInput = false;  // 重定向输入    
                CommandProcess.StartInfo.RedirectStandardOutput = false; // 重定向标准输出    
                CommandProcess.StartInfo.RedirectStandardError = true;  // 重定向错误输出  
                CommandProcess.StartInfo.UseShellExecute = false;
                CommandProcess.StartInfo.CreateNoWindow = true;

                try
                {
                    CommandProcess.ErrorDataReceived += new DataReceivedEventHandler(HandleErrorDataReceived);
                    CommandProcess.Start();
                    CommandProcess.BeginErrorReadLine();
                    //CommandProcess.WaitForExit();//等待程序执行完退出进程
                    //progressBar2.Value = progressBar2.Maximum;
                    //CommandProcess.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void HandleErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            lock(sender)
            {
                if (String.IsNullOrEmpty(e.Data))
                {
                    return;
                }
                
                this.BeginInvoke(new Action(() =>
                {
                    TxtLog.AppendText(e.Data + "\r\n");
                }));

                var index = e.Data.LastIndexOf("time=");
                if (index == -1)
                {
                    return;
                }
                var timeTemp = e.Data.Substring(index + 5, 11);
                var time = DateTime.Parse(timeTemp);
                var second = time.Hour * 3600 + time.Minute * 60 + time.Second;

                this.BeginInvoke(new Action(() =>
                {
                    if (second >= progressBar2.Maximum)
                    {
                        progressBar2.Value = progressBar2.Maximum;
                    }
                    else
                    {
                        progressBar2.Value = second;
                    }
                    if (e.Data.LastIndexOf("overhead") != -1)
                    {
                        progressBar2.Value = progressBar2.Maximum;
                    }
                    progressBar2.Update();
                }));
            }
        }

        #endregion
    }
}
