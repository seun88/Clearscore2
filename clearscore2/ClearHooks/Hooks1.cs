using Selenium2017Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace clearscore2.ClearHooks
{
    [Binding]
    public sealed class Hooks1
    {
       

        [BeforeScenario]
        public void BeforeScenario()
        {
            BaseClass.LaunchBrowser("Chrome");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            BaseClass.CloseBrowser();
        }
    }
}
