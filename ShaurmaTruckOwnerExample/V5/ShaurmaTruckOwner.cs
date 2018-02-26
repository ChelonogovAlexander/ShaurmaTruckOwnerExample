namespace ConsoleApplication1.V5
{
    /// <summary> Владелец ларька с шаурмой </summary>
    public class ShaurmaTruckOwner
    {
        private readonly ICleaner _cleaner;
        private readonly ICooker _cooker;
        private readonly IDriver _driver;
        private readonly ICashier _cashier;

        /// <summary> Владелец ларька с шаурмой </summary>
        public ShaurmaTruckOwner(ICleaner cleaner, ICooker cooker, IDriver driver, ICashier cashier)
        {
            _cleaner = cleaner;
            _cooker = cooker;
            _driver = driver;
            _cashier = cashier;
        }

        /// <summary> Рабочий цикл </summary>
        public void WorkingCycle()
        {
            _cleaner.CleanCafe();
            _driver.GetProducts();

            _cooker.CookShaurma();
            _cashier.TakeMoney();

            _cooker.CookShaurma();
            _cashier.TakeMoney();

            _cooker.CookShaurma();
            _cashier.TakeMoney();

            _cooker.CookShaurma();
            _cashier.TakeMoney();

            _cooker.CookShaurma();
            _cashier.TakeMoney();

            _cleaner.CleanCafe();

            CountRevenue();
        }

        /// <summary> Посчитаем выручку </summary>
        private void CountRevenue()
        {
            System.Console.WriteLine("Считаем выручку");
        }
    }
}