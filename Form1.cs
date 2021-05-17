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
    public partial class Form1 : Form
    {

        public static Form1 FORMA { get; set; }

        Model3 db = new Model3();

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Нужно задать все данные!");
                return;
            }
            MessageBox.Show("Вы успешно вошли в систему!");
            // создаем форму регистрации Form3 
            Form3 f = new Form3();
            // сохраняем ссылку на текущую форму – Form1
            FORMA = this;
            // текущую форму прячем 
            this.Hide();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // создаем форму регистрации Form2 
            Form2 f = new Form2();
            // сохраняем ссылку на текущую форму – Form1
            FORMA = this;
            // текущую форму прячем 
            this.Hide();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
