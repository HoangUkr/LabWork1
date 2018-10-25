using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_1_1
{
    abstract class Car_Builder
    {

        public abstract void Build_Wheel();

        public abstract void Build_Body();

        public abstract void Paint_Colour();

        public abstract Car Get_Result();
    }
}
