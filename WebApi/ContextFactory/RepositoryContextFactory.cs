using Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WebApi.ContextFactory;

public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
{
	public RepositoryContext CreateDbContext(string[] args)
	{
		var configuration = new ConfigurationBuilder()
			.SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json")
			.Build();
			
		var builder = new DbContextOptionsBuilder<RepositoryContext>()
			.UseSqlite(configuration.GetConnectionString("sqliteConnection"),
				b => b.MigrationsAssembly("WebApi"));
			
		return new RepositoryContext(builder.Options);
	}
}