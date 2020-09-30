using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VideoMusicDownloader.Controller;
using VideoMusicDownloader.Properties;
using VideoMusicLibrary.Model;

namespace VideoMusicDownloader
{
    public partial class Form1 : Form
    {
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MP4Controller.running == true)
            {
                MP4Controller.Stop();
            }
            base.OnFormClosing(e);
        }

        #region YouTube Download

        private IList<VideoInfo> dict;
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            lblVideoTitle.Text = "Trying..";
            try
            {
                dict = await YouTubeController.LoadVideoAsync(tbLink.Text, NUMBER_OF_VIDEOS);
                if (dict.Count == 1)
                {
                    lblVideoTitle.Text = dict[0].VideoName;
                }
                else
                {
                    lblVideoTitle.Text = "Playlist Loaded";
                }
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
            foreach (var vi in dict)
            {
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), vi.VideoName) + ".mp4";
                pbDownload.Visible = true;
                pbDownload.Value = 0;
                lblProgress.Text = $"Downloading {vi.VideoName}...";
                await YouTubeController.DownloadAndSaveAsync(path, vi.VideoUri, progressDownload);
                lblProgress.Text = "Finished";

            }
            btnConvert.Visible = true;
        }

        private void Progress_ProgressChanged(object sender, int e)
        {
            pbDownload.Value = e;
            lblStatus.Text = $"Downloading, {e}% finished";
        }

        #endregion YouTube Download

        #region MP3 & MP4 Convert

        string fileNameConvert;
        private async void btnConvert_Click(object sender, EventArgs e)
        {
            if (tbMain.Text == string.Empty)
            {
                return;
            }
            lblStatus.Text = "Starting...";
            await MP4Controller.BreakDownFileAndSave(fileNameConvert, tbMain.Lines, cbVideo.Checked, cbMusic.Checked, cbDeleteOriginal.Checked, progressConvertAll);
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
                fileNameConvert = odf.FileName;
            }
            setLoaded();
        }

        private void setLoaded()
        {
            lblPickedFile.Text = fileNameConvert;
            btnConvert.Visible = true;
        }

        #endregion MP3 & MP4 Convert

        #region Tags Editor

        private BindingSource bsTagsList;
        private void btnSelectTagFiles_Click(object sender, EventArgs e)
        {
            var odf = new OpenFileDialog();
            odf.Multiselect = true;
            DialogResult res = odf.ShowDialog();
            if (res == DialogResult.OK)
            {
                var files = odf.FileNames;
                fillListView(files);
            }
        }

        private void fillListView(string[] files)
        {
            bsTagsList = new BindingSource();
            bsTagsList.DataSource = typeof(TagModel);

            foreach (var filePath in files)
            {
                TagModel tm = new TagModel(filePath);
                bsTagsList.Add(tm);
            }

            lbTags.DataSource = bsTagsList;
            lbTags.SelectedIndex = 0;
            FillData();
        }

        private void btnMakePlaylist_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveTags_Click(object sender, EventArgs e)
        {
            SaveData(lbTags.SelectedIndex);
        }

        private int selectedLbTags = 0;
        private int NUMBER_OF_VIDEOS;

        private void lbTags_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveData(selectedLbTags);
            selectedLbTags = lbTags.SelectedIndex;
            FillData();
        }

        private void SaveData(int selectedLbTags)
        {
            var tm = lbTags.Items[selectedLbTags] as TagModel;
            tm.TrackTitle = tbTrackTitle.Text;
            tm.Artist = tbArtist.Text;
            tm.Album = tbAlbum.Text;
            tm.AlbumArtist = tbAlbumArtist.Text;
            tm.Genre = tbGenre.Text;
            tm.Save();
        }

        private void FillData()
        {
            var tm = lbTags.SelectedItem as TagModel;
            tbTrackTitle.Text = tm.TrackTitle;
            tbArtist.Text = tm.Artist;
            tbAlbumArtist.Text = tm.AlbumArtist;
            tbAlbum.Text = tm.Album;
            tbGenre.Text = tm.Genre;
        }

        #endregion Tags Editor

    }
}
