﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.Desktop.IntegrationApi.Interfaces;

namespace ViewParts.Sample
{
    [ViewPart(
        Id = "MyCustomViewPartContent", 
        Name = "My Custom ViewPart Content", 
        Description = "This is a sample of viewpart content.")]
    [ViewPartLayout(Dock = DockType.Fill, LocationByType = typeof(MyViewWithParts))]
    public class MyCustomViewPartContent: AbstractViewPartController
    {
        protected override IUIControl GetContentControl()
        {
            return _control.Value;
        }

        protected override void Initialize()
        {            
        }

        private readonly Lazy<MyCustomViewPartContentControl> _control = new Lazy<MyCustomViewPartContentControl>(() => new MyCustomViewPartContentControl());
    }
}
