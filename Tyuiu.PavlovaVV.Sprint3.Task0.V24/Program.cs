using Tyuiu.PavlovaVV.Sprint3.Task0.V24.Lib;
namespace Tyuiu.PavlovaVV.Sprint3.Task0.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue = 1;
            int stopValue = 7;

            double result = ds.GetMultiplySeries(x, startValue, stopValue);

            Console.WriteLine($"Произведение ряда для X={x}, от {startValue} до {stopValue} равно: {result}");
            Console.WriteLine("************************************************************************");
            Console.ReadLine();
        }
    }
}
