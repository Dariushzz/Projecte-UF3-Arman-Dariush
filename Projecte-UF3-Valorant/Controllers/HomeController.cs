using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Projecte_UF3_Arman_Dariush.Models;

namespace mvc.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {

        const string apiUrl = "https://valorant-api.com/v1/agents?isPlayableCharacter=true&";

        var client = new HttpClient();
        var response = client.GetAsync(apiUrl).Result;
        var content = response.Content.ReadAsStringAsync().Result;

        var model = JsonConvert.DeserializeObject<Root>(content);
        return View(model);

    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Mapas()
    {
        const string apiUrl = "https://valorant-api.com/v1/maps";

        var client = new HttpClient();
        var response = client.GetAsync(apiUrl).Result;
        var content = response.Content.ReadAsStringAsync().Result;

        var model = JsonConvert.DeserializeObject<Root2>(content);
        return View(model);
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
