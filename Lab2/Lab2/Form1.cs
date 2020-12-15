using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Создаем дерево (пустое)
            Tree tree = new Tree();

            //В зависимости от выбранного значения делаем разные действия
            switch(comboBox1.SelectedItem)
            {
                case "В глубину":
                    MessageBox.Show(tree.DoDepthAlgorithm(tree));
                    break;
                case "В ширину":
                    MessageBox.Show(tree.DoDepthAlgorithm(tree));
                    break;
                default:
                    MessageBox.Show("Выберите действие");
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            switch (comboBox2.SelectedItem)
            {
                case "Машина":
                    label2.Text = "Двигатель";
                    label3.Text = "Колеса";
                    break;
                case "Компьютер":
                    label2.Text = "RAM";
                    label3.Text = "Память";
                    break;
                case "Гитара":
                    label2.Text = "Струны";
                    label3.Text = "Материал";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fixer fixer = new Fixer();
            switch (comboBox2.SelectedItem)
            {
                case "Машина":
                    Car car = new Car();
                    car.Engine = textBox1.Text;
                    car.Wheels = textBox2.Text;
                    MessageBox.Show(fixer.DoForCar(car));
                    break;
                case "Компьютер":
                    Computer computer = new Computer();
                    computer.RAM = textBox1.Text;
                    computer.Memory = textBox2.Text;
                    MessageBox.Show(fixer.DoForComputer(computer));
                    break;
                case "Гитара":
                    Guitar guitar = new Guitar();
                    guitar.Strings = textBox1.Text;
                    guitar.Material = textBox2.Text;
                    MessageBox.Show(fixer.DoForGuitar(guitar));
                    break;
                default:
                    MessageBox.Show("Выберитие тип объекта");
                    break;
            }
        }
    }
}
