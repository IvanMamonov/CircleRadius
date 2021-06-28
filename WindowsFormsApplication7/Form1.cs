using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        CircleForm cf;
        public Form1()
        {
            InitializeComponent();
            Paint += new PaintEventHandler(Form1_Paint);
        }

        void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (Circle.Radius != 0)
            {
                e.Graphics.FillEllipse(Brushes.Yellow, Circle.X, Circle.Y, Circle.Radius * 2, Circle.Radius * 2);
            }
        }
    
        private void CircleFormButton_Click(object sender, EventArgs e)
        {
            cf = new CircleForm();
            cf.Owner = this;
            cf.ShowDialog();
        }
    }
}
