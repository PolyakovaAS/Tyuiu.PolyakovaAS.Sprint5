using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PolyakovaAS.Sprint5.Task1.V2.Lib
{
    public class DataService : ISprint5Task1V2
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            double res;
            File.Delete("OutPutFileTask1.txt");
            string s = Path.Combine(new string[] { Path.GetTempPath(), "OutPutFileTask1.txt" });

            for (int i = startValue; i <= stopValue; i++)
            {

                if ((Math.Cos(i) - 2 * i) != 0)
                {
                    if (i != startValue)
                    {

                        if (i != stopValue)
                        {
                            res = Math.Round(((2 * i - 3) / (Math.Cos(i) - 2 * i) + 5 * i - 6), 2);
                            File.AppendAllText(s, Convert.ToString(res) + Environment.NewLine);
                        }
                        else
                        {
                            res = Math.Round(((2 * i - 3) / (Math.Cos(i) - 2 * i) + 5 * i - 6), 2);
                            File.AppendAllText(s, Convert.ToString(res));
                        }
                    }
                    else
                    {
                        if (i != stopValue)
                        {
                            res = Math.Round(((2 * i - 3) / (Math.Cos(i) - 2 * i) + 5 * i - 6), 2);
                            File.WriteAllText(s, Convert.ToString(res) + Environment.NewLine);
                        }
                        else
                        {
                            res = Math.Round(((2 * i - 3) / (Math.Cos(i) - 2 * i) + 5 * i - 6), 2);
                            File.WriteAllText(s, Convert.ToString(res));
                        }
                    }
                }
                else
                {
                    res = 0;
                    File.AppendAllText(s, Convert.ToString(res + Environment.NewLine));
                }
            }
            return s;
        }
    }
}
