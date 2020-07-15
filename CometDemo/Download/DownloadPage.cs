using System;
using Comet;

namespace CometDemo.Download
{
    public class DownloadPage : View
    {
        [State]
        readonly DownloadState state = new DownloadState();

        public DownloadPage()
        {
        }

        [Body]
        View View() => new ScrollView
        {
            new VStack
            {
                new Image(state.FilePath),
                new Button("Download Image", async () => await state.DownloadImage()),
                new ProgressBar(() => state.Progress / 100.0f)
            }
        };
    }
}
