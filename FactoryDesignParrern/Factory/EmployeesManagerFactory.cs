using FactoryDesignParrern.PL;

namespace FactoryDesignParrern.Factory
{
    public class EmployeesManagerFactory
    {
        public IEmployeesManager GetEmployeesManager(int employeesTypeId)
        {
            IEmployeesManager employeesManager = null;
            if (employeesTypeId == 1)
            {
                employeesManager = new PermanentEmployeesManager();
            }
            else if (employeesTypeId == 2)
            {
                employeesManager = new ContractEmployeesManager();
            }
            return employeesManager;
        }
    }
}
