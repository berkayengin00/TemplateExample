using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateExample.Task2.Entity.Concrete
{
	public class Menu:IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string LinkAdress { get; set; }

		public List<RoleAuthorization> RoleAuthorizations { get; set; }
	}
}
