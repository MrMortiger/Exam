using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class RectangleSteel : PowerSteel
    {
        private int height;
        private int width;

        public RectangleSteel(int thickness, double density, int height, int width) : base(thickness, density)
        {
            this.height = height;
            this.width = width;
        }

        public override double Square()
        {
            return height * width;
        }
        public override double Weight()
        {
            return base.Weight();
        }
        public override string Information()
        {
            return "Прямокутний лист: Товщина - " + thickness + " густина:" + density;
        }
    }
}
