using System;
using System.Timers;
using Comet;

namespace CometDemo.Counter
{
    public class CounterState : BindingObject
    {
        private readonly Timer timer;

        public CounterState()
        {
            timer = new Timer(1000);
            timer.Elapsed += TimerTick;
            Step = 1;
        }

        public int Count
        {
            get => GetProperty<int>();
            set => SetProperty(value);
        }

        public bool IsTimerOn
        {
            get => GetProperty<bool>();
            set
            {
                SetProperty(value);
                if (value)
                {
                    timer.Start();
                }
                else
                {
                    timer.Stop();
                }
            }
        }

        public int Step
        {
            get => GetProperty<int>();
            set => SetProperty(value);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            Count += Step;
        }
    }
}
