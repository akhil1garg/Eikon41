using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems.WindowItems;
using ThomsonReuters.Test.WhiteArk.Core.PageObjects;
using ThomsonReuters.Test.WhiteArk.Shared.PageObjects;


namespace ThomsonReuters.Test.WhiteArk.Apps.NA
{
    class NewsApp : EikonCefWindow
    {
        public NewsApp(Window window, EikonWebApp webApp)
            : base(window, webApp)
        { }

        public new NewsAppWebApp App
        {
            get { return (NewsAppWebApp)_webApp; }
        }
    }
}
