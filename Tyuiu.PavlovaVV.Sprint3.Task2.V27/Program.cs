using Tyuiu.PavlovaVV.Sprint3.Task2.V27.Lib;
namespace Tyuiu.PavlovaVV.Sprint3.Task2.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 14;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSeries(value, startValue, stopValue);
            Console.WriteLine($"Ответ равен => {res}");
            Console.ReadKey();

        }
    }
}
