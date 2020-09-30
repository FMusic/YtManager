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
            this.yt = new System.Windows.Forms.TabPage();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.btnDownload = new System.Windows.Forms.Button();
            this.lblVideoTitle = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vidconv = new System.Windows.Forms.TabPage();
            this.lblStat = new System.Windows.Forms.Label();
            this.lblPickedFile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDeleteOriginal = new System.Windows.Forms.CheckBox();
            this.btnPickFile = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.tbMain = new System.Windows.Forms.TextBox();
            this.cbMusic = new System.Windows.Forms.CheckBox();
            this.cbVideo = new System.Windows.Forms.CheckBox();
            this.mp34tag = new System.Windows.Forms.TabPage();
            this.lbTags = new System.Windows.Forms.ListBox();
            this.tbGenre = new System.Windows.Forms.TextBox();
            this.tbAlbum = new System.Windows.Forms.TextBox();
            this.tbAlbumArtist = new System.Windows.Forms.TextBox();
            this.tbArtist = new System.Windows.Forms.TextBox();
            this.tbTrackTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnMakePlaylist = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSaveTags = new System.Windows.Forms.Button();
            this.btnSelectTagFiles = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.yt.SuspendLayout();
            this.vidconv.SuspendLayout();
            this.mp34tag.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.yt);
            this.tabControl1.Controls.Add(this.vidconv);
            this.tabControl1.Controls.Add(this.mp34tag);
            this.tabControl1.Location = new System.Drawing.Point(17, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(656, 521);
            this.tabControl1.TabIndex = 1;
            // 
            // yt
            // 
            this.yt.Controls.Add(this.lblStatus);
            this.yt.Controls.Add(this.lblProgress);
            this.yt.Controls.Add(this.pbDownload);
            this.yt.Controls.Add(this.btnDownload);
            this.yt.Controls.Add(this.lblVideoTitle);
            this.yt.Controls.Add(this.btnLoad);
            this.yt.Controls.Add(this.tbLink);
            this.yt.Controls.Add(this.label2);
            this.yt.Location = new System.Drawing.Point(4, 25);
            this.yt.Margin = new System.Windows.Forms.Padding(4);
            this.yt.Name = "yt";
            this.yt.Padding = new System.Windows.Forms.Padding(4);
            this.yt.Size = new System.Drawing.Size(648, 492);
            this.yt.TabIndex = 0;
            this.yt.Text = "YouTube";
            this.yt.UseVisualStyleBackColor = true;
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
            // vidconv
            // 
            this.vidconv.Controls.Add(this.lblStat);
            this.vidconv.Controls.Add(this.lblPickedFile);
            this.vidconv.Controls.Add(this.label3);
            this.vidconv.Controls.Add(this.cbDeleteOriginal);
            this.vidconv.Controls.Add(this.btnPickFile);
            this.vidconv.Controls.Add(this.btnConvert);
            this.vidconv.Controls.Add(this.tbMain);
            this.vidconv.Controls.Add(this.cbMusic);
            this.vidconv.Controls.Add(this.cbVideo);
            this.vidconv.Location = new System.Drawing.Point(4, 25);
            this.vidconv.Margin = new System.Windows.Forms.Padding(4);
            this.vidconv.Name = "vidconv";
            this.vidconv.Size = new System.Drawing.Size(648, 492);
            this.vidconv.TabIndex = 1;
            this.vidconv.Text = "Video Converter";
            this.vidconv.UseVisualStyleBackColor = true;
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
            // mp34tag
            // 
            this.mp34tag.Controls.Add(this.lbTags);
            this.mp34tag.Controls.Add(this.tbGenre);
            this.mp34tag.Controls.Add(this.tbAlbum);
            this.mp34tag.Controls.Add(this.tbAlbumArtist);
            this.mp34tag.Controls.Add(this.tbArtist);
            this.mp34tag.Controls.Add(this.tbTrackTitle);
            this.mp34tag.Controls.Add(this.label8);
            this.mp34tag.Controls.Add(this.btnMakePlaylist);
            this.mp34tag.Controls.Add(this.label7);
            this.mp34tag.Controls.Add(this.label6);
            this.mp34tag.Controls.Add(this.label5);
            this.mp34tag.Controls.Add(this.label4);
            this.mp34tag.Controls.Add(this.btnSaveTags);
            this.mp34tag.Controls.Add(this.btnSelectTagFiles);
            this.mp34tag.Location = new System.Drawing.Point(4, 25);
            this.mp34tag.Name = "mp34tag";
            this.mp34tag.Size = new System.Drawing.Size(648, 492);
            this.mp34tag.TabIndex = 2;
            this.mp34tag.Text = "MP3 & MP4 tag editor";
            this.mp34tag.UseVisualStyleBackColor = true;
            // 
            // lbTags
            // 
            this.lbTags.FormattingEnabled = true;
            this.lbTags.ItemHeight = 16;
            this.lbTags.Location = new System.Drawing.Point(13, 63);
            this.lbTags.Name = "lbTags";
            this.lbTags.Size = new System.Drawing.Size(268, 420);
            this.lbTags.TabIndex = 32;
            this.lbTags.SelectedIndexChanged += new System.EventHandler(this.lbTags_SelectedIndexChanged);
            // 
            // tbGenre
            // 
            this.tbGenre.Location = new System.Drawing.Point(441, 172);
            this.tbGenre.Name = "tbGenre";
            this.tbGenre.Size = new System.Drawing.Size(172, 22);
            this.tbGenre.TabIndex = 31;
            // 
            // tbAlbum
            // 
            this.tbAlbum.Location = new System.Drawing.Point(441, 144);
            this.tbAlbum.Name = "tbAlbum";
            this.tbAlbum.Size = new System.Drawing.Size(172, 22);
            this.tbAlbum.TabIndex = 30;
            // 
            // tbAlbumArtist
            // 
            this.tbAlbumArtist.Location = new System.Drawing.Point(441, 116);
            this.tbAlbumArtist.Name = "tbAlbumArtist";
            this.tbAlbumArtist.Size = new System.Drawing.Size(172, 22);
            this.tbAlbumArtist.TabIndex = 29;
            // 
            // tbArtist
            // 
            this.tbArtist.Location = new System.Drawing.Point(441, 88);
            this.tbArtist.Name = "tbArtist";
            this.tbArtist.Size = new System.Drawing.Size(172, 22);
            this.tbArtist.TabIndex = 28;
            // 
            // tbTrackTitle
            // 
            this.tbTrackTitle.Location = new System.Drawing.Point(441, 60);
            this.tbTrackTitle.Name = "tbTrackTitle";
            this.tbTrackTitle.Size = new System.Drawing.Size(172, 22);
            this.tbTrackTitle.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Genre:";
            // 
            // btnMakePlaylist
            // 
            this.btnMakePlaylist.Location = new System.Drawing.Point(367, 380);
            this.btnMakePlaylist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakePlaylist.Name = "btnMakePlaylist";
            this.btnMakePlaylist.Size = new System.Drawing.Size(268, 43);
            this.btnMakePlaylist.TabIndex = 25;
            this.btnMakePlaylist.Text = "Make Playlist From Files";
            this.btnMakePlaylist.UseVisualStyleBackColor = true;
            this.btnMakePlaylist.Click += new System.EventHandler(this.btnMakePlaylist_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(384, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Album:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Track Title:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Album Artist:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Artist:";
            // 
            // btnSaveTags
            // 
            this.btnSaveTags.Location = new System.Drawing.Point(367, 438);
            this.btnSaveTags.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveTags.Name = "btnSaveTags";
            this.btnSaveTags.Size = new System.Drawing.Size(268, 43);
            this.btnSaveTags.TabIndex = 19;
            this.btnSaveTags.Text = "Save Tags";
            this.btnSaveTags.UseVisualStyleBackColor = true;
            this.btnSaveTags.Click += new System.EventHandler(this.btnSaveTags_Click);
            // 
            // btnSelectTagFiles
            // 
            this.btnSelectTagFiles.Location = new System.Drawing.Point(13, 12);
            this.btnSelectTagFiles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelectTagFiles.Name = "btnSelectTagFiles";
            this.btnSelectTagFiles.Size = new System.Drawing.Size(268, 43);
            this.btnSelectTagFiles.TabIndex = 18;
            this.btnSelectTagFiles.Text = "Pick File(s)";
            this.btnSelectTagFiles.UseVisualStyleBackColor = true;
            this.btnSelectTagFiles.Click += new System.EventHandler(this.btnSelectTagFiles_Click);
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
            this.yt.ResumeLayout(false);
            this.yt.PerformLayout();
            this.vidconv.ResumeLayout(false);
            this.vidconv.PerformLayout();
            this.mp34tag.ResumeLayout(false);
            this.mp34tag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage yt;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar pbDownload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblVideoTitle;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage vidconv;
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
        private System.Windows.Forms.TabPage mp34tag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSaveTags;
        private System.Windows.Forms.Button btnSelectTagFiles;
        private System.Windows.Forms.TextBox tbGenre;
        private System.Windows.Forms.TextBox tbAlbum;
        private System.Windows.Forms.TextBox tbAlbumArtist;
        private System.Windows.Forms.TextBox tbArtist;
        private System.Windows.Forms.TextBox tbTrackTitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMakePlaylist;
        private System.Windows.Forms.ListBox lbTags;
    }
}

