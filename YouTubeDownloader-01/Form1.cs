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
            Tuple<bool, string> isLinkGood = ValidateLink();
            if (isLinkGood.Item1)
            {
                RestrictAccessAbility();
                /*
                Pass the validated link into the download method
                so it can be assigned a property in the YouTube video or audio model object
                */
                MessageBox.Show("Is it a good link? " + isLinkGood.Item1 + " Link is: " + isLinkGood.Item2);
            }
        }

        private void RestrictAccessAbility() //Solution to Challenge (Correct)
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
