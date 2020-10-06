using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceDetectionAndRecognition.Connection;

namespace FaceDetectionAndRecognition
{
    public partial class loginpageForm : Form
    {
        public loginpageForm()
        {
            InitializeComponent();
        }

       

        private void loginpageForm_Load(object sender, EventArgs e)
        {
            txtbox_username.Select();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loadingpageForm obj = new loadingpageForm();
            obj.Show();
        }

       

        private void chkbox_showpw_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbox_showpw.Checked == true)
            {
                txtbox_password.UseSystemPasswordChar = false;

            }else
            {


               txtbox_password.UseSystemPasswordChar = true;
            }
        }

        

        private void btn_login_Click(object sender, EventArgs e)
        {
            if( !string.IsNullOrEmpty(txtbox_username.Text) && !string.IsNullOrEmpty(txtbox_password.Text))
            {
                string mySQL = string.Empty;

                mySQL += "SELECT * FROM tblUser ";
                mySQL += "WHERE username = '" + txtbox_username.Text + "' ";
                mySQL += "AND password = '" + txtbox_password.Text + "'  ";

                DataTable userData = serverConnection.executeSQL(mySQL);

                if(userData.Rows.Count > 0)
                {
                    txtbox_username.Clear();
                    txtbox_password.Clear();
                    chkbox_showpw.Checked = false;

                    this.Hide();

                    registerForm obj = new registerForm();
                    obj.ShowDialog();

                    obj = null;

                    this.Show();
                    this.txtbox_username.Select();
                    //


                }else
                {
                    MessageBox.Show("The username or password is incorrect. Try again.", "IFU login form", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtbox_username.Focus();
                    txtbox_username.SelectAll();

                }






            }else
            {

                MessageBox.Show("Please enter username and password","C# loginform:facedetection",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbox_username.Select();
            }
        }
    }
}
