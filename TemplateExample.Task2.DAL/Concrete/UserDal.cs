using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateExample.Task2.DAL.Context;
using TemplateExample.Task2.Entity.Concrete.View;

namespace TemplateExample.Task2.DAL.Concrete
{
	public class UserDal
	{
		public List<UserMenuByRole> CheckUserAndGetMenuByRoles(LoginVM vm)
		{
			List<UserMenuByRole> menuByRoles = null;

			using (EfEducationContext db = new EfEducationContext())
			{
				
				menuByRoles = (from u in db.MyUsers
							where u.Email == vm.Email && u.Password == vm.Password
							join ra in db.RoleAuthorizations on u.RoleId equals ra.RoleId
							join menu in db.Menus on ra.MenuId equals menu.Id
							select new UserMenuByRole()
							{
								RoleId = u.RoleId,
								FirstName = u.UserName,
								LastName = u.LastName,
								UserId = u.Id,
								MenuVm = new MenuVM()
								{
									LinkAddress = menu.LinkAdress,
									Title = menu.Name
								}

							}).ToList();
				
			}

			return menuByRoles;
		}
	}
}
