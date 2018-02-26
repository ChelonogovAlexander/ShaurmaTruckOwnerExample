namespace ShaurmaTruckOwnerExample.V1
{
    /// <summary> Владелец ларька с шаурмой </summary>
    public class ShaurmaTruckOwner
    {
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

        /// <summary> Получить деньги с клиента </summary>
        private void TakeMoney()
        {
            System.Console.WriteLine("Берем наличку");
            System.Console.WriteLine("Отдаем сдачу");
        }

        /// <summary> Приготовить шаурму </summary>
        private void CookShaurma()
        {
            System.Console.WriteLine("Поджарить курицу");
            System.Console.WriteLine("Нарезать овощи");
            System.Console.WriteLine("Смазать лаваш соусом");
            System.Console.WriteLine("Завернуть шаурму");
            System.Console.WriteLine("Налить кружку Жигулей по акции");
        }

        /// <summary> Достать продукты </summary>
        private void GetProducts()
        {
            System.Console.WriteLine("Заправить машину");
            System.Console.WriteLine("Поехать на рынок");
            System.Console.WriteLine("Купить лавашей");
            System.Console.WriteLine("Купить помидоры");
            System.Console.WriteLine("Купить курицу");
            System.Console.WriteLine("Купить майонез");
            System.Console.WriteLine("Купить сметану");
            System.Console.WriteLine("Купить специи");
            System.Console.WriteLine("Купить масло подсолнечное");
            System.Console.WriteLine("Купить кофе, чай");
        }

        /// <summary> Уборка в кафе </summary>
        private void CleanCafe()
        {
            System.Console.WriteLine("Помыть посуду");
            System.Console.WriteLine("Достать швабру");
            System.Console.WriteLine("Достать ведро с водой");
            System.Console.WriteLine("Стереть грязь со столов");
            System.Console.WriteLine("Помыть полы");
        }
    }
}