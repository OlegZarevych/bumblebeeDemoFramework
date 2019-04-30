using System;
using Bumblebee.Implementation;
using Bumblebee.Interfaces;
using Bumblebee.Setup;

namespace bumblebeeDemoFramework.Pages
{
    public class DuckDuckGoSearchPage : Page
    {
        public DuckDuckGoSearchPage(Session session) : base(session)
        {
            
        }

        public SearchBlock SearchBlock
        {
            get { return new SearchBlock(this); }
        }
    }

    public class SearchBlock : Block
    {
        public SearchBlock(IBlock parent) : base(parent, By.Id("content_homepage"))
        {

        }

        public ITextField<SearchBlock> SearchField
        {
            get { return new TextField<SearchBlock>(this, By.Id("search_form_input_homepage")); }
        }

        public IClickable<SearchBlock> SearchButton
        {
            get { return new Clickable<SearchBlock>(this, By.Id("search_button_homepage")); }
        }
    }
}