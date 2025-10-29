using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.PavlovaVV.Sprint3.Task6.V17.Lib
{
    public class DataService : ISprint3Task6V17
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int x;
            int count1 = 0;
            for (x = startValue; x <= stopValue; x++)
            {
                for (double d = 1.0; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        count1++;
                    }
                }
            }
            return count1;
        }
    }
}
