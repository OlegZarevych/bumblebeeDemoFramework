using bumblebeeDemoFramework.Pages;
using Bumblebee.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;

namespace bumblebeeDemoFramework.Tests
{
    
    public class SearchTest : BaseTest
    {
        [Test]
        public void Search()
        {
            Session
                .NavigateTo<DuckDuckGoSearchPage>("https://duckduckgo.com/")
                .VerifyPresence(By.Id("search_form_input_homepage"));
        }
    }
}