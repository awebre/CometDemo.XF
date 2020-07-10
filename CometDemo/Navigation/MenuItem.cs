﻿using System;
using Comet;

namespace CometDemo.Navigation
{
    public class MenuItem
    {
        public MenuItem()
        {

        }
        public MenuItem(string title, Func<View> page)
        {
            Title = title;
            Page = page;
        }
        public string Title { get; set; }
        public Func<View> Page { get; set; }

        public override string ToString() => Title;
    }
}
