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
    public class CompanyOverviewApp : EikonCefWindow
    {
        public CompanyOverviewApp(Window window, EikonWebApp webApp)
            : base(window, webApp)
        { }

        public new CompanyOverviewAppWebApp App
        {
            get { return (CompanyOverviewAppWebApp)_webApp; }
        }
    }
}
