using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FaceDetectionAndRecognition
{
    public partial class register : UserControl


    {

        string connectionString = @"Data Source= PRABU95;Initial Catalog=usersRegister;Integrated Security=True;";
        public register()
        {
            InitializeComponent();
        }

       

       

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (txtbox_username.Text == "" || txtbox_password.Text == "")
                MessageBox.Show("Please fill mandatory fields");
            else if (txtbox_password.Text != txtbox_confirmpw.Text)
                MessageBox.Show("Password do not match");
            else
            {

                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {

                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("userAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    //sqlCmd.Parameters.AddWithValue("@UserId", txtbox_id.Text);
                    sqlCmd.Parameters.AddWithValue("@firstName", txtbox_firstname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@lastName", txtbox_lastname.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@nic", txtbox_nic.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@phoneNo", txtbox_phone.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@email", txtbox_email.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@username", txtbox_username.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@password", txtbox_password.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is successfull");

                    Clear();

                    Form1 obj2 = new Form1();
                    obj2.Show();


                }

            }

        }

        void Clear()
        {
             txtbox_firstname.Text = txtbox_lastname.Text = txtbox_nic.Text = txtbox_phone.Text = txtbox_email.Text = txtbox_username.Text = txtbox_password.Text =txtbox_confirmpw.Text = "";
        }
    }
}
