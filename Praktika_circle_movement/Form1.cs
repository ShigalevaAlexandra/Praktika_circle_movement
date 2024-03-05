using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_circle_movement
{
    public partial class circle_movement : Form
    {
        GraphicsPath path;   //область для попадания точки
        Color my_color;

        public circle_movement()
        {
            InitializeComponent();

            path = new GraphicsPath();
            my_color = Color.Yellow;   //начальный цвет круга
        }

        //объявление переменных
        int x0,       //начальные координаты отрисовки круга 
            y0, 
            radius,   //размер круга
            xDir,          //координаты перемещения круга
            yDir;

        //Функция задания начальных значений переменных
        private void circle_movement_Load(object sender, EventArgs e)
        {
            x0 = 30;
            y0 = pictBox_circle.Height - 35;
            radius = 30;
            xDir = 1; 
            yDir = 1;
        }

        //Функция считывания новой скорости передвижения круга
        private void trackBar_speed_circle_Scroll(object sender, EventArgs e)
        {
            timer_circle.Interval = trackBar_speed_circle.Value;
        }

        //Функция запуска таймера движения круга
        private void btn_start_Click(object sender, EventArgs e)
        {
            timer_circle.Start();
        }

        //Функция остановки таймера движения круга
        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer_circle.Stop();
        }

        //Функция реализующая движение круга
        private void timer_circle_Tick(object sender, EventArgs e)
        {
            //обработка отскока круга от стенок PictureBox
            if (x0 - radius <= 0) xDir = 1;                        //правая граница
            if (x0 + radius >= pictBox_circle.Width) xDir = -1;    //левая граница
            if (y0 - radius <= 0) yDir = 1;                        //нижняя граница
            if (y0 + radius > pictBox_circle.Height) yDir = -1;    //верхняя граница
            x0 += xDir; y0 += yDir;
            pictBox_circle.Invalidate();
        }

        //Функция отрисовки круга и его движения
        private void pictBox_circle_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);

            //Создание кисти желтой штриховой
            HatchBrush brush = new HatchBrush(HatchStyle.SolidDiamond, my_color);

            //Круг
            g.FillEllipse(brush, x0 - radius, y0 - radius, 2 * radius, 2 * radius);
            path.Reset();
            path.StartFigure();   //формирование фигуры

            //добавление круга в фигуру
            path.AddEllipse(x0 - radius, y0 - radius, 2 * radius, 2 * radius);
            path.CloseFigure();   //закрытие фигуры
        }

        //Функция обработки события при нажаии левый клавиши мыши
        private void pictBox_circle_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pt = new Point(e.X, e.Y);   //получаем точку с координатами мыши

                //если эта точка внутри фигуры
                if (path.IsVisible(pt))
                {
                    Circle_color form = new Circle_color();
                    form.New_circle_color = my_color;

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        my_color = form.New_circle_color;
                        pictBox_circle.Invalidate();
                    }
                }
            }
        }
    }
}