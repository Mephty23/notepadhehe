using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace facerecog22
{
    public partial class Form3 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text;
            string lname = textBox2.Text;
            string username = textBox3.Text;
            string pass = textBox4.Text;

            db.db_save3(fname,lname,username,pass);
            MessageBox.Show("Successfully Added!", "Add");
        }
    }
}
