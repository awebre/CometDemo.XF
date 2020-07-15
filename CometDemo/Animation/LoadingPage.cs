using System;
using Comet;

namespace CometDemo.Animation
{
    public class LoadingPage : View
    {
        [Body]
        View View() => new VStack
        {
            new Text("Loading...")
                .FillVertical()
                .TextAlignment(TextAlignment.Center)
                .BeginAnimationSequence(repeats: true)
                    .Animate(duration: 1, action: (text) => {
                        text.FontSize(12);
                        text.Background(Color.White);
                        text.Color(Color.Black);
                    }).Animate(duration: 1, action: (text) =>{
                        text.Background(Color.AliceBlue);
                    }).Animate(duration: 1, action: (text) => {
                        text.FontSize(24);
                        text.Background(Color.Beige);
                    }).Animate(duration: 1, action: (text)=>{
                        text.Background(Color.BlueViolet);
                        text.Color(Color.White);
                    }).Animate(duration: 1, action: (text)=>{
                        text.FontSize(12);
                        text.Background(Color.RoyalBlue);
                    }).Animate(duration: 1, action: (text)=>{
                        text.Background(Color.Fuchsia);
                }).EndAnimationSequence(),
        }.FillVertical();
    }
}
