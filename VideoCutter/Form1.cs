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
        #region TextBox Default Value
        private const string DefaultFfmpegFile = @"D:\ffmpeg\ffmpeg.exe";
        private const string DefaultInputFile = @"D:\ffmpeg\test1.mp4;D:\ffmpeg\test2.mp4";
        private const string DefaultOutputFile = @"D:\ffmpeg\test3.mp4";
        private const string DefaultStartTime = "00:00:00";
        private const string DefaultDurationTime = "00:00:00";
        #endregion

        #region Bind UI
        public string strFFMPEG
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string[] strINPUT
        {
            get { return textBox2.Text.Trim().Split(';'); }
            set
            {
                textBox2.Text = "";
                foreach (var item in value)
                {
                    textBox2.Text += item;
                    textBox2.Text += "; ";
                }
            }
        }
        public string strOUTPUT
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }
        public string strTimeStart
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string strTimeSpan
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public bool IsShowCmdWnd
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();

            //textBox1.Enabled = false;
            //textBox2.Enabled = false;
            //textBox3.Enabled = false;
#if DEBUG
            strFFMPEG = DefaultFfmpegFile;
            strINPUT = new string[1] { DefaultInputFile };
            strOUTPUT = DefaultOutputFile;
            textBox1.Text = DefaultFfmpegFile;
            textBox2.Text = DefaultInputFile;
            textBox3.Text = DefaultOutputFile;
#else
            textBox1.Text = "请选择核心文件ffmpeg.exe";
            textBox2.Text = "请选择预剪辑的视频文件";
            textBox3.Text = "请选择已剪辑的视频文件";
#endif
            textBox4.Text = DefaultStartTime;
            textBox5.Text = DefaultDurationTime;
        }

        #region UI 事件

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    strFFMPEG = openFileDialog.FileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    strINPUT = openFileDialog.FileNames;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "mp4 files (*.mp4)|*.mp4|All files (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    strOUTPUT = saveFileDialog.FileName;
                }
            }
        }

        /// <summary>
        /// 剪切按钮：点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            if (!IsPathCorrect(strFFMPEG) ||
                !IsPathCorrect(strINPUT[0]) ||
                !IsPathCorrect(strOUTPUT) || 
                !IsTimeStringCorrect(strTimeStart) ||
                !IsTimeStringCorrect(strTimeSpan))
            {
                return;
            }

            DateTime start = DateTime.Parse(strTimeStart.Trim());
            DateTime end = DateTime.Parse(strTimeSpan.Trim());
            TimeSpan span = end - start;

            string strCmd = string.Format($"{strFFMPEG} -ss {strTimeStart} -t {span.ToString()} -i {strINPUT[0]} -vcodec copy -acodec copy {strOUTPUT}");

            ExecutCmdProcess(strCmd);
        }

        /// <summary>
        /// 合并按钮：点击事件
        /// 命令格式：ffmpeg -i "concat:input1.mpg|input2.mpg|input3.mpg" -c copy output.mpg
        /// 已知问题：必需在同一文件夹内
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (!IsPathCorrect(strFFMPEG) ||
                !IsPathCorrect(strINPUT[0]) ||
                !IsPathCorrect(strOUTPUT))
            {
                return;
            }
            
            var temp = "";
            var length = strINPUT.Count();
            for (int i = 0; i < length; i++)
            {
                temp += "file " + Path.GetFileName(strINPUT[i]) + "\r\n";
            }

            var listfile = string.Format(Path.Combine(Path.GetDirectoryName(strINPUT[0]), "list.txt"));
            using (StreamWriter sw = new StreamWriter(listfile, false))
            {
                sw.Write(temp);
                sw.Flush();
                sw.Close();
            }

            var cmd = string.Format($"{strFFMPEG} -f concat -i {listfile} -c copy {strOUTPUT}");
            ExecutCmdProcess(cmd);
        }

        #endregion

        private void ExecutCmdProcess(string cmd)
        {
            using (Process CommandProcess = new Process())
            {
                CommandProcess.StartInfo.FileName = "cmd.exe";
                CommandProcess.StartInfo.Arguments = "/c " + cmd;
                CommandProcess.StartInfo.RedirectStandardInput = false;  // 重定向输入    
                CommandProcess.StartInfo.RedirectStandardOutput = false; // 重定向标准输出    
                CommandProcess.StartInfo.RedirectStandardError = false;  // 重定向错误输出  
                CommandProcess.StartInfo.UseShellExecute = false;
                CommandProcess.StartInfo.CreateNoWindow = IsShowCmdWnd ? false : true;

                try
                {
                    CommandProcess.Start();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private bool IsPathCorrect(string path)
        {
            bool flag = false;

            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("File path is null or empty!");
            }
            else
            {
                flag = true;
            }

            return flag;
        }

        private bool IsTimeStringCorrect(string time)
        {
            bool flag = false;
            DateTime temp;

            if (!DateTime.TryParse(time, out temp))
            {
                MessageBox.Show(string.Format($"{temp} cannot transform to DateTime!"));
            }
            else
            {
                flag = true;
            }

            return flag;
        }
    }
}
