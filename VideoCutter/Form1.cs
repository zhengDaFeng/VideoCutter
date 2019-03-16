using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoCutter
{
    public partial class Form1 : Form
    {
        private const string DefaultFfmpegFile = @"D:\ffmpeg\ffmpeg.exe";
        private const string DefaultInputFile = @"D:\ffmpeg\DI.mp4";
        private const string DefaultOutputFile = @"D:\ffmpeg\test.mp4";
        private const string DefaultStartTime = "00:00:00";
        private const string DefaultDurationTime = "00:00:20";

        public string strFFMPEG;
        public string[] strINPUT;
        public string strOUTPUT;

        public string strStartTime;
        public string strDurationTime;

        //private Process CommandProcess;
        //private ProcessStartInfo CommandProcessStartInfo;

        public Form1()
        {
            InitializeComponent();

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    strFFMPEG = openFileDialog.FileName;
                    textBox1.Text = strFFMPEG;
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
                    foreach (var item in strINPUT)
                    {
                        textBox2.Text += item;
                        textBox2.Text += "; ";
                    }
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
                    textBox3.Text = strOUTPUT;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||
                textBox2.Text == "" ||
                textBox3.Text == "" ||
                textBox4.Text == "" ||
                textBox5.Text == "")
            {
                MessageBox.Show("请先进行设当的设置！");
                return;
            }

            DateTime start = DateTime.Parse(textBox4.Text.Trim());
            DateTime end = DateTime.Parse(textBox5.Text.Trim());

            strStartTime = textBox4.Text.Trim();
            strDurationTime = (end - start).ToString();

            string strCmd = string.Format($"{strFFMPEG} -ss {strStartTime} -t {strDurationTime} -i {strINPUT[0]} -vcodec copy -acodec copy {strOUTPUT}");

            using (Process CommandProcess = new Process())
            {
                CommandProcess.StartInfo.FileName = "cmd.exe";
                CommandProcess.StartInfo.Arguments = "/c " + strCmd;
                CommandProcess.StartInfo.RedirectStandardInput = false;  // 重定向输入    
                CommandProcess.StartInfo.RedirectStandardOutput = false; // 重定向标准输出    
                CommandProcess.StartInfo.RedirectStandardError = false;  // 重定向错误输出  
                CommandProcess.StartInfo.UseShellExecute = false;
                CommandProcess.StartInfo.CreateNoWindow = false;
                
                CommandProcess.Start();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
