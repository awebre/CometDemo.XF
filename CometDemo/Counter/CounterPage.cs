using System;
using Comet;

namespace CometDemo.Counter
{
    public class CounterPage : View
    {
        [State]
        readonly CounterState state = new CounterState();

        [Body]
        View View() => new VStack
        {
            new Text(() => $"Value: {state.Count}")
                .Color(Color.Black)
                .FontSize(32),
            new HStack
            {
                new Button("Increment", () => state.Count++)
                    .Frame(width:160, height:44)
                    .Background(Color.Black)
                    .Color(Color.White)
                    .Padding(new Thickness(20, 5)),
                new Button("Decrement", () => state.Count--)
                    .Frame(160, height: 44)
                    .Background(Color.Black)
                    .Color(Color.White)
                    .Padding(new Thickness(5, 20, 20, 5)),
            },
            new Button("Reset", () =>
                {
                    state.Count = 0;
                    state.Step = 1;
                    state.IsTimerOn = false;
                })
                .Frame(330, height: 44)
                .Background(Color.Grey)
                .Color(Color.White)
                .Padding(new Thickness(20, 5, 20, 20)),
            new HStack
            {
                new Text("Timer"),
                new Toggle(state.IsTimerOn, (val) => state.IsTimerOn = val),
            },
            new HStack
            {
                new Button("+", () => state.Step++),
                new Text(() => $"Step: {state.Step}"),
                new Button("-", () => state.Step--),
            }
        };
    }
}
