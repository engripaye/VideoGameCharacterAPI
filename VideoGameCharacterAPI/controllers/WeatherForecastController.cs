using Microsoft.AspNetCore.Mvc;

namespace VideoGameCharacterAPI.controllers;

public class WeatherForecastController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}