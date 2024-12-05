using Contracts;

namespace Repository;

public class CompanyRepository : RepositoryBase<CompanyRepository>, ICompanyRepository
{
	public CompanyRepository(RepositoryContext repositoryContext)
		: base(repositoryContext)
	{
	}
}