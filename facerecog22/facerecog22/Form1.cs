using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facerecog22
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count =
            count = db.log_db(textBox1.Text,textBox2.Text).Count();
            if (count == 0)
            {
                MessageBox.Show("INVALID USERNAME AND PASSWORD");
            }
            else 
            {
                MessageBox.Show("Welcome user!");

                Form4 f4 = new Form4();
                f4.ShowDialog();
                this.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();  
            f2.ShowDialog();
        }
    }
}
