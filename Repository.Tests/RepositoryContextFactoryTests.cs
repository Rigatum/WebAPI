using WebApi.Repository;

namespace Repository.Tests;

public class RepositoryContextFactoryTests
{
	[Fact]
	public void CreateDbContext_ValidConfiguration_ReturnDbContext()
	{
		var repositoryContext = new RepositoryContextFactory();
		
		var dbContext = repositoryContext.CreateDbContext(new string[] { });
		
		Assert.NotNull(dbContext);
	}
}