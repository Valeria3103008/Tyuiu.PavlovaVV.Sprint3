using Tyuiu.PavlovaVV.Sprint3.Task3.V1.Lib;
namespace Tyuiu.PavlovaVV.Sprint3.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "have a nice time";
            char chr = 'a';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ = " + chr);







            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Количество символов = " + ds.GetCharCount(value, chr));

            Console.ReadKey();
        }
    }
}
