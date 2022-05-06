using Microsoft.AspNetCore.Mvc;

namespace app.Controllers;
public class HomeController : Controller
{
    public ViewResult Index(int? id)
    {
        return View(id);
    }
}
