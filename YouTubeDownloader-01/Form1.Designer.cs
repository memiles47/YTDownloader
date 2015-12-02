namespace YouTubeDownloader_01
{
    partial class frm_YTDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_YTDownloader));
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lbl_DecorateFolderBox = new System.Windows.Forms.Label();
            this.tb_DownloadPath = new System.Windows.Forms.TextBox();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.chk_OpenAfterDL = new System.Windows.Forms.CheckBox();
            this.lbl_DecorateYouTubeURLBox = new System.Windows.Forms.Label();
            this.tb_YouTubeURL = new System.Windows.Forms.TextBox();
            this.cmb_FileType = new System.Windows.Forms.ComboBox();
            this.btn_DownLoad = new System.Windows.Forms.Button();
            this.lbl_DecorateFileDownloading = new System.Windows.Forms.Label();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.lbl_DecorateDownLoadProgress = new System.Windows.Forms.Label();
            this.pg_Download = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(483, 33);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(198, 142);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // lbl_DecorateFolderBox
            // 
            this.lbl_DecorateFolderBox.AutoSize = true;
            this.lbl_DecorateFolderBox.Location = new System.Drawing.Point(16, 193);
            this.lbl_DecorateFolderBox.Name = "lbl_DecorateFolderBox";
            this.lbl_DecorateFolderBox.Size = new System.Drawing.Size(121, 20);
            this.lbl_DecorateFolderBox.TabIndex = 1;
            this.lbl_DecorateFolderBox.Text = "Download Path:";
            // 
            // tb_DownloadPath
            // 
            this.tb_DownloadPath.Location = new System.Drawing.Point(174, 193);
            this.tb_DownloadPath.Name = "tb_DownloadPath";
            this.tb_DownloadPath.Size = new System.Drawing.Size(675, 26);
            this.tb_DownloadPath.TabIndex = 2;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(855, 193);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(100, 31);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            // 
            // chk_OpenAfterDL
            // 
            this.chk_OpenAfterDL.AutoSize = true;
            this.chk_OpenAfterDL.Location = new System.Drawing.Point(961, 193);
            this.chk_OpenAfterDL.Name = "chk_OpenAfterDL";
            this.chk_OpenAfterDL.Size = new System.Drawing.Size(188, 24);
            this.chk_OpenAfterDL.TabIndex = 4;
            this.chk_OpenAfterDL.Text = "Open After Download";
            this.chk_OpenAfterDL.UseVisualStyleBackColor = true;
            // 
            // lbl_DecorateYouTubeURLBox
            // 
            this.lbl_DecorateYouTubeURLBox.AutoSize = true;
            this.lbl_DecorateYouTubeURLBox.Location = new System.Drawing.Point(16, 261);
            this.lbl_DecorateYouTubeURLBox.Name = "lbl_DecorateYouTubeURLBox";
            this.lbl_DecorateYouTubeURLBox.Size = new System.Drawing.Size(115, 20);
            this.lbl_DecorateYouTubeURLBox.TabIndex = 5;
            this.lbl_DecorateYouTubeURLBox.Text = "YouTube URL:";
            // 
            // tb_YouTubeURL
            // 
            this.tb_YouTubeURL.Location = new System.Drawing.Point(174, 261);
            this.tb_YouTubeURL.Name = "tb_YouTubeURL";
            this.tb_YouTubeURL.Size = new System.Drawing.Size(675, 26);
            this.tb_YouTubeURL.TabIndex = 6;
            // 
            // cmb_FileType
            // 
            this.cmb_FileType.FormattingEnabled = true;
            this.cmb_FileType.Location = new System.Drawing.Point(855, 261);
            this.cmb_FileType.Name = "cmb_FileType";
            this.cmb_FileType.Size = new System.Drawing.Size(100, 28);
            this.cmb_FileType.TabIndex = 7;
            // 
            // btn_DownLoad
            // 
            this.btn_DownLoad.Location = new System.Drawing.Point(961, 261);
            this.btn_DownLoad.Name = "btn_DownLoad";
            this.btn_DownLoad.Size = new System.Drawing.Size(109, 31);
            this.btn_DownLoad.TabIndex = 8;
            this.btn_DownLoad.Text = "DownLoad";
            this.btn_DownLoad.UseVisualStyleBackColor = true;
            // 
            // lbl_DecorateFileDownloading
            // 
            this.lbl_DecorateFileDownloading.AutoSize = true;
            this.lbl_DecorateFileDownloading.Location = new System.Drawing.Point(16, 328);
            this.lbl_DecorateFileDownloading.Name = "lbl_DecorateFileDownloading";
            this.lbl_DecorateFileDownloading.Size = new System.Drawing.Size(134, 20);
            this.lbl_DecorateFileDownloading.TabIndex = 9;
            this.lbl_DecorateFileDownloading.Text = "File Downloading:";
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Location = new System.Drawing.Point(174, 328);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(51, 20);
            this.lbl_FileName.TabIndex = 10;
            this.lbl_FileName.Text = "label1";
            // 
            // lbl_DecorateDownLoadProgress
            // 
            this.lbl_DecorateDownLoadProgress.AutoSize = true;
            this.lbl_DecorateDownLoadProgress.Location = new System.Drawing.Point(16, 390);
            this.lbl_DecorateDownLoadProgress.Name = "lbl_DecorateDownLoadProgress";
            this.lbl_DecorateDownLoadProgress.Size = new System.Drawing.Size(151, 20);
            this.lbl_DecorateDownLoadProgress.TabIndex = 11;
            this.lbl_DecorateDownLoadProgress.Text = "Download Progress:";
            // 
            // pg_Download
            // 
            this.pg_Download.Location = new System.Drawing.Point(174, 390);
            this.pg_Download.Name = "pg_Download";
            this.pg_Download.Size = new System.Drawing.Size(675, 24);
            this.pg_Download.TabIndex = 12;
            // 
            // frm_YTDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 446);
            this.Controls.Add(this.pg_Download);
            this.Controls.Add(this.lbl_DecorateDownLoadProgress);
            this.Controls.Add(this.lbl_FileName);
            this.Controls.Add(this.lbl_DecorateFileDownloading);
            this.Controls.Add(this.btn_DownLoad);
            this.Controls.Add(this.cmb_FileType);
            this.Controls.Add(this.tb_YouTubeURL);
            this.Controls.Add(this.lbl_DecorateYouTubeURLBox);
            this.Controls.Add(this.chk_OpenAfterDL);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.tb_DownloadPath);
            this.Controls.Add(this.lbl_DecorateFolderBox);
            this.Controls.Add(this.picBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_YTDownloader";
            this.Text = "YouTube Downloader 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lbl_DecorateFolderBox;
        private System.Windows.Forms.TextBox tb_DownloadPath;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.CheckBox chk_OpenAfterDL;
        private System.Windows.Forms.Label lbl_DecorateYouTubeURLBox;
        private System.Windows.Forms.TextBox tb_YouTubeURL;
        private System.Windows.Forms.ComboBox cmb_FileType;
        private System.Windows.Forms.Button btn_DownLoad;
        private System.Windows.Forms.Label lbl_DecorateFileDownloading;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.Label lbl_DecorateDownLoadProgress;
        private System.Windows.Forms.ProgressBar pg_Download;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

