using Tyuiu.PavlovaVV.Sprint3.Task6.V17.Lib;
namespace Tyuiu.PavlovaVV.Sprint3.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = 10;
            int stopValue = 20;

            Console.WriteLine("Начало отрезка = " + startValue);
            Console.WriteLine("Конец отрезка = " + stopValue);

            Console.WriteLine("********************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                               *");
            Console.WriteLine("********************************************************************************************");

            Console.WriteLine("Количество делителей = " + ds.GetSumTheDivisors(startValue, startValue));

            Console.ReadKey();
        }
    }
}
