using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace todo26.data;

public class Db : DbContext
{

	public string ConnectionString { get; set; } = "Data Source=.;Initial Catalog=Checklist;Integrated Security=True;TrustServerCertificate=True;MultipleActiveResultSets=true";

	public string TestSql { get; set; } = "select top (1) [Name] + ' ' + [Value] as TestValue from dbo.Test";

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		// var connString = Microsoft.Extensions.Configuration.JsonConfigurationExtensions...GetConnectionString("DefaultConnection"); 
		// var connectionString = ConfigurationProvider.GetDatabaseConnectionString("DefaultConnection");
		optionsBuilder.UseSqlServer(ConnectionString);
	}

	public DbSet<Task> Tasks { get; set; }
}