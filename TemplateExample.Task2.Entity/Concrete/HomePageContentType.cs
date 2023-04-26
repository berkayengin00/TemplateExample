using System.Collections.Generic;

namespace TemplateExample.Task2.Entity.Concrete
{
	public class HomePageContentType : IEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public List<HomePage> HomePage { get; set; }
	}
}