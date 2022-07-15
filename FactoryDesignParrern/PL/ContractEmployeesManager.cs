namespace FactoryDesignParrern.PL
{
    public class ContractEmployeesManager : IEmployeesManager
    {
        public decimal GetBonus()
        {
            return 12;
        }

        public decimal GetHourlypay()
        {
            return 10;
        }
    }
}
