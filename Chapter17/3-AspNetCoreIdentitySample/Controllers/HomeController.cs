using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index() => View();

    [HttpGet]
    public IActionResult Login() => View();

    [HttpPost]
    public IActionResult Login(string username, string password, string rememberme)
    {
        return View();
    }

    [HttpGet]
    public IActionResult Register() => View();
}