using FactoryDesignParrern.Models;

namespace FactoryDesignParrern.Factory.FactoryMethod
{
    public class EmployeesManagerFactory
    {
        public BaseEmployeesFactory CreateFactory(Employee emp)
        {
            BaseEmployeesFactory employeesFactory = null;
            if (emp.EmployeeTypeId==1)
            {
                employeesFactory=new PermanentEmployeeFactory(emp);
            }
            else if (emp.EmployeeTypeId==2)
            {
                employeesFactory = new ContractEmployeeFactory(emp);
            }
            return employeesFactory;    
        }
    }
}
