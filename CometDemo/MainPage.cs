using System;
using System.Collections.Generic;
using Comet;
using CometDemo.Animation;
using CometDemo.Counter;
using CometDemo.Download;
using CometDemo.Navigation;

namespace CometDemo
{
    public class MainPage : View
    {
        List<MenuItem> pages = new List<MenuItem>
        {
            new MenuItem("Counter", () => new CounterPage()),
            new MenuItem("Animated Loading", () => new LoadingPage()),
            new MenuItem("Download Image", () => new DownloadPage())
        };

        [Body]
        View View() => new NavigationView {
            new ListView<MenuItem>(pages)
            {
                ViewFor = (page) => new HStack
                {
                    new Text(page.Title),
                    new Spacer(),
                }.Frame(height: 44).Margin(left: 10)
            }.OnSelectedNavigate((page) => page.View().Title(page.Title))
        };
    }
}
