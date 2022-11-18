using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YES;


namespace Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data.p_B = 275.52;
            Data.p_S = 523.9;
            Data.p_F = 923.32;
            Data.G_F = 0.073;
            Data.m_s = 8.7;
            Data.k_fa = 0.00476;
            Data.Y_s = 0.0154;
            Data.x_k = 0.0346;
            Data.k_sa = 0.00111;
            Data.X_O = 0.335;

            Data.CountAnotherDatta();

            Calculator cal = new Calculator();
            cal.Calculation();
            SaveData save = new SaveData();
            save.WriteFileAsync();

            //foreach (var data in Data.All_Periods)
            //{
            //    Console.WriteLine($"time:{data.Key}  mass:{data.Value}");
            //}
        }
    }
}
