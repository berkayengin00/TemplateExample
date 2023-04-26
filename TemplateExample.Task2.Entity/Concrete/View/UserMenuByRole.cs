using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateExample.Task2.Entity.Concrete.View
{
	public class UserMenuByRole
	{
		public int UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int RoleId { get; set; }
		public MenuVM MenuVm { get; set; }
	}
}
