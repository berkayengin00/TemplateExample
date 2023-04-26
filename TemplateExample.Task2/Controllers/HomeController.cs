using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
using System.Web.Mvc;
using System.Web.Security;
using TemplateExample.Task2.DAL.Concrete;
using TemplateExample.Task2.Entity.Concrete.View;

namespace TemplateDeneme.UI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
			List<UserMenuByRole> userMenuByRoles = (Session["userInfo"] as List<UserMenuByRole>);

			ViewBag.Menus = userMenuByRoles;
			
			if (HttpContext.Cache["homePageContents"] == null)
			{
				List<HomePageAndContentVM> menuByRoles = new HomePageDal().GetAllHomePageContent();
				HttpContext.Cache.Insert("homePageContents", menuByRoles, null, DateTime.Now.AddDays(3), System.Web.Caching.Cache.NoSlidingExpiration);

			}

			return View(HttpContext.Cache["homePageContents"] as List<HomePageAndContentVM>);
        }

        public ActionResult Index2()
        {
            return View();
        }
    }
}