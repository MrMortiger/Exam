using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SquareSteel : PowerSteel
    {
        private int side;
        public SquareSteel(int thickness, double density, int side) : base(thickness, density)
        {
            this.side = side;
        }
        public override double Square()
        {
            return side * side;
        }
        public override double Weight()
        {
            return base.Weight();
        }
        public override string Information()
        {
            return "Квадратний лист: Товщина - " + thickness + " густина:" + density;
        }
    }
}
