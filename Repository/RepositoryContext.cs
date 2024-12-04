using Microsoft.EntityFrameworkCore;
using WebApi.Entities.Models;

namespace WebApi.Repository;

public class RepositoryContext : DbContext
{
	public RepositoryContext(DbContextOptions options)
		: base(options)
	{
		
	}
	
	public DbSet<Company>? Companies { get; set; }
 	public DbSet<Employee>? Employees { get; set; }
}
