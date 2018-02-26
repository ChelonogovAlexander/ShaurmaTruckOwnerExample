namespace ConsoleApplication1.V5
{
    /// <summary> Повар Ашот </summary>
    public class AshotCooker : ICooker
    {
        /// <summary> Приготовить шаурму </summary>
        public void CookShaurma()
        {
            System.Console.WriteLine("Поджарить курицу");
            System.Console.WriteLine("Нарезать овощи");
            System.Console.WriteLine("Смазать лаваш соусом");
            System.Console.WriteLine("Завернуть шаурму");
            System.Console.WriteLine("Налить кружку Жигулей по акции");
        }
    }
}