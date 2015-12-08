using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YouTubeDownloader;
using YoutubeExtractor;
using System.Diagnostics;

namespace YouTubeDownloader_01
{
    public partial class frm_YTDownloader : Form
    {
        public frm_YTDownloader()
        {
            InitializeComponent();
            cmb_FileType.SelectedIndex = 0; // Set "Video" as first choice

            // Gets path to "MyDocuments"
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Sets starting path in browser dialog box to folder
            folderBrowserDialog1.SelectedPath = folder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                tb_DownloadPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_DownLoad_Click(object sender, EventArgs e)
        {
            Tuple<bool, string> isLinkGood = ValidateLink();
            if (isLinkGood.Item1)
            {
                RestrictAccessAbility(); // Call to prevent controls from working during download

                Download(isLinkGood.Item2);
            }
        }

        private void Download(string validatedLink)
        {
            if (cmb_FileType.SelectedIndex == 0)
            {
                YouTubeVideoModel VideoDownloader = new YouTubeVideoModel();
                VideoDownloader.Link = validatedLink;
                VideoDownloader.FolderPath = tb_DownloadPath.Text;
                DownloadVideo(VideoDownloader);
            }
            else
            {
                YouTubeAudioModel AudioDownloader = new YouTubeAudioModel();
                AudioDownloader.Link = validatedLink;
                AudioDownloader.FolderPath = tb_DownloadPath.Text;
                //DownloadAudio(AudioDownloader);
            }
        }

        private void DownloadVideo(YouTubeVideoModel videoDownloader)
        {
            try
            {
                //Store VideoInfo object in model
                videoDownloader.VideoInfo = FileDownloader.GetVideoInfos(videoDownloader);

                //Stores VideoInfo object in model
                videoDownloader.Video = FileDownloader.GetVideoInfo(videoDownloader);

                //Update label within console
                UpdateLable(videoDownloader.Video.Title + videoDownloader.Video.VideoExtension);

                //Stores FilePath in model
                videoDownloader.FilePath = FileDownloader.GetPath(videoDownloader);
                videoDownloader.FilePath += videoDownloader.Video.VideoExtension;

                //Stores VideoDownloaderType object in model
                videoDownloader.VideoDownloaderType = FileDownloader.GetVideoDownloader(videoDownloader);

                //Enable controls once download is complete
                videoDownloader.VideoDownloaderType.DownloadFinished += (sender, args) => EnableAccessAbility();

                //Open folder with downloaded file selected
                videoDownloader.VideoDownloaderType.DownloadFinished += (sender, args) => OpenFolder(videoDownloader.FilePath);

                //Link progress bar up to download progress
                videoDownloader.VideoDownloaderType.DownloadProgressChanged += (sender, args) => pg_Download.Value = (int)args.ProgressPercentage;
                CheckForIllegalCrossThreadCalls = false;

                //Download Video
                FileDownloader.DownloadVideo(videoDownloader);
            }
            catch (Exception)
            {
                MessageBox.Show("Download cancelled");
                EnableAccessAbility();
            }
        }

        private void UpdateLable(string downloadFileName)
        {
            lbl_FileName.Text = downloadFileName;
        }

        private void OpenFolder(string filePath)
        {
            string argument = "/select, \"" + filePath + "\"";
            if (chk_OpenAfterDL.Checked)
            {
                Process.Start("explorer.exe", argument);
            }
        }

        private void EnableAccessAbility()
        {
            tb_DownloadPath.Text = "";
            tb_YouTubeURL.Text = "";
            tb_DownloadPath.Enabled = true;
            tb_YouTubeURL.Enabled = true;
            btn_Browse.Enabled = true;
            chk_OpenAfterDL.Enabled = true;
            btn_DownLoad.Enabled = true;
        }

        private void RestrictAccessAbility()
        {
            tb_DownloadPath.Enabled = false;
            tb_YouTubeURL.Enabled = false;
            btn_Browse.Enabled = false;
            chk_OpenAfterDL.Enabled = false;
            btn_DownLoad.Enabled = false;
            cmb_FileType.Enabled = false;
        }

        private Tuple<bool, string> ValidateLink()
        {
            string normalURL; //Normalized URL form YouTube
            if (!Directory.Exists(tb_DownloadPath.Text))
            {
                MessageBox.Show("Please enter a valid download path");
                return Tuple.Create(false, "");
            }
            else if (DownloadUrlResolver.TryNormalizeYoutubeUrl(tb_YouTubeURL.Text, out normalURL))
            {
                return Tuple.Create(true, normalURL); //Return true if the URL is valid along with the URL
            }
            else
	        {
                MessageBox.Show("Please enter a valid YouTube URL"); //Request a valid YouTube URL
                return Tuple.Create(false, ""); //Return false and an empty string
            }
        }
    }
}
