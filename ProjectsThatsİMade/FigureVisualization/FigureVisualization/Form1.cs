using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigureVisualization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form ShapeGenerator = new Form();
            ShapeGenerator.WindowState = FormWindowState.Maximized;
            ShapeGenerator.Show();
            Graphics a = ShapeGenerator.CreateGraphics();
            Point yy = new Point(34, 56);
            Rectangle T = new Rectangle(yy, new Size(30, 55));
            a.DrawEllipse(new Pen(Color.Red, 3), 100, 100, 200, 400);
            Console.ReadKey();
        }
    }
}
