using FactoryDesignParrern.Models;
using FactoryDesignParrern.PL;

namespace FactoryDesignParrern.Factory.FactoryMethod
{
    public abstract class BaseEmployeesFactory
    {
        protected Employee _emp;
        public BaseEmployeesFactory(Employee emp)
        {
            _emp = emp;
        }
        public Employee ApplySalary()
        {
            IEmployeesManager manager = this.Create();
            _emp.Hourlypay = manager.GetHourlypay();
            _emp.Bonus = manager.GetHourlypay();
            return _emp;
        }

        public abstract IEmployeesManager Create();
    }
}
