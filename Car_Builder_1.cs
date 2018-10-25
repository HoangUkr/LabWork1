using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_1_1
{
    class Car_Builder_1 : Car_Builder
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
            car.Add("Body Series #1745");
        }

        public override void Build_Wheel()
        {
            car.Add("Wheel Series #2245");
        }

        public override void Paint_Colour()
        {
            car.Add("Colour: Red");
        }

        public override Car Get_Result()
        {
            return car;
        }
    }
}
