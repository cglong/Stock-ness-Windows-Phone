using System.Web;
using System.Web.Http;

namespace Stockness.Web.Controllers
{
    public class LoginController : ApiController
    {
        // POST api/login
        public void Post([FromBody]string value)
        {
            HttpContext.Current.Response.Cookies.Add(new HttpCookie("session", "Test"));
        }
    }
}
