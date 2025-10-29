using Tyuiu.PavlovaVV.Sprint3.Task5.V20.Lib;
namespace Tyuiu.PavlovaVV.Sprint3.Task5.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 6;
            Console.WriteLine("Переменная Х = " + x);
            Console.WriteLine("Начало шага первого ряда = " + startValue1);
            Console.WriteLine("Конец шага  первого ряда = " + stopValue1);
            Console.WriteLine("Начало шага второго ряда = " + startValue2);
            Console.WriteLine("Конец шага  второго ряда = " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма равна : " + ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2));
            Console.ReadKey();
        }
    }
}
