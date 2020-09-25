namespace VideoMusicDownloader
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblVideoTitle = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.lblStat = new System.Windows.Forms.Label();
            this.lblPickedFile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDeleteOriginal = new System.Windows.Forms.CheckBox();
            this.btnPickFile = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.cbMusic = new System.Windows.Forms.CheckBox();
            this.cbVideo = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Location = new System.Drawing.Point(17, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 521);
            this.tabControl1.TabIndex = 1;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.lblStatus);
            this.tab1.Controls.Add(this.lblProgress);
            this.tab1.Controls.Add(this.pbDownload);
            this.tab1.Controls.Add(this.btnDownload);
            this.tab1.Controls.Add(this.lblVideoTitle);
            this.tab1.Controls.Add(this.btnLoad);
            this.tab1.Controls.Add(this.tbLink);
            this.tab1.Controls.Add(this.label2);
            this.tab1.Location = new System.Drawing.Point(4, 25);
            this.tab1.Margin = new System.Windows.Forms.Padding(4);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(4);
            this.tab1.Size = new System.Drawing.Size(648, 492);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "YouTube";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(8, 272);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 17);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Status";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(-525, -223);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(65, 17);
            this.lblProgress.TabIndex = 9;
            this.lblProgress.Text = "Progress";
            this.lblProgress.Visible = false;
            // 
            // pbDownload
            // 
            this.pbDownload.Location = new System.Drawing.Point(8, 230);
            this.pbDownload.Margin = new System.Windows.Forms.Padding(4);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(629, 28);
            this.pbDownload.TabIndex = 8;
            this.pbDownload.Visible = false;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(369, 179);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(268, 43);
            this.btnDownload.TabIndex = 7;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Visible = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // lblVideoTitle
            // 
            this.lblVideoTitle.AutoSize = true;
            this.lblVideoTitle.Location = new System.Drawing.Point(8, 146);
            this.lblVideoTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVideoTitle.Name = "lblVideoTitle";
            this.lblVideoTitle.Size = new System.Drawing.Size(75, 17);
            this.lblVideoTitle.TabIndex = 3;
            this.lblVideoTitle.Text = "Video Title";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(369, 80);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(268, 43);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(51, 15);
            this.tbLink.Margin = new System.Windows.Forms.Padding(4);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(586, 22);
            this.tbLink.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Link:";
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.lblStat);
            this.tab2.Controls.Add(this.lblPickedFile);
            this.tab2.Controls.Add(this.label3);
            this.tab2.Controls.Add(this.cbDeleteOriginal);
            this.tab2.Controls.Add(this.btnPickFile);
            this.tab2.Controls.Add(this.btnConvert);
            this.tab2.Controls.Add(this.tbMain);
            this.tab2.Controls.Add(this.cbMusic);
            this.tab2.Controls.Add(this.cbVideo);
            this.tab2.Location = new System.Drawing.Point(4, 25);
            this.tab2.Margin = new System.Windows.Forms.Padding(4);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(648, 492);
            this.tab2.TabIndex = 1;
            this.tab2.Text = "Video Converter";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // lblStat
            // 
            this.lblStat.AutoSize = true;
            this.lblStat.Location = new System.Drawing.Point(24, 431);
            this.lblStat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStat.Name = "lblStat";
            this.lblStat.Size = new System.Drawing.Size(48, 17);
            this.lblStat.TabIndex = 21;
            this.lblStat.Text = "Status";
            // 
            // lblPickedFile
            // 
            this.lblPickedFile.AutoSize = true;
            this.lblPickedFile.Location = new System.Drawing.Point(24, 94);
            this.lblPickedFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPickedFile.Name = "lblPickedFile";
            this.lblPickedFile.Size = new System.Drawing.Size(43, 17);
            this.lblPickedFile.TabIndex = 20;
            this.lblPickedFile.Text = "Label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Label";
            // 
            // cbDeleteOriginal
            // 
            this.cbDeleteOriginal.AutoSize = true;
            this.cbDeleteOriginal.Location = new System.Drawing.Point(27, 228);
            this.cbDeleteOriginal.Margin = new System.Windows.Forms.Padding(4);
            this.cbDeleteOriginal.Name = "cbDeleteOriginal";
            this.cbDeleteOriginal.Size = new System.Drawing.Size(151, 21);
            this.cbDeleteOriginal.TabIndex = 18;
            this.cbDeleteOriginal.Text = "Delete original file?";
            this.cbDeleteOriginal.UseVisualStyleBackColor = true;
            // 
            // btnPickFile
            // 
            this.btnPickFile.Location = new System.Drawing.Point(27, 20);
            this.btnPickFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPickFile.Name = "btnPickFile";
            this.btnPickFile.Size = new System.Drawing.Size(268, 43);
            this.btnPickFile.TabIndex = 17;
            this.btnPickFile.Text = "Pick File";
            this.btnPickFile.UseVisualStyleBackColor = true;
            this.btnPickFile.Click += new System.EventHandler(this.btnPickFile_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(27, 372);
            this.btnConvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(268, 43);
            this.btnConvert.TabIndex = 16;
            this.btnConvert.Text = "Convert and Save";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Visible = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // tbMain
            // 
            this.tbMain.Location = new System.Drawing.Point(186, 168);
            this.tbMain.Margin = new System.Windows.Forms.Padding(4);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbMain.Size = new System.Drawing.Size(446, 196);
            this.tbMain.TabIndex = 15;
            // 
            // cbMusic
            // 
            this.cbMusic.AutoSize = true;
            this.cbMusic.Location = new System.Drawing.Point(27, 170);
            this.cbMusic.Margin = new System.Windows.Forms.Padding(4);
            this.cbMusic.Name = "cbMusic";
            this.cbMusic.Size = new System.Drawing.Size(66, 21);
            this.cbMusic.TabIndex = 14;
            this.cbMusic.Text = "Music";
            this.cbMusic.UseVisualStyleBackColor = true;
            // 
            // cbVideo
            // 
            this.cbVideo.AutoSize = true;
            this.cbVideo.Location = new System.Drawing.Point(27, 200);
            this.cbVideo.Margin = new System.Windows.Forms.Padding(4);
            this.cbVideo.Name = "cbVideo";
            this.cbVideo.Size = new System.Drawing.Size(66, 21);
            this.cbVideo.TabIndex = 13;
            this.cbVideo.Text = "Video";
            this.cbVideo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 550);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoConverter";
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.tab2.ResumeLayout(false);
            this.tab2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar pbDownload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblVideoTitle;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.Label lblPickedFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbDeleteOriginal;
        private System.Windows.Forms.Button btnPickFile;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox tbMain;
        private System.Windows.Forms.CheckBox cbMusic;
        private System.Windows.Forms.CheckBox cbVideo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStat;
    }
}

