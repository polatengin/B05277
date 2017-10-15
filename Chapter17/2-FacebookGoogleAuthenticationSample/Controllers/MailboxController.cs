using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize]
public class MailboxController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}