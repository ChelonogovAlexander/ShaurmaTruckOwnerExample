namespace ConsoleApplication1.V5
{
    /// <summary> Кассир Ирина </summary>
    public class IrinaCashier : ICashier
    {
        /// <summary> Получить деньги с клиента </summary>
        public void TakeMoney()
        {
            System.Console.WriteLine("Берем наличку");
            System.Console.WriteLine("Отдаем сдачу");
        }
    }
}