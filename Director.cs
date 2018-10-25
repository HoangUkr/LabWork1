using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_1_1
{
    class Director
    {
        Car_Builder builder;
        public Director(Car_Builder builder)
        {
            this.builder = builder;
        }

        internal Car_Builder Car_Builder
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        public void Construct()
        {
            builder.Build_Body();
            builder.Build_Wheel();
            builder.Paint_Colour();
        }
    }
}
