using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_1_1
{
    class Car_Builder_3 : Car_Builder
    {

        internal Car Car
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        Car car = new Car();
    
        public override void Build_Body()
        {
            car.Add("Body Series #4557");
        }

        public override void Build_Wheel()
        {
            car.Add("Wheel Series #3789");
        }

        public override Car Get_Result()
        {
            return car;
        }

        public override void Paint_Colour()
        {
            car.Add("Colour: White");
        }
    }
}
