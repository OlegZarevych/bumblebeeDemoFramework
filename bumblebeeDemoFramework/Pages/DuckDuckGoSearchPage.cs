using System;
using Bumblebee.Implementation;
using Bumblebee.Setup;

namespace bumblebeeDemoFramework.Pages
{
    public class DuckDuckGoSearchPage : Page
    {
        public DuckDuckGoSearchPage(Session session) : base(session)
        {
        }

        public DuckDuckGoSearchPage(Session session, TimeSpan timeout) : base(session, timeout)
        {
        }
    }
}