using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace NhaThuocOnline.WebApp.Controllers
{
    public class ClientBaseController : Controller
    {
        protected string sessions
        {
            get
            {
                return HttpContext.Session.GetString("Token");
            }
        }
       
    }
}
