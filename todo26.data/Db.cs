using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace todo26.data;

public class Db : DbContext
{

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		// var connString = Microsoft.Extensions.Configuration.JsonConfigurationExtensions...GetConnectionString("DefaultConnection"); 
		// var connectionString = ConfigurationProvider.GetDatabaseConnectionString("DefaultConnection");
		var connectionString = "Data Source=.;Initial Catalog=Checklist;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true";
		optionsBuilder.UseSqlServer(connectionString);
	}

	// public DbSet<Template> Templates { get; set; }
}