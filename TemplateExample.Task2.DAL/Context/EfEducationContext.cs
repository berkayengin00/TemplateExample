using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TemplateExample.Task2.Entity.Concrete;

namespace TemplateExample.Task2.DAL.Context
{
	public class EfEducationContext:DbContext
	{
		public EfEducationContext():base("Server=.;Database=EducationDB;Trusted_Connection=true;")
		{

		}

		public DbSet<Currency> Currencies { get; set; }
		public DbSet<Menu> Menus { get; set; }
		public DbSet<MyUser> MyUsers { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<RoleAuthorization> RoleAuthorizations { get; set; }
		public DbSet<HomePage> HomePages { get; set; }
		public DbSet<HomePageContentType> HomePageContentTypes { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<RoleAuthorization>()
				.HasKey(x=> new {x.MenuId,x.RoleId});
		}
	}
}
