using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheAmazingHumanCannonball
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] lines = new string[n];

            for (int i = 0; i < n; i++)
            {
                lines[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                string[] inputs = lines[i].Split(' ');

                double velocity = double.Parse(inputs[0], CultureInfo.InvariantCulture);
                double angle = double.Parse(inputs[1], CultureInfo.InvariantCulture) * Math.PI / 180;

                double time = double.Parse(inputs[2], CultureInfo.InvariantCulture) / (velocity * Math.Cos(angle));
                double height = (velocity * time * Math.Sin(angle)) - (0.5 * 9.81 * time * time);

                Console.WriteLine(((height > (double.Parse(inputs[3], CultureInfo.InvariantCulture) + 1) && height < (double.Parse(inputs[4], CultureInfo.InvariantCulture) - 1)) ? "Safe" : "Not safe"));
            }
            
        }
    }
}
