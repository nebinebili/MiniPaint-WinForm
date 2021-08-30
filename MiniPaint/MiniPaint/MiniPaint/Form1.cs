using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        public List<IFigure> Figures { get; set; } = new List<IFigure>();
        public IFactory FigureFactory { get; set; }
        public Color FigureColor { get; set; } = Color.Black;
        bool IsMouseDown = false;
        Point LocationXY;
        Point LocationX1Y1;
        System.Drawing.Rectangle rect;

        public interface IFigure
        {
            Point Point { get; set; }
            Size Size { get; set; }
            Color Color { get; set; }
            bool IsFill { get; set; }
        }
        class Circle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
            public bool IsFill { get; set; }
        }
        class Rectangle : IFigure
        {
            
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
            public bool IsFill { get; set; }
        }
        class Triangle : IFigure
        {
            public Point Point { get; set; }
            public Size Size { get; set; }
            public Color Color { get; set; }
            public bool IsFill { get; set; }
        }

        public interface IFactory 
        {
            IFigure GetFigure();
        }

        public class CircleFactory : IFactory
        {
            public IFigure GetFigure() => new Circle();
            
        }

        public class RectangleFactory : IFactory
        {
            public IFigure GetFigure() => new Rectangle();

        }

        public class TriangleFactory : IFactory
        {
            public IFigure GetFigure() => new Triangle();

        }

        public Form1()
        {
            InitializeComponent();
            string[] Figures = new string[3] 
            { 
                "Circle","Rectangle","Triangle"
            };
            comboBox1.Items.AddRange(Figures);
            comboBox1.SelectedIndex = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Rectangle")
            {
                FigureFactory = new RectangleFactory();
            }
            else  if (comboBox1.SelectedItem.ToString() == "Circle")
            {
                FigureFactory = new CircleFactory();
            }
            else if (comboBox1.SelectedItem.ToString() == "Triangle")
            {
                FigureFactory = new TriangleFactory();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            IFigure figure = FigureFactory.GetFigure();

            
            if (FigureFactory.GetFigure() is Circle circle)
            {
                circle.Color = FigureColor;
                circle.Size = new Size(int.Parse(txtBox_width.Text), int.Parse(txtBox_height.Text));
                circle.Point = e.Location;
                circle.IsFill = true;
                Figures.Add(circle);
            }
            else if (FigureFactory.GetFigure() is Triangle triangle)
            {
                triangle.Color = FigureColor;
                triangle.Size = new Size(int.Parse(txtBox_width.Text), int.Parse(txtBox_height.Text));
                triangle.Point = e.Location;
                triangle.IsFill = true;
                Figures.Add(triangle);
            }
            this.Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen1 = new Pen(FigureColor, 5);
            if (rect != null)
            {
                e.Graphics.DrawRectangle(pen1, GetRectangle());
            }

            using (var g = e.Graphics)
            {
                foreach (var item in Figures)
                {
                    Pen pen = new Pen(item.Color, 5);
                    SolidBrush brush = new SolidBrush(item.Color);
                    
                    if (item is Rectangle rect)
                    {
                        if (radiobtn_fill.Checked == true)
                        {
                            g.FillRectangle(brush, rect.Point.X, rect.Point.Y, rect.Size.Width, rect.Size.Height);
                        }
                        else if (radiobtn_outline.Checked == true)
                        {
                            g.DrawRectangle(pen, rect.Point.X, rect.Point.Y, rect.Size.Width, rect.Size.Height);
                        }
                    }
                    else if (item is Circle circle)
                    {
                        if (radiobtn_fill.Checked == true)
                        {
                            g.FillEllipse(brush, circle.Point.X, circle.Point.Y, circle.Size.Width, circle.Size.Height);
                        }
                        else if (radiobtn_outline.Checked == true)
                        {
                            g.DrawEllipse(pen, circle.Point.X, circle.Point.Y, circle.Size.Width, circle.Size.Height);
                        }
                    }
                    else if (item is Triangle trg)
                    {
                        var points = new Point[]
                            {
                                new Point(trg.Point.X, trg.Point.Y),
                                new Point(trg.Point.X - trg.Size.Width / 2, trg.Point.Y + trg.Size.Height),
                                new Point(trg.Point.X + trg.Size.Width / 2, trg.Point.Y + trg.Size.Height),
                            };
                        if (radiobtn_fill.Checked == true)
                        {
                            g.FillPolygon(brush, points);
                        }
                        else if (radiobtn_outline.Checked == true)
                        {
                            g.DrawPolygon(pen, points);
                        }
                    }
                }
                
            }
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                FigureColor = colorDialog1.Color;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(comboBox1.SelectedText== "Rectangle")
            {
                IsMouseDown = true;
                LocationXY = e.Location;
            }
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(comboBox1.SelectedText== "Rectangle")
            {
                if (IsMouseDown == true)
                {
                    LocationX1Y1 = e.Location;
                    Refresh();
                }
            }
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (comboBox1.SelectedText == "Rectangle")
            {
                if (IsMouseDown == true)
                {
                    LocationX1Y1 = e.Location;
                    IsMouseDown = false;
                }
            }
           
            
        }



        private System.Drawing.Rectangle GetRectangle()
        {
            rect = new System.Drawing.Rectangle();

            rect.X = Math.Min(LocationXY.X, LocationX1Y1.X);
            rect.Y = Math.Min(LocationXY.Y, LocationX1Y1.Y);
            rect.Width = Math.Abs(LocationXY.X - LocationX1Y1.X);
            rect.Height = Math.Abs(LocationXY.Y - LocationX1Y1.Y);

            
            return rect;
        }
    }
}
