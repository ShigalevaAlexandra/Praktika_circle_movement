using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktika_circle_movement
{
    public partial class Circle_color : Form
    {
        public Circle_color()
        {
            InitializeComponent();
        }

        //смена цвета
        public Color New_circle_color
        {
            get
            {
                if (radioBtn_black.Checked) return Color.Black;
                if (radioBtn_yellow.Checked) return Color.Yellow;
                if (radioBtn_red.Checked) return Color.Red;
                if (radioBtn_green.Checked) return Color.Green;

                return Color.Blue;
            }
            set
            {
                if (value == Color.Black) radioBtn_black.Checked = true;
                if (value == Color.Yellow) radioBtn_yellow.Checked = true;
                if (value == Color.Red) radioBtn_red.Checked = true;
                if (value == Color.Green) radioBtn_green.Checked = true;
            }
        }
    }
}
