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
        public decimal GetHouseAllwance()
        {
            return 150;
        }
    }
}
