using System.IO;
using System.Net;
using System.Threading.Tasks;
using Comet;

namespace CometDemo.Download
{
    public class DownloadState : BindingObject
    {
        public DownloadState()
        {
        }

        public int Progress
        {
            get => GetProperty<int>();
            set => SetProperty(value);
        }

        public bool Completed
        {
            get => GetProperty<bool>();
            set => SetProperty(value);
        }

        public string FilePath
        {
            get => GetProperty<string>();
            set => SetProperty(value);
        }

        public async Task DownloadImage()
        {
            Completed = false;
            using var client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadDataCompleted += Client_DownloadDataCompleted;
            var bytes = await client.DownloadDataTaskAsync("https://wallpapercave.com/wp/wp1848572.jpg");
            File.WriteAllBytes("downloaded_image.jpg", bytes);
            FilePath = "downloaded_image.jpg";
        }

        private void Client_DownloadDataCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Progress = 0;
            Completed = true;
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            Progress = e.ProgressPercentage;
        }
    }
}
