using FactoryDesignParrern.Models;
using FactoryDesignParrern.PL;

namespace FactoryDesignParrern.Factory.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeesFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeesManager Create()
        {
            ContractEmployeesManager manager = new ContractEmployeesManager();
            _emp.MedicalAllwance = manager.GetMedicalAllwance();
            return manager;
        }
    }
}
