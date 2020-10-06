using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceDetectionAndRecognition
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             register1.BringToFront();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 objform1 = new Form1();
            objform1.Show();
        }
    }
}
