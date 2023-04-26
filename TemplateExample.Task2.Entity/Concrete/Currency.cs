using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TemplateExample.Task2.Entity.Concrete
{
	public class Currency:IEntity
	{
		public int Id { get; set; }
		public string CurrencyName { get; set; }
		public double CurrentValue { get; set; }

	}
}
