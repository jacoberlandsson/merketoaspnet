﻿using Microsoft.AspNetCore.Mvc;

namespace merketoaspnet.Controllers;

public class HomeController : Controller
{
    public async Task <IActionResult> Index()
    {
        return View();
    }
}
