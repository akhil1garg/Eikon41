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
    public class QuoteApp : EikonCefWindow
    {
        public QuoteApp(Window window, EikonWebApp webApp)
            : base(window, webApp)
        { }

        public new QuoteAppWebApp App
        {
            get { return (QuoteAppWebApp)_webApp; }
        }
    }
}
