using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VideoMusicDownloader.Controller;
using VideoMusicDownloader.Properties;

namespace VideoMusicDownloader
{
    public partial class Form1 : Form
    {
        string vidName;
        Uri vidUri;

        string filename;
        readonly Progress<int> progressDownload;
        readonly Progress<string> progressConvertAll;
        
        public Form1()
        {
            InitializeComponent();
            progressDownload = new Progress<int>();
            progressConvertAll = new Progress<string>();
            progressDownload.ProgressChanged += Progress_ProgressChanged;
            progressConvertAll.ProgressChanged += ProgressConvertAll_ProgressChanged;
            Icon = new Icon("Resources/icon.ico");
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            lblVideoTitle.Text = "Trying..";
            try
            {
                var dict = await YouTubeController.LoadVideoAsync(tbLink.Text);
                vidName = dict.VideoName;
                lblVideoTitle.Text = vidName;
                vidUri = dict.VideoUri;
                pbDownload.Minimum = 0;
                pbDownload.Maximum = 100;
                btnDownload.Visible = true;
            } catch (Exception)
            {
                lblVideoTitle.Text = "Internet Not Available, try again later..";
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                FileName = vidName,
                DefaultExt = "mp4"
            };
            if ( sfd.ShowDialog() == DialogResult.OK)
            {
                pbDownload.Visible = true;
                pbDownload.Value = 0;
                lblProgress.Text = "Downloading...";
                await YouTubeController.DownloadAndSaveAsync(sfd.FileName, vidUri, progressDownload);
                lblProgress.Text = "Finished";
            }
            filename = sfd.FileName;
            btnConvert.Visible = true;
        }

        private void Progress_ProgressChanged(object sender, int e)
        {
            pbDownload.Value = e;
            lblStatus.Text = $"Downloading, {e}% finished";
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            if (tbMain.Text == string.Empty)
            {
                return;
            }
            lblStatus.Text = "Starting...";
            await MP4Controller.BreakDownFileAndSave(filename, tbMain.Lines, cbVideo.Checked, cbMusic.Checked, cbDeleteOriginal.Checked, progressConvertAll);
        }

        private void ProgressConvertAll_ProgressChanged(object sender, string e)
        {
            lblStat.Text = e;
        }

        private void btnPickFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog odf = new OpenFileDialog();
            DialogResult res = odf.ShowDialog();
            if (res == DialogResult.OK)
            {
                filename = odf.FileName;
            }
            setLoaded();
        }

        private void setLoaded()
        {
            lblPickedFile.Text = filename;
            btnConvert.Visible = true;
        }
    }
}
