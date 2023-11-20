using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace facerecog22
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        FaceRec faceRec = new FaceRec();
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            faceRec.openCamera(pictureBox1, pictureBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            faceRec.Save_IMAGE(textBox1.Text);
            MessageBox.Show("SAVE SUCCESS");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            faceRec.isTrained = true;
        }
    }
}
