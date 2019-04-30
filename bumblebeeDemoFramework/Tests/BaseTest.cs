using Bumblebee.Setup;
using Bumblebee.Setup.DriverEnvironments;
using bumblebeeDemoFramework.Pages;
using NUnit.Framework;

namespace bumblebeeDemoFramework.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected  Session Session { get; private set; }
        
        [SetUp]
        public void Setup()
        {
            Session = new Session<Chrome>();
            Session.NavigateTo<DuckDuckGoSearchPage>("https://duckduckgo.com/");
        }

        [TearDown]
        public void Teardown()
        {
            Session.End();
        }
    }
}