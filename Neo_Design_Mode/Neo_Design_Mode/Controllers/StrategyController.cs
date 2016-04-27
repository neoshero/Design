using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Neo_Design_Mode.Controllers
{
    public class StrategyController : Controller
    {
        //
        // GET: /Strategy/

        public ActionResult Index()
        {
            return View();
        }

        #region 个人设计

        public ActionResult Strategy()
        {
            return View();
        }

        #endregion
    }
}
