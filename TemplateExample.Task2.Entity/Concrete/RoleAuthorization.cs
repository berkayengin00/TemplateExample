using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateExample.Task2.Entity.Concrete
{
	public class RoleAuthorization
	{
		public int RoleId { get; set; }
		public int MenuId { get; set; }

		public Role Role { get; set; }
		public Menu Menu { get; set; }
	}
}
