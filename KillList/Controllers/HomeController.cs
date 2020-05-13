using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KillList.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CharecterServiceRefrence.CharecterServiceClient klient = new CharecterServiceRefrence.CharecterServiceClient();
            List<CharecterServiceRefrence.CharecterData> ListOfChar = klient.GetData().ToList();



            return View(ListOfChar);
        }
    }
}