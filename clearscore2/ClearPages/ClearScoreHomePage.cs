using NUnit.Framework;
using OpenQA.Selenium;
using Selenium2017Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clearscore2.ClearPages
{
    public class ClearScoreHomePage :BaseClass 
    {
        private IWebElement logo;


        public void AndIAmOnClearscore()
        {
            logo = GetElementByCssSelector(".navbar-logos .logo.navbar-logo");
            Assert.True(logo.Displayed, "is not displayed");
        }
    }
}
