﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;
using ThomsonReuters.Test.WhiteArk.Core.PageObjects;
using ThomsonReuters.Test.WhiteArk.Shared.PageObjects;

namespace ThomsonReuters.Test.WhiteArk.Apps.NA
{
    class TopNewsApp : EikonCefWindow
    {
        public TopNewsApp(Window window, EikonWebApp webApp)
            : base(window, webApp)
        { }

        public new TopNewsAppWebApp App
        {
            get { return (TopNewsAppWebApp)_webApp; }
        }  
    }
}
