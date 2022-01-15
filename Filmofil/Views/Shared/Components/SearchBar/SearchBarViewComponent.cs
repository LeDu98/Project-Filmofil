using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmofil.Views.Shared.SearchBar
{
    public class SearchBarViewComponent:ViewComponent
    {
        public SearchBarViewComponent()
        { 
        
        }

        public IViewComponentResult Invoke(SPager SearchPager)
        {
            return View("Default", SearchPager);
        }
    }
}
