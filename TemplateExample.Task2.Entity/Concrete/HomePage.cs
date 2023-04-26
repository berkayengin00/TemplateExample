using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateExample.Task2.Entity.Concrete
{
	public class HomePage : IEntity
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
		public int HomePageContentTypeId { get; set; }

		public HomePageContentType HomePageContentType { get; set; }
	}
}
