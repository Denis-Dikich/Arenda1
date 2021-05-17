using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arenda1
{
    public partial class Form2 : Form
    {

        Model3 db = new Model3();

        public static Form2 FORMA { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // закрываем форму входа Form2 
            Form1 f = new Form1();
            // сохраняем ссылку на текущую форму – Form1
            FORMA = this;
            // текущую форму прячем 
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" ||
             textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("Нужно задать все данные!");
                return;
            }

            MessageBox.Show("Вы успешно зарегистрированы!");
            // закрываем форму входа Form2
            Form1 f = new Form1();
            // сохраняем ссылку на текущую форму – Form1
            FORMA = this;
            // текущую форму прячем 
            this.Hide();
            f.Show();
        }
    }
}
