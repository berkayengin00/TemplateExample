using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TemplateExample.Task2.DAL.Context;
using TemplateExample.Task2.Entity.Concrete.View;

namespace TemplateExample.Task2.DAL.Concrete
{
	public class HomePageDal
	{
		public List<HomePageAndContentVM> GetAllHomePageContent()
		{
			List<HomePageAndContentVM> homePageAndContentVms = null;
			using (EfEducationContext db = new EfEducationContext())
			{
				homePageAndContentVms = (from hp in db.HomePages
					join hc in db.HomePageContentTypes on hp.HomePageContentTypeId equals hc.Id
					select new HomePageAndContentVM() { ContentName = hc.Name,ContentTitle = hp.Title,ContentDescription = hp.Content,ContentType = hc.Id}).ToList();
			}
			return homePageAndContentVms;
		}
	}
}
