using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateExample.Task2.DAL.Context;
using TemplateExample.Task2.Entity.Concrete;
using TemplateExample.Task2.Entity.Concrete.View;

namespace TemplateExample.Task2.DAL.Concrete
{
	public class MenuDal
	{
		public List<MenuVM> GetMenusAccordingToRole(int roleId)
		{
			List<MenuVM> menulist = null;
			using (EfEducationContext db = new EfEducationContext())
			{
				menulist = (from menu in db.Menus
					join raut in db.RoleAuthorizations on menu.Id equals raut.MenuId
							 where raut.RoleId == roleId
							 select new MenuVM(){ Title = menu.Name,LinkAddress = menu.LinkAdress}).ToList();
			}

			return menulist;
		}


		public List<MenuVM> GetMenusAccorasdasddingToRole(int roleId)
		{
			List<MenuVM> menulist = null;
			using (EfEducationContext db = new EfEducationContext())
			{
				menulist = (from menu in db.Menus
					join raut in db.RoleAuthorizations on menu.Id equals raut.MenuId
					where raut.RoleId == roleId
					select new MenuVM() { Title = menu.Name, LinkAddress = menu.LinkAdress }).ToList();
			}

			return menulist;
		}
	}
}
