using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FaceDetectionAndRecognition
{
    public partial class addPersonsForm : Form
    {
        string connectionString = @"Data Source= PRABU95;Initial Catalog=usersRegister;Integrated Security=True;";
        public addPersonsForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {

                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Addpersons", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                //sqlCmd.Parameters.AddWithValue("@UserId", txtbox_id.Text);

                sqlCmd.Parameters.AddWithValue("@personid", nameTextBox.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@nic", txtbox_nic.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@surname", txtbox_surname.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@fullname", txtbox_fulname.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@address", txtbox_address.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@phoneno1", txtbox_phone1.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@phoneno2", txtbox_phone2.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@email", txtbox_email.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@vehicleno", txtbox_vehocleno.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@birthday", txtbox_bday.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@gender", txtbox_gender.Text.Trim());


                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Registration is successfull");

                Clear();

               


            }
        }
        void Clear()
        {
            nameTextBox.Text = txtbox_nic.Text = txtbox_nic.Text = txtbox_surname.Text = txtbox_email.Text = txtbox_fulname.Text = txtbox_address.Text = txtbox_phone1.Text = txtbox_phone2.Text = txtbox_email.Text = txtbox_vehocleno.Text = txtbox_bday.Text = txtbox_gender.Text = "";
        }
    }
}
