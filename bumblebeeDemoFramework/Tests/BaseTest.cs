using Bumblebee.Setup;
using Bumblebee.Setup.DriverEnvironments;
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
            Session = new Session<InternetExplorer>();    
        }

        [TearDown]
        public void Teardown()
        {
            Session.End();
        }
    }
}