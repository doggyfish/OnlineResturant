using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineResturant.Controllers {
    public class DrawingController : Controller
    {
        public ActionResult Index(string dragposition)
        {
			ViewBag.Message = "Test Drag And Drop";

            ViewBag.Postions = string.IsNullOrEmpty(dragposition) ? Postions : dragposition;

			return View();
		}

        [HttpPost]
        public ActionResult SavePostion(string dragposition)
        {
            return RedirectToAction("Index", new {dragposition});
        }

	    private string _postions = "t,50px,200px;t,100px,200px;c, 198px,460px";
	    public string Postions
	    {
	        get { return _postions; }
	        set { _postions = value; }
	    }

	}
}