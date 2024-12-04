using Microsoft.EntityFrameworkCore;
using WebAPI.Entities.Models;

namespace Repository;
public class RepositoryContext : DbContext
{
	public RepositoryContext(DbContextOptions options)
		: base(options)
	{
		
	}
	
	public DbSet<Company>? Companies { get; set; }
 	public DbSet<Employee>? Employees { get; set; }
}
