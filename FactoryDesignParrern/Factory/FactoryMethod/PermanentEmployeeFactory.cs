using FactoryDesignParrern.Models;
using FactoryDesignParrern.PL;

namespace FactoryDesignParrern.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeesFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeesManager Create()
        {
            PermanentEmployeesManager manager = new PermanentEmployeesManager();
            _emp.HouseAllwance = manager.GetHouseAllwance();
            return manager;
        }
    }
}
