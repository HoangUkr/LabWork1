using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student: Pham Xuan Hoang");
            Console.WriteLine("Group: IS-63");
            Console.WriteLine("Variant 5");
            Car_Builder builder = new Car_Builder_1();
            Director director = new Director(builder);
            director.Construct();
            Car car = builder.Get_Result();
            car.Show();
            Console.ReadKey();
        }
    }
}
