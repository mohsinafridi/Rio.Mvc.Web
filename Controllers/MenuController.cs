using System.Web.Mvc;

namespace Rio.Mvc.Web.Controllers
{
    public class MenuController :  Sitecore.Mvc.Controllers.SitecoreController
    {
        // GET: Menu
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Menu()
        {
            return View();
        }
    }
}