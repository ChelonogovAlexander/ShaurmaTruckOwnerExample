namespace ShaurmaTruckOwnerExample.V5
{
    /// <summary> Владелец ларька с шаурмой </summary>
    public class ShaurmaTruckOwner2 : ICooker, IDriver, ICashier, ICleaner
    {
        private readonly ICleaner _cleaner;
        private readonly ICooker _cooker;
        private readonly IDriver _driver;
        private readonly ICashier _cashier;

        /// <summary> Владелец ларька с шаурмой </summary>
        public ShaurmaTruckOwner2(ICleaner cleaner, ICooker cooker, IDriver driver, ICashier cashier)
        {
            _cleaner = cleaner;
            _cooker = cooker;
            _driver = driver;
            _cashier = cashier;
        }

        /// <summary> Рабочий цикл </summary>
        public void WorkingCycle()
        {
            CleanCafe();
            GetProducts();

            CookShaurma();
            TakeMoney();

            CookShaurma();
            TakeMoney();

            CookShaurma();
            TakeMoney();

            CookShaurma();
            TakeMoney();

            CookShaurma();
            TakeMoney();

            CleanCafe();

            CountRevenue();
        }

        /// <summary> Посчитаем выручку </summary>
        private void CountRevenue()
        {
            System.Console.WriteLine("Считаем выручку");
        }

        /// <summary> Приготовить шаурму </summary>
        public void CookShaurma()
        {
            //Владелец делает шаурму так как умеет...
            //Мог раньше готовить сам, а сейчас только говорит повару сготовить её
            _cooker.CookShaurma();
        }

        public void GetProducts()
        {
            _driver.GetProducts();
        }

        public void TakeMoney()
        {
            _cashier.TakeMoney();
        }

        public void CleanCafe()
        {
            _cleaner.CleanCafe();
        }
    }
}