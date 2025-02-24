using Microsoft.EntityFrameworkCore;
using WinFormsApp2.DAL.Entities;

namespace WinFormsApp2.DAL.Database
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Employee> Employees { get; set; }
		public DbSet<UserPass> UserPasses { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=./SQLEXPRESS;Initial Catalog=Contact;Integrated Security=True;TrustServerCertificate=True");
		}
	}
}
