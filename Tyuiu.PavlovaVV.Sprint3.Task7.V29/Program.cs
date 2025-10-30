using Tyuiu.PavlovaVV.Sprint3.Task7.V29.Lib;
namespace Tyuiu.PavlovaVV.Sprint3.Task7.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = -5, b = 5;
            Console.WriteLine("Старт шага" + a);
            Console.WriteLine("Конец шага" + b);
            int l = ds.GetMassFunction(a, b).Length;
            double[] r;
            r = new double[l];
            r = ds.GetMassFunction(a, b);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |   f(x)    |");
            Console.WriteLine("+----------+-----------+");
            for (int i = 0; i <= l - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     |  {1, 6:f2}   |", a, r[i]);
                a++;
            }
            Console.WriteLine("+----------+-----------+");
            Console.ReadKey();
        }
    }
}
