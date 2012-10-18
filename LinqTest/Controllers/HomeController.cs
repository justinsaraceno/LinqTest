using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinqTest.Controllers
{
    using LinqToExcel;

    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection formCollection)
        {
            var excel = new ExcelQueryFactory
            {
                FileName = Server.MapPath("~/App_Data/testExcel.xls")
            };

            return this.View();
        }
    }
}
