using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Threading;

namespace InheritanceFigures
{
    
    abstract class Shape
    {   
        protected Bitmap buffer = null;
        abstract public string Name(); // geti oslun set olmasin adi type olaraq deyistir getType (enum olsun)
        public enum Types {
            Triangle,
            Circle,
            Rectangle,
            RightTriangle
        };
        int width;
        int height;
        public float X { get; set; }
        public float Y { get; set; }
        public int Width 
        {
            get { return Math.Abs(width); }
            set { width = value; }
        }
        public int Height 
        {
            get { return Math.Abs(height); }
            set { height = value; }
        }
        abstract public double Area();
        abstract public double Perimetr();
        
        public void ShowWidHei()
        {
            Console.WriteLine("Width and height are " + Width + " and " + Height);
        }
       
    }

    class Circle: Shape
    {
        public new Types GetType() 
        {
            return Types.Circle; 
        }
        string name = "Circle";
        public override string Name()
        {
            return name;
        }
        public double Radius { get; set; }
        public override double Perimetr()
        {
            double l = 2 * Math.PI * Radius;
            return l;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius; ;
        }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
    }

    class Rectangular: Shape
    {
        public Rectangular(Control canvasObject, int X, int Y, int Width, int Height)
        {
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;
            this.canvasObject = canvasObject;
            this.canvas = canvasObject.CreateGraphics();

            Draw();
        }
        
        Control canvasObject = null;    
        public new Types GetType() { return Types.Rectangle; }
        string name="Rectangular";
        Graphics canvas = null;
        Color color = Color.Red;
        Color canvasColor;
        public void SetCanvasColor(Color color)
        {
            canvasColor = color;
        }
        Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public override string Name()
        {
            return name;
        }

        public override double Area()
        {
            return Width * Height ;
        }
       
        public override double Perimetr()
        {
            double p = (2*Width + 2*Height );
            return p;
        }

        public double Dioqnal()
        {
            double d = Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));
            return d;
        }

        public double R()
        {
            double r = Dioqnal()/2;
            return r;
        }
        public void Clear()
        {
            Color buferColor = Color;
            Color = canvasObject.BackColor;
            Draw();
            Color = buferColor;
            
        }
        public void ClearNew()
        {
            canvas.Clear(Color.White);
        }
        

        public void Draw()
        { 
            Point basePoint = new Point((int)X,(int) Y);
            Size size = new Size(Width, Height);
            Rectangle First = new Rectangle(basePoint, size);
            
            buffer = new Bitmap(canvasObject.Width, canvasObject.Height);
            Graphics bufferCanvas = Graphics.FromImage(buffer);
            bufferCanvas.DrawRectangle(new Pen(Color, 5), First);
            canvas.DrawImage(buffer,new Point(100,100));
            
        }
        public void DrawNew()
        {
            canvas.DrawRectangle(new Pen(Color, 5),X,Y,Width,Height); 
        }
        public void Move(Point point,int steps)
        {
            float deltaX = (float)((point.X - X) / steps);  //deltaX,Y 0 dan boyuk olsun onun ucun alqoritm yaz
            float deltaY = (float)((point.Y - Y) / steps);
            Console.WriteLine(X + " " + Y);
            for (int i = 0; i < steps; i++)
            {
                //Clear();
                Clear();
                X = X + deltaX;
                Y = Y + deltaY;
                Draw();
                //DrawNew();
                Console.WriteLine(X + " " + Y);
                Pause();
            }
        }

        private static void Pause()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            Thread.Sleep(1);
            stopWatch.Stop();
        }

        
    }

    class Triangle : Shape
    {
        public new Types GetType() { return Types.Triangle; }
        string name = "Arbitrary Triangle ";
        double firstSide;
        double secondSide;
        double thirdSide;
        public override string Name()
        {
            return name ;
        }
        public override double Perimetr()
        {
            double p = (firstSide + secondSide + thirdSide);
            return p;
        }
        public override double Area() 
        {
            double p = (firstSide + secondSide + thirdSide) / 2;
            double area = Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide)); 
            return area;
        }
        public virtual double InsideOfRadius()
        {
            double r = (2 * Area()) / (firstSide + secondSide + thirdSide);
            return r;
        }
        public virtual double OutOfRadius()
        {
            double R = (firstSide + secondSide + thirdSide)/(4*Area());
            return R;
        }
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        public Triangle(double firstSide, double secondSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
        }
    }
    class RightTriangle: Triangle
    {
        public new Types GetType() { return Types.RightTriangle; }
        string name = " Right Triangle ";
        public double Hipotenusa
        {
            get { return Math.Sqrt((Width * Width) + (Height * Height)); }
            set { Hipotenusa = value; }
        }
        
        public RightTriangle(int firstSide, int secondSide) : base(firstSide, secondSide)
        {
            this.Width = firstSide;
            this.Height = secondSide;
        }

        public override string Name()
        {
            return name;
        }
        public override double Area()
        {
            return Width * Height / 2;
        }
       
        public override double Perimetr()
        {
            double p = (Width+Height+Hipotenusa);
            return p;
        }
        public override double InsideOfRadius()
        {
            double r = (Width + Height - Hipotenusa) / 2;
            return r;
        }
        public override double OutOfRadius()
        {
            double R = Hipotenusa/2;
            return R;
        }

    }

    class Program
    {
        
        static void Main(string[] args)
        {
            //Rectangular rec = new Rectangular(30,40,50,50);
            //Console.WriteLine("figure name: " + rec.Name());
            //Console.WriteLine("area: "+rec.Area());
            //Console.WriteLine("perimetr: "+rec.Perimetr());

            Circle circ = new Circle(20);
            circ.X = 50;
            circ.Y = 50;
            Console.WriteLine(circ.GetType());               //get type
            Console.WriteLine("figure name: " + circ.Name());
            Console.WriteLine("area: " + circ.Area());
            Console.WriteLine("perimetr: " + circ.Perimetr());

            Triangle arbTriangle = new Triangle(3,5,6);
            Console.WriteLine("figure name: " + arbTriangle.Name());
            Console.WriteLine("Area:" + arbTriangle.Area());
            Console.WriteLine("perimetr: " + arbTriangle.Perimetr());

            RightTriangle rightTriangle = new RightTriangle(3,4);   
            Console.WriteLine("figure name: " + rightTriangle.Name());
            Console.WriteLine("Area:" + rightTriangle.Area());
            Console.WriteLine("perimetr: " + rightTriangle.Perimetr());
            Console.WriteLine("Hipotenusa: "+ rightTriangle.Hipotenusa);

            //For Drawing
            Form ShapeGenerator = new Form();
            ShapeGenerator.WindowState = FormWindowState.Maximized;
            ShapeGenerator.Show();
            //Graphics canvas = ShapeGenerator.CreateGraphics();
            
            Rectangular rec = new Rectangular(ShapeGenerator, 30, 40, 50, 50);
            rec.Move(new Point(200, 500), 100);
            
            Console.ReadKey();
        }
    }
}