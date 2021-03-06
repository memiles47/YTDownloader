﻿using System;
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
using System.Net;

namespace YouTubeDownloader_01
{
    public partial class frm_YTDownloader : Form
    {
        /* This class is created when you select the form tool from the tool box. It is also the
        class where you place most of your code for execution
        */
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
                backgroundWorker1.RunWorkerAsync(isLinkGood.Item2);
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
                DownloadAudio(AudioDownloader);
            }
        }

        private void DownloadAudio(YouTubeAudioModel audioDownloader)
        {
            try
            {
                //Store VideoInfo object in model
                audioDownloader.VideoInfo = FileDownloader.GetVideoInfos(audioDownloader);

                //Stores VideoInfo object in model
                audioDownloader.Video = FileDownloader.GetVideoInfoAudioOnly(audioDownloader);

                //Update label within console
                UpdateLable(audioDownloader.Video.Title + audioDownloader.Video.AudioExtension);

                //Stores FilePath in model
                audioDownloader.FilePath = FileDownloader.GetPath(audioDownloader);
                audioDownloader.FilePath += audioDownloader.Video.VideoExtension;

                //Stores VideoDownloaderType object in model
                audioDownloader.AudioDownloaderType = FileDownloader.GetAudioDownloader(audioDownloader);

                //Stop time after download is complete
                audioDownloader.AudioDownloaderType.DownloadFinished += (sender, args) => timer1.Stop();

                //Enable controls once download is complete
                audioDownloader.AudioDownloaderType.DownloadFinished += (sender, args) => EnableAccessAbility();

                //Open folder with downloaded file selected
                audioDownloader.AudioDownloaderType.DownloadFinished += (sender, args) => OpenFolder(audioDownloader.FilePath);

                //Link progress bar up to download progress
                audioDownloader.AudioDownloaderType.DownloadProgressChanged += (sender, args) => pg_Download.Value = (int)args.ProgressPercentage;
                CheckForIllegalCrossThreadCalls = false;

                //Download Video
                FileDownloader.DownloadAudio(audioDownloader);
            }
            catch (Exception)
            {
                MessageBox.Show("Download cancelled");
                EnableAccessAbility();
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

                //Stop time after download is complete
                videoDownloader.VideoDownloaderType.DownloadFinished += (sender, args) => timer1.Stop();

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
            cmb_FileType.Enabled = true;
            pg_Download.Value = 0;
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            string link = e.Argument as string;
            string youtubeCode = link.Substring(link.Length - 11, 11);
            string imageLink1 = "http://img.youtube.com/vi/" + youtubeCode + "/1.jpg";
            string imageLink2 = "http://img.youtube.com/vi/" + youtubeCode + "/2.jpg";
            string imageLink3 = "http://img.youtube.com/vi/" + youtubeCode + "/3.jpg";
            using (var client = new WebClient())
            {
                client.DownloadFile(imageLink1, "1.jpg");
                client.DownloadFile(imageLink2, "2.jpg");
                client.DownloadFile(imageLink3, "3.jpg");
            }
            pic_PreviewBox.ImageLocation = "1.jpg";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timer1.Start();
            timer1.Interval = 500;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pic_PreviewBox == null)
            {
                pic_PreviewBox.ImageLocation = "1.jpg";
            }
            if (pic_PreviewBox.ImageLocation == "1.jpg")
            {
                pic_PreviewBox.ImageLocation = "2.jpg";
            }
            else if (pic_PreviewBox.ImageLocation == "2.jpg")
            {
                pic_PreviewBox.ImageLocation = "3.jpg";
            }
            else if (pic_PreviewBox.ImageLocation == "3.jpg")
            {
                pic_PreviewBox.ImageLocation = "1.jpg";
            }
        }
    }
}
