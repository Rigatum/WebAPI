using Service.Contracts;

namespace Service;

public class ServiceManager : IServiceManager
{
	private readonly Lazy<ICompanyService> _companyService;
	private readonly Lazy<IEmployeeService> _employeeService;

	public ServiceManager(Lazy<IEmployeeService> employeeService, Lazy<ICompanyService> companyService)
	{
		_employeeService = employeeService;
		_companyService = companyService;
	}
	
	public ICompanyService CompanyService => _companyService.Value;
	public IEmployeeService EmployeeService => _employeeService.Value;
}