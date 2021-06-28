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
    public partial class CircleForm : Form
    {
        Form main;
        public CircleForm()
        {
            InitializeComponent();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            main = this.Owner as Form1;
            if (Dia.Value < main.ClientSize.Width && Dia.Value < main.ClientSize.Height)
            {
                Circle.X = ((main.ClientSize.Width / 2) - ((int)Dia.Value / 2));
                Circle.Y = ((main.ClientSize.Height / 2) - ((int)Dia.Value / 2));
                Circle.Radius = (int)Dia.Value;
                MessageBox.Show($"Площадь данного круга: {Circle.Radius * Math.PI}");
                main.Invalidate();
                this.Close();
            }
            else
            {
                MessageBox.Show("Круг слишком большой и не помещается на форме\n либо увеличите форму либо уменьшите радиус","Нехватает места");
            }
            
        }
    }
}
