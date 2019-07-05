namespace VideoCutter
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtFfmpegFile = new System.Windows.Forms.TextBox();
            this.BtnBrowseFfmpeg = new System.Windows.Forms.Button();
            this.TxtClipInputFile = new System.Windows.Forms.TextBox();
            this.BtnClipBrowseInput = new System.Windows.Forms.Button();
            this.BtnClipBrowseOutput = new System.Windows.Forms.Button();
            this.TxtClipOutputFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnClipVideo = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NudEndSecond = new System.Windows.Forms.NumericUpDown();
            this.NudEndMinute = new System.Windows.Forms.NumericUpDown();
            this.NudEndHour = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NudStartSecond = new System.Windows.Forms.NumericUpDown();
            this.NudStartMinute = new System.Windows.Forms.NumericUpDown();
            this.NudStartHour = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnMergeVideo = new System.Windows.Forms.Button();
            this.BtnMergeAddInput = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnMergeBrowseOutput = new System.Windows.Forms.Button();
            this.BtnMergeBrowseInput = new System.Windows.Forms.Button();
            this.TxtMergeOutputFile = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtMergeInputFile = new System.Windows.Forms.TextBox();
            this.TxtLog = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudEndSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudEndMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStartSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStartMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStartHour)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtFfmpegFile
            // 
            this.TxtFfmpegFile.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.TxtFfmpegFile.Location = new System.Drawing.Point(134, 4);
            this.TxtFfmpegFile.Margin = new System.Windows.Forms.Padding(4);
            this.TxtFfmpegFile.Name = "TxtFfmpegFile";
            this.TxtFfmpegFile.ReadOnly = true;
            this.TxtFfmpegFile.Size = new System.Drawing.Size(352, 34);
            this.TxtFfmpegFile.TabIndex = 0;
            this.TxtFfmpegFile.TabStop = false;
            // 
            // BtnBrowseFfmpeg
            // 
            this.BtnBrowseFfmpeg.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.BtnBrowseFfmpeg.Location = new System.Drawing.Point(494, 4);
            this.BtnBrowseFfmpeg.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBrowseFfmpeg.Name = "BtnBrowseFfmpeg";
            this.BtnBrowseFfmpeg.Size = new System.Drawing.Size(112, 34);
            this.BtnBrowseFfmpeg.TabIndex = 0;
            this.BtnBrowseFfmpeg.Text = "Browse";
            this.BtnBrowseFfmpeg.UseVisualStyleBackColor = true;
            this.BtnBrowseFfmpeg.Click += new System.EventHandler(this.BtnBrowseFfmpeg_Click);
            // 
            // TxtClipInputFile
            // 
            this.TxtClipInputFile.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.TxtClipInputFile.Location = new System.Drawing.Point(126, 14);
            this.TxtClipInputFile.Margin = new System.Windows.Forms.Padding(4);
            this.TxtClipInputFile.Name = "TxtClipInputFile";
            this.TxtClipInputFile.ReadOnly = true;
            this.TxtClipInputFile.Size = new System.Drawing.Size(352, 34);
            this.TxtClipInputFile.TabIndex = 0;
            this.TxtClipInputFile.TabStop = false;
            // 
            // BtnClipBrowseInput
            // 
            this.BtnClipBrowseInput.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.BtnClipBrowseInput.Location = new System.Drawing.Point(486, 13);
            this.BtnClipBrowseInput.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClipBrowseInput.Name = "BtnClipBrowseInput";
            this.BtnClipBrowseInput.Size = new System.Drawing.Size(112, 34);
            this.BtnClipBrowseInput.TabIndex = 1;
            this.BtnClipBrowseInput.Text = "Browse";
            this.BtnClipBrowseInput.UseVisualStyleBackColor = true;
            this.BtnClipBrowseInput.Click += new System.EventHandler(this.BtnClipBrowseInput_Click);
            // 
            // BtnClipBrowseOutput
            // 
            this.BtnClipBrowseOutput.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.BtnClipBrowseOutput.Location = new System.Drawing.Point(486, 66);
            this.BtnClipBrowseOutput.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClipBrowseOutput.Name = "BtnClipBrowseOutput";
            this.BtnClipBrowseOutput.Size = new System.Drawing.Size(112, 34);
            this.BtnClipBrowseOutput.TabIndex = 2;
            this.BtnClipBrowseOutput.Text = "Browse";
            this.BtnClipBrowseOutput.UseVisualStyleBackColor = true;
            this.BtnClipBrowseOutput.Click += new System.EventHandler(this.BtnClipBrowseOutput_Click);
            // 
            // TxtClipOutputFile
            // 
            this.TxtClipOutputFile.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.TxtClipOutputFile.Location = new System.Drawing.Point(126, 65);
            this.TxtClipOutputFile.Margin = new System.Windows.Forms.Padding(4);
            this.TxtClipOutputFile.Name = "TxtClipOutputFile";
            this.TxtClipOutputFile.ReadOnly = true;
            this.TxtClipOutputFile.Size = new System.Drawing.Size(352, 34);
            this.TxtClipOutputFile.TabIndex = 3;
            this.TxtClipOutputFile.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "FFMPEG:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "INPUT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "OUTPUT:";
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.tabControl1.Location = new System.Drawing.Point(3, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 304);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnClipVideo);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.BtnClipBrowseOutput);
            this.tabPage1.Controls.Add(this.NudEndSecond);
            this.tabPage1.Controls.Add(this.BtnClipBrowseInput);
            this.tabPage1.Controls.Add(this.TxtClipOutputFile);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.NudEndMinute);
            this.tabPage1.Controls.Add(this.TxtClipInputFile);
            this.tabPage1.Controls.Add(this.NudEndHour);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.NudStartSecond);
            this.tabPage1.Controls.Add(this.NudStartMinute);
            this.tabPage1.Controls.Add(this.NudStartHour);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Location = new System.Drawing.Point(4, 36);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(621, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clip";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnClipVideo
            // 
            this.BtnClipVideo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnClipVideo.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.BtnClipVideo.Location = new System.Drawing.Point(485, 203);
            this.BtnClipVideo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnClipVideo.Name = "BtnClipVideo";
            this.BtnClipVideo.Size = new System.Drawing.Size(112, 34);
            this.BtnClipVideo.TabIndex = 9;
            this.BtnClipVideo.Text = "Clip";
            this.BtnClipVideo.UseVisualStyleBackColor = false;
            this.BtnClipVideo.Click += new System.EventHandler(this.BtnClipVideo_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(292, 170);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 27);
            this.label10.TabIndex = 30;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(193, 170);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 27);
            this.label11.TabIndex = 29;
            this.label11.Text = ":";
            // 
            // NudEndSecond
            // 
            this.NudEndSecond.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.NudEndSecond.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.NudEndSecond.Location = new System.Drawing.Point(324, 166);
            this.NudEndSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NudEndSecond.Name = "NudEndSecond";
            this.NudEndSecond.Size = new System.Drawing.Size(60, 34);
            this.NudEndSecond.TabIndex = 8;
            this.NudEndSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NudEndMinute
            // 
            this.NudEndMinute.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.NudEndMinute.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.NudEndMinute.Location = new System.Drawing.Point(225, 166);
            this.NudEndMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NudEndMinute.Name = "NudEndMinute";
            this.NudEndMinute.Size = new System.Drawing.Size(60, 34);
            this.NudEndMinute.TabIndex = 7;
            this.NudEndMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NudEndHour
            // 
            this.NudEndHour.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.NudEndHour.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.NudEndHour.Location = new System.Drawing.Point(126, 166);
            this.NudEndHour.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NudEndHour.Name = "NudEndHour";
            this.NudEndHour.Size = new System.Drawing.Size(60, 34);
            this.NudEndHour.TabIndex = 6;
            this.NudEndHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(292, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 27);
            this.label9.TabIndex = 25;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(193, 120);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 27);
            this.label8.TabIndex = 24;
            this.label8.Text = ":";
            // 
            // NudStartSecond
            // 
            this.NudStartSecond.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.NudStartSecond.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.NudStartSecond.Location = new System.Drawing.Point(324, 116);
            this.NudStartSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NudStartSecond.Name = "NudStartSecond";
            this.NudStartSecond.Size = new System.Drawing.Size(60, 34);
            this.NudStartSecond.TabIndex = 5;
            this.NudStartSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NudStartMinute
            // 
            this.NudStartMinute.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.NudStartMinute.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.NudStartMinute.Location = new System.Drawing.Point(225, 116);
            this.NudStartMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.NudStartMinute.Name = "NudStartMinute";
            this.NudStartMinute.Size = new System.Drawing.Size(60, 34);
            this.NudStartMinute.TabIndex = 4;
            this.NudStartMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NudStartHour
            // 
            this.NudStartHour.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.NudStartHour.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.NudStartHour.Location = new System.Drawing.Point(126, 116);
            this.NudStartHour.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NudStartHour.Name = "NudStartHour";
            this.NudStartHour.Size = new System.Drawing.Size(60, 34);
            this.NudStartHour.TabIndex = 3;
            this.NudStartHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 27);
            this.label6.TabIndex = 19;
            this.label6.Text = "START:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(55, 170);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 27);
            this.label7.TabIndex = 20;
            this.label7.Text = "END:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.BtnMergeVideo);
            this.tabPage2.Controls.Add(this.BtnMergeAddInput);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.BtnMergeBrowseOutput);
            this.tabPage2.Controls.Add(this.BtnMergeBrowseInput);
            this.tabPage2.Controls.Add(this.TxtMergeOutputFile);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.TxtMergeInputFile);
            this.tabPage2.Location = new System.Drawing.Point(4, 36);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Merge";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnMergeVideo
            // 
            this.BtnMergeVideo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnMergeVideo.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.BtnMergeVideo.Location = new System.Drawing.Point(485, 203);
            this.BtnMergeVideo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMergeVideo.Name = "BtnMergeVideo";
            this.BtnMergeVideo.Size = new System.Drawing.Size(111, 34);
            this.BtnMergeVideo.TabIndex = 13;
            this.BtnMergeVideo.Text = "Merge";
            this.BtnMergeVideo.UseVisualStyleBackColor = false;
            this.BtnMergeVideo.Click += new System.EventHandler(this.BtnMergeVideo_Click);
            // 
            // BtnMergeAddInput
            // 
            this.BtnMergeAddInput.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.BtnMergeAddInput.Location = new System.Drawing.Point(484, 119);
            this.BtnMergeAddInput.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMergeAddInput.Name = "BtnMergeAddInput";
            this.BtnMergeAddInput.Size = new System.Drawing.Size(112, 34);
            this.BtnMergeAddInput.TabIndex = 11;
            this.BtnMergeAddInput.Text = "Add";
            this.BtnMergeAddInput.UseVisualStyleBackColor = true;
            this.BtnMergeAddInput.Click += new System.EventHandler(this.BtnMergeAddInput_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 165);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 27);
            this.label12.TabIndex = 13;
            this.label12.Text = "OUTPUT:";
            // 
            // BtnMergeBrowseOutput
            // 
            this.BtnMergeBrowseOutput.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.BtnMergeBrowseOutput.Location = new System.Drawing.Point(484, 161);
            this.BtnMergeBrowseOutput.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMergeBrowseOutput.Name = "BtnMergeBrowseOutput";
            this.BtnMergeBrowseOutput.Size = new System.Drawing.Size(112, 34);
            this.BtnMergeBrowseOutput.TabIndex = 12;
            this.BtnMergeBrowseOutput.Text = "Browse";
            this.BtnMergeBrowseOutput.UseVisualStyleBackColor = true;
            this.BtnMergeBrowseOutput.Click += new System.EventHandler(this.BtnMergeBrowseOutput_Click);
            // 
            // BtnMergeBrowseInput
            // 
            this.BtnMergeBrowseInput.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.BtnMergeBrowseInput.Location = new System.Drawing.Point(486, 21);
            this.BtnMergeBrowseInput.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMergeBrowseInput.Name = "BtnMergeBrowseInput";
            this.BtnMergeBrowseInput.Size = new System.Drawing.Size(112, 34);
            this.BtnMergeBrowseInput.TabIndex = 10;
            this.BtnMergeBrowseInput.Text = "Browse";
            this.BtnMergeBrowseInput.UseVisualStyleBackColor = true;
            this.BtnMergeBrowseInput.Click += new System.EventHandler(this.BtnMergeBrowseInput_Click);
            // 
            // TxtMergeOutputFile
            // 
            this.TxtMergeOutputFile.Font = new System.Drawing.Font("Consolas", 11.25F);
            this.TxtMergeOutputFile.Location = new System.Drawing.Point(120, 161);
            this.TxtMergeOutputFile.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMergeOutputFile.Name = "TxtMergeOutputFile";
            this.TxtMergeOutputFile.ReadOnly = true;
            this.TxtMergeOutputFile.Size = new System.Drawing.Size(357, 34);
            this.TxtMergeOutputFile.TabIndex = 10;
            this.TxtMergeOutputFile.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 28);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 27);
            this.label13.TabIndex = 12;
            this.label13.Text = "INPUT:";
            // 
            // TxtMergeInputFile
            // 
            this.TxtMergeInputFile.Font = new System.Drawing.Font("Consolas", 9F);
            this.TxtMergeInputFile.Location = new System.Drawing.Point(120, 22);
            this.TxtMergeInputFile.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMergeInputFile.Multiline = true;
            this.TxtMergeInputFile.Name = "TxtMergeInputFile";
            this.TxtMergeInputFile.ReadOnly = true;
            this.TxtMergeInputFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtMergeInputFile.Size = new System.Drawing.Size(358, 131);
            this.TxtMergeInputFile.TabIndex = 8;
            this.TxtMergeInputFile.TabStop = false;
            this.TxtMergeInputFile.WordWrap = false;
            // 
            // TxtLog
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.TxtLog, 3);
            this.TxtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtLog.Location = new System.Drawing.Point(3, 355);
            this.TxtLog.Multiline = true;
            this.TxtLog.Name = "TxtLog";
            this.TxtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtLog.Size = new System.Drawing.Size(629, 337);
            this.TxtLog.TabIndex = 26;
            this.TxtLog.WordWrap = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TxtLog, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TxtFfmpegFile, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnBrowseFfmpeg, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(635, 695);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(635, 695);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.Text = "Zdfffg\'s Video Cutter";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudEndSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudEndMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStartSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStartMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudStartHour)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TxtFfmpegFile;
        private System.Windows.Forms.Button BtnBrowseFfmpeg;
        private System.Windows.Forms.TextBox TxtClipInputFile;
        private System.Windows.Forms.Button BtnClipBrowseInput;
        private System.Windows.Forms.Button BtnClipBrowseOutput;
        private System.Windows.Forms.TextBox TxtClipOutputFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button BtnClipVideo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NudEndSecond;
        private System.Windows.Forms.NumericUpDown NudEndMinute;
        private System.Windows.Forms.NumericUpDown NudEndHour;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NudStartSecond;
        private System.Windows.Forms.NumericUpDown NudStartMinute;
        private System.Windows.Forms.NumericUpDown NudStartHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnMergeVideo;
        private System.Windows.Forms.Button BtnMergeAddInput;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnMergeBrowseOutput;
        private System.Windows.Forms.Button BtnMergeBrowseInput;
        private System.Windows.Forms.TextBox TxtMergeOutputFile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtMergeInputFile;
        private System.Windows.Forms.TextBox TxtLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

