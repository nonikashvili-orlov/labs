using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Plane plane = new Plane();
            Random rnd = new Random();
            plane.MaxSpeed = rnd.Next(500, 750);
            plane.Weight = rnd.Next(500,900);
            richTextBox1.Text = "Создался самолет с максимальной скоростью - " + plane.MaxSpeed + "\nи весом - " + plane.Weight;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Car car = new Car();
            Random rnd = new Random();
            car.MaxSpeed = rnd.Next(100, 150);
            car.Weight = rnd.Next(100, 150);
            richTextBox1.Text = "Создалась машина с максимальной скоростью - " + car.MaxSpeed + "\nи весом - " + car.Weight;
        }
    }
}
