using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_1_1
{
    class Car
    {
        List<object> components = new List<object>();

        public void Add(string component)
        {
            components.Add(component);
        }
        public void Show()
        {
            Console.WriteLine("Product component ---");
            foreach (string component in components)
                Console.WriteLine(component);
        }
    }
}
