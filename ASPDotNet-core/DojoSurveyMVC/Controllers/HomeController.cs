﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyMVC.Models;

namespace DojoSurveyMVC.Controllers;

public class HomeController : Controller
{

    static Survey MyInfo;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet("After")]
    public IActionResult After()
    {
        return View("After", MyInfo);
    }

    [HttpPost("submitted")]
    public IActionResult Submitted(Survey info)
    {   
        if(ModelState.IsValid)
        {
            MyInfo = info;
            return RedirectToAction("after");
        } else {
            return View("Index");
        }
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
