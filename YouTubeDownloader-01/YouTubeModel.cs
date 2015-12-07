using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExtractor;

namespace YouTubeDownloader_01
{
    public class YouTubeModel
    {
        public IEnumerable<VideoInfo> VideoInfo { get; set; }
        public string FolderPath { get; set; } //Store the folder we designated in folder browsing
        public string Link { get; set; } //This is the YouTube Link(URL) we type or paste in
        public string FilePath { get; set; } //Store the folder location we set up earlier + file name + extension
        public VideoInfo Video { get; set; } //Object is from YouTube extractor and contains info about the files to be downloaded
    }

    public class YouTubeVideoModel: YouTubeModel
    {
        public VideoDownloader VideoDownloaderType { get; set; }
        /*
        This is the object that contains the execute method so we can download files
        Downloadfinished event; so we can handle when a download is finished
        we will use this to enable access to the interface after it is disabled while a file downloads
        DownloadProgressChange event; will update the progress bar as a video downloads
        */
    }

    public class YouTubeAudioModel: YouTubeModel
    {
        public AudioDownloader AudioDownloaderType { get; set; }
        /*
        This is the object that contains the execute download audio method
        DownloadFinished event: we will use this to enable access to the interface after it's disabled while a file downloads
        DownloadProgressChange event: we will use this to update the progress bar as a file is downloaded
        */
    }
}