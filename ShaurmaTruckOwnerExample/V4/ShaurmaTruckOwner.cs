namespace ConsoleApplication1.V4
{
    /// <summary> Владелец ларька с шаурмой </summary>
    public class ShaurmaTruckOwner
    {
        private readonly ZinaidaCleaner _cleaner;
        private readonly AshotCooker _cooker;
        private readonly VasiliyDriver _driver;
        private readonly IrinaCashier _cashier;

        /// <summary> Владелец ларька с шаурмой </summary>
        public ShaurmaTruckOwner(ZinaidaCleaner cleaner, AshotCooker cooker, VasiliyDriver driver, IrinaCashier cashier)
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