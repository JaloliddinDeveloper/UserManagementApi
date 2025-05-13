using Microsoft.AspNetCore.Mvc;

namespace UserManagementApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
       public ActionResult Get()=>
            Ok("Welcome to the User Management API.");
    }
}
