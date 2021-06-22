using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class PowerSteel
    {
        protected int thickness;
        protected double density;

        public abstract string Information();

        public abstract double Square();
        public virtual double Weight()
        {
            return Square() * thickness * density;
        }
        public PowerSteel(int thickness, double density)
        {
            this.thickness = thickness;
            this.density = density;
        }
    }
}
