using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using NLog;
using TemplateExample.Task2.DAL.Concrete;
using TemplateExample.Task2.Entity.Concrete.View;

namespace TemplateExample.Task2.Controllers
{
	public class LoginController : Controller
	{
		// GET: Login
		private static Logger logger = null;
		public ActionResult Index()
		{
			return View(new LoginVM());
		}

		[HttpPost, ValidateAntiForgeryToken]
		public ActionResult Index(LoginVM vm)
		{


			if (User.Identity.IsAuthenticated && Session["userInfo"] != null)
			{
				return RedirectToAction("Index", "Home");
			}

			var user = new UserDal().CheckUserAndGetMenuByRoles(vm);
			if (user.Count > 0)
			{
				Session.Add("userInfo", user);

				FormsAuthentication.SetAuthCookie(user[0].FirstName + user[0].LastName, true);
				return RedirectToAction("Index", "Home");
			}
			else
			{
				logger = NLog.LogManager.GetCurrentClassLogger();
				logger.Error("Hatalı Giriş");
			}

			return View("Index");

		}

		public ActionResult Logout()
		{
			FormsAuthentication.SignOut();
			return RedirectToAction("Index");
		}

	}
}