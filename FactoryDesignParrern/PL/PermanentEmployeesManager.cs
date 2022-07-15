namespace FactoryDesignParrern.PL
{
    public class PermanentEmployeesManager : IEmployeesManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetHourlypay()
        {
            return 8;
        }
    }
}
