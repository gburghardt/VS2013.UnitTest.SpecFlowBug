using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace VS2013.UnitTest.SpecFlowBug
{
    [Binding]
    public sealed class Steps
    {
        [Given(@"everything is right with the world")]
        public void GivenEverythingIsRightWithTheWorld()
        {
        }

        [Then(@"true is true")]
        public void ThenTrueIsTrue()
        {
            Assert.IsTrue(true);
        }

        [Then(@"false is not true")]
        public void ThenFalseIsNotTrue()
        {
            Assert.IsFalse(false);
        }

        [Then(@"false is false")]
        public void ThenFalseIsFalse()
        {
            Assert.IsTrue(false == false);
        }
    }
}
