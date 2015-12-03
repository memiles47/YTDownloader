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
using YoutubeExtractor;

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
            // Our test youtube link
            string link = "https://www.youtube.com/watch?v=f7oiNiZd9_w";

            /*
             * Get the available video formats.
             * We'll work with them in the video and audio download examples.
             */
            IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link);

            /*
             * We want the first extractable video with the highest audio quality.
             */
            VideoInfo video = videoInfos
                .Where(info => info.CanExtractAudio)
                .OrderByDescending(info => info.AudioBitrate)
                .First();

            /*
             * If the video has a decrypted signature, decipher it
             */
            if (video.RequiresDecryption)
            {
                DownloadUrlResolver.DecryptDownloadUrl(video);
            }

            /*
             * Create the audio downloader.
             * The first argument is the video where the audio should be extracted from.
             * The second argument is the path to save the audio file.
             */
            var audioDownloader = new AudioDownloader(video, Path.Combine(tb_DownloadPath.Text, video.Title + video.AudioExtension));

            // Register the progress events. We treat the download progress as 85% of the progress and the extraction progress only as 15% of the progress,
            // because the download will take much longer than the audio extraction.
            //audioDownloader.DownloadProgressChanged += (sender, args) => Console.WriteLine(args.ProgressPercentage * 0.85);
            //audioDownloader.AudioExtractionProgressChanged += (sender, args) => Console.WriteLine(85 + args.ProgressPercentage * 0.15);

            /*
             * Execute the audio downloader.
             * For GUI applications note, that this method runs synchronously.
             */
            audioDownloader.Execute();

        }
    }
}
