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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_YTDownloader));
            this.pic_TitleBox = new System.Windows.Forms.PictureBox();
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
            this.pic_PreviewBox = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_TitleBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PreviewBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_TitleBox
            // 
            this.pic_TitleBox.Image = ((System.Drawing.Image)(resources.GetObject("pic_TitleBox.Image")));
            this.pic_TitleBox.Location = new System.Drawing.Point(616, 15);
            this.pic_TitleBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_TitleBox.Name = "pic_TitleBox";
            this.pic_TitleBox.Size = new System.Drawing.Size(321, 204);
            this.pic_TitleBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_TitleBox.TabIndex = 0;
            this.pic_TitleBox.TabStop = false;
            // 
            // lbl_DecorateFolderBox
            // 
            this.lbl_DecorateFolderBox.AutoSize = true;
            this.lbl_DecorateFolderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DecorateFolderBox.Location = new System.Drawing.Point(21, 226);
            this.lbl_DecorateFolderBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DecorateFolderBox.Name = "lbl_DecorateFolderBox";
            this.lbl_DecorateFolderBox.Size = new System.Drawing.Size(150, 25);
            this.lbl_DecorateFolderBox.TabIndex = 1;
            this.lbl_DecorateFolderBox.Text = "Download Path:";
            // 
            // tb_DownloadPath
            // 
            this.tb_DownloadPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DownloadPath.Location = new System.Drawing.Point(232, 226);
            this.tb_DownloadPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_DownloadPath.Name = "tb_DownloadPath";
            this.tb_DownloadPath.Size = new System.Drawing.Size(899, 30);
            this.tb_DownloadPath.TabIndex = 2;
            // 
            // btn_Browse
            // 
            this.btn_Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.Location = new System.Drawing.Point(1140, 226);
            this.btn_Browse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(133, 39);
            this.btn_Browse.TabIndex = 3;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // chk_OpenAfterDL
            // 
            this.chk_OpenAfterDL.AutoSize = true;
            this.chk_OpenAfterDL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_OpenAfterDL.Location = new System.Drawing.Point(1281, 226);
            this.chk_OpenAfterDL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_OpenAfterDL.Name = "chk_OpenAfterDL";
            this.chk_OpenAfterDL.Size = new System.Drawing.Size(225, 29);
            this.chk_OpenAfterDL.TabIndex = 4;
            this.chk_OpenAfterDL.Text = "Open After Download";
            this.chk_OpenAfterDL.UseVisualStyleBackColor = true;
            // 
            // lbl_DecorateYouTubeURLBox
            // 
            this.lbl_DecorateYouTubeURLBox.AutoSize = true;
            this.lbl_DecorateYouTubeURLBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DecorateYouTubeURLBox.Location = new System.Drawing.Point(21, 311);
            this.lbl_DecorateYouTubeURLBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DecorateYouTubeURLBox.Name = "lbl_DecorateYouTubeURLBox";
            this.lbl_DecorateYouTubeURLBox.Size = new System.Drawing.Size(142, 25);
            this.lbl_DecorateYouTubeURLBox.TabIndex = 5;
            this.lbl_DecorateYouTubeURLBox.Text = "YouTube URL:";
            // 
            // tb_YouTubeURL
            // 
            this.tb_YouTubeURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_YouTubeURL.Location = new System.Drawing.Point(232, 311);
            this.tb_YouTubeURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_YouTubeURL.Name = "tb_YouTubeURL";
            this.tb_YouTubeURL.Size = new System.Drawing.Size(899, 30);
            this.tb_YouTubeURL.TabIndex = 6;
            // 
            // cmb_FileType
            // 
            this.cmb_FileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_FileType.FormattingEnabled = true;
            this.cmb_FileType.Items.AddRange(new object[] {
            "Video",
            "MP3"});
            this.cmb_FileType.Location = new System.Drawing.Point(1140, 311);
            this.cmb_FileType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_FileType.Name = "cmb_FileType";
            this.cmb_FileType.Size = new System.Drawing.Size(132, 33);
            this.cmb_FileType.TabIndex = 7;
            // 
            // btn_DownLoad
            // 
            this.btn_DownLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DownLoad.Location = new System.Drawing.Point(1281, 311);
            this.btn_DownLoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DownLoad.Name = "btn_DownLoad";
            this.btn_DownLoad.Size = new System.Drawing.Size(145, 39);
            this.btn_DownLoad.TabIndex = 8;
            this.btn_DownLoad.Text = "DownLoad";
            this.btn_DownLoad.UseVisualStyleBackColor = true;
            this.btn_DownLoad.Click += new System.EventHandler(this.btn_DownLoad_Click);
            // 
            // lbl_DecorateFileDownloading
            // 
            this.lbl_DecorateFileDownloading.AutoSize = true;
            this.lbl_DecorateFileDownloading.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DecorateFileDownloading.Location = new System.Drawing.Point(21, 409);
            this.lbl_DecorateFileDownloading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DecorateFileDownloading.Name = "lbl_DecorateFileDownloading";
            this.lbl_DecorateFileDownloading.Size = new System.Drawing.Size(167, 25);
            this.lbl_DecorateFileDownloading.TabIndex = 9;
            this.lbl_DecorateFileDownloading.Text = "File Downloading:";
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FileName.Location = new System.Drawing.Point(232, 409);
            this.lbl_FileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(0, 25);
            this.lbl_FileName.TabIndex = 10;
            // 
            // lbl_DecorateDownLoadProgress
            // 
            this.lbl_DecorateDownLoadProgress.AutoSize = true;
            this.lbl_DecorateDownLoadProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DecorateDownLoadProgress.Location = new System.Drawing.Point(21, 492);
            this.lbl_DecorateDownLoadProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DecorateDownLoadProgress.Name = "lbl_DecorateDownLoadProgress";
            this.lbl_DecorateDownLoadProgress.Size = new System.Drawing.Size(188, 25);
            this.lbl_DecorateDownLoadProgress.TabIndex = 11;
            this.lbl_DecorateDownLoadProgress.Text = "Download Progress:";
            // 
            // pg_Download
            // 
            this.pg_Download.Location = new System.Drawing.Point(232, 492);
            this.pg_Download.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pg_Download.Name = "pg_Download";
            this.pg_Download.Size = new System.Drawing.Size(900, 30);
            this.pg_Download.TabIndex = 12;
            // 
            // pic_PreviewBox
            // 
            this.pic_PreviewBox.Location = new System.Drawing.Point(1160, 395);
            this.pic_PreviewBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_PreviewBox.Name = "pic_PreviewBox";
            this.pic_PreviewBox.Size = new System.Drawing.Size(372, 210);
            this.pic_PreviewBox.TabIndex = 13;
            this.pic_PreviewBox.TabStop = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_YTDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1552, 620);
            this.Controls.Add(this.pic_PreviewBox);
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
            this.Controls.Add(this.pic_TitleBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_YTDownloader";
            this.Text = "YouTube Downloader 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_TitleBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PreviewBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_TitleBox;
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
        private System.Windows.Forms.PictureBox pic_PreviewBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer timer1;
    }
}

