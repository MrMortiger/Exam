using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        public Form1()
        {
            PowerSteel[] steels = new PowerSteel[15] {
                new SquareSteel(rnd.Next(1,10),rnd.NextDouble(), rnd.Next(5,10)),
                new SquareSteel(rnd.Next(1,10),rnd.NextDouble(), rnd.Next(5,10)),
                new SquareSteel(rnd.Next(1,10),rnd.NextDouble(), rnd.Next(5,10)),
                new SquareSteel(rnd.Next(1,10),rnd.NextDouble(), rnd.Next(5,10)),
                new SquareSteel(rnd.Next(1,10),rnd.NextDouble(), rnd.Next(5,10)),

                new RectangleSteel(rnd.Next(1,10),rnd.NextDouble(), rnd.Next(5,10), rnd.Next(5,10)),
                new RectangleSteel(rnd.Next(1,10),rnd.NextDouble(), rnd.Next(5,10), rnd.Next(5,10)),
                new RectangleSteel(rnd.Next(1,10),rnd.NextDouble(), rnd.Next(5,10), rnd.Next(5,10)),
                new RectangleSteel(rnd.Next(1,10),rnd.NextDouble(), rnd.Next(5,10), rnd.Next(5,10)),
                new RectangleSteel(rnd.Next(1,10),rnd.NextDouble(), rnd.Next(5,10), rnd.Next(5,10)),
                new RectangleSteel(rnd.Next(1,10),rnd.NextDouble(), rnd.Next(5,10), rnd.Next(5,10)),
                new RectangleSteel(rnd.Next(1,10),rnd.NextDouble(), rnd.Next(5,10), rnd.Next(5,10)),

                new TriangleSteel(rnd.Next(1,10),rnd.NextDouble(), rnd.Next(5,10), rnd.Next(5,10)),
                new TriangleSteel(rnd.Next(1,10),rnd.NextDouble(), rnd.Next(5,10), rnd.Next(5,10)),
                new TriangleSteel(rnd.Next(1,10),rnd.NextDouble(), rnd.Next(5,10), rnd.Next(5,10)),


            };
            InitializeComponent();
            double sumSquare = 0;
            double sumWeight = 0;

            for (int i = 0; i < 15; i++)
            {
                richTextBox1.Text += steels[i].Information() + "\n";
                sumSquare += steels[i].Square();
                sumWeight += steels[i].Weight();

            }
            richTextBox1.Text += "\nСумарна площа: " + sumSquare + "\nСумарна вага: " + sumWeight;
        }
    }
}
