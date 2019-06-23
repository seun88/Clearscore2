using clearscore2.ClearPages;
using Selenium2017Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace clearscore2.ClearSteps
{
    [Binding]
    public sealed class StepDefinition1
    {

        private ClearScoreHomePage homepage;

        [Given(@"I navigate to site")]
        public void GivenINavigateToSite()
        {
            homepage = BaseClass.GivenINavigatetoHomePage();
            homepage.AndIAmOnClearscore();
        }

    }
}
