﻿using Microsoft.AspNetCore.Mvc;

namespace MilkyProject.WebUI.ViewComponents.LayoutViewComponents
{
    public class LayoutScriptsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
