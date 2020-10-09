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
using System.Net;
using System.Net.Mail;

namespace FaceDetectionAndRecognition
{
    public partial class findpersonPage : Form
    {

        string connectionString = @"Data Source= PRABU95;Initial Catalog=usersRegister;Integrated Security=True;";
        public findpersonPage()
        {
            InitializeComponent();
        }

        private void btn_display_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {

                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Addpersons", sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from tblPersondetails";
                sqlCmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
                dataGridView_details.DataSource = dt;
                sqlCon.Close();
            }



                 

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {

                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("Addpersons", sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from tblPersondetails where personid ='"+txtbox_search.Text+"'";
                sqlCmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlCmd);
                da.Fill(dt);
                dataGridView_details.DataSource = dt;
                sqlCon.Close();
            }

        }

        private void btn_email_Click(object sender, EventArgs e)
        {
            string to;

            to = (txtbox_email.Text).ToString();

            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress("prabuddhajayakodi@gmail.com");
            message.Body = "Hello, You have thrown garbage in to road today. you know you destroy our mother country. we hope that you never do that ";
            message.Subject = "You destroyed your mother country today";
            // SmtpClient stmp = new StmpClient("");
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("prabuddhajayakodi@gmail.com", "prabu@022");

            try
            {
                smtp.Send(message);
                MessageBox.Show("Email send successfully");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
