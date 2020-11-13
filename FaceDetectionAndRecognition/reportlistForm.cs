using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace FaceDetectionAndRecognition
{
    public partial class reportlistForm : Form
    {
        DataTable dt = new DataTable();

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "4i2jih1tzKkGxUYZZKpzt4P1MxreXpJ2UNmB8YkP",
         BasePath = "https://myapplication3-89c37.firebaseio.com/",
             



        };

        IFirebaseClient client;

        public reportlistForm()
        {
            InitializeComponent();
        }

        public void reportlistForm_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if(client!=null)
            {
                MessageBox.Show("connection is stablished");
            }

            // dt.Columns.Add("Latitude");
            // dt.Columns.Add("Longitude");
            dt.Columns.Add("Time");
            dt.Columns.Add("Case report");
            dt.Columns.Add("Vehicle no");
            dt.Columns.Add("Latitude");
            dt.Columns.Add("Longtude");
            dt.Columns.Add("Date");

            reportlist_gridview.DataSource = dt;

            

            //reportlist_gridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // frontend design
            
            reportlist_gridview.BorderStyle = BorderStyle.None;
             reportlist_gridview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
             reportlist_gridview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
             reportlist_gridview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
             reportlist_gridview.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
             reportlist_gridview.BackgroundColor = Color.White;

             reportlist_gridview.EnableHeadersVisualStyles = false;
             reportlist_gridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
             reportlist_gridview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
             reportlist_gridview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;


        }

        public void btn_refresh_Click(object sender, EventArgs e)
        {

            export();
            //client = new FireSharp.FirebaseClient(config);
            //DataTable dt = new DataTable();


            // dt.Columns.Add("Case Uploaded Time");
            // dt.Columns.Add("User ID");


            //reportlist_gridview.Rows.Clear();

            /*FirebaseResponse res1 = client.Get(@"Cases/");
            Cases rep = res1.ResultAs<Cases>();
            dt.Rows.Add(rep.address, rep.contact, rep.name);

            foreach (DataRow item in dt.Rows)
            {
                reportlist_gridview.Rows.Add(item.ItemArray);
            }*/
            


        }

        public async void export()
        {
            dt.Rows.Clear();
            int i = 39;
            //for(int i=15; i>13;i+=2)
            while (true)
            {

                if (i == 100)
                {
                    break;
                }

                i = i + 2;

                try
                {
                    FirebaseResponse response = await client.GetTaskAsync("uploadCases/" + i);
                    reportings obj = response.ResultAs<reportings>();

                    DataRow row = dt.NewRow();

                    row["Case report"] = obj.case_details;
                    row["Date"] = obj.current_date;
                    row["Time"] = obj.current_time;
                    row["Latitude"] = obj.latitude;
                    row["Longtude"] = obj.longitiude;
                    row["Vehicle no"] = obj.vehical_no;


                    dt.Rows.Add(row);



                }
                catch
                {

                }

            }   

            
        }

       /* private async void btn_retrive_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = txtbox_id.Text,
                Name = txtbox_name.Text,
                Address = txtbox_address.Text,
                Contact = txtbox_contact.Text


            };

            FirebaseResponse response = await client.GetTaskAsync("Cases/"+txtbox_id.Text);
            Data obj = response.ResultAs<Data>();

            txtbox_id.Text = obj.Id;
            txtbox_name.Text = obj.Name;
            txtbox_address.Text = obj.Address;
            txtbox_contact.Text = obj.Contact;

        }*/

       /* private async void btn_getlocation_Click(object sender, EventArgs e)
        {
            var data = new Location
            {
                ComplainID = txtbox_complainID.Text,
                Lat = txtbox_latitude.Text,
                Lon = txtbox_longitude.Text,

            };

            FirebaseResponse response2 = await client.GetTaskAsync("Case Locations/"+txtbox_complainID.Text+"l/");
            Location obj2 = response2.ResultAs<Location>();

            txtbox_complainID.Text = obj2.ComplainID;
            txtbox_latitude.Text = obj2.Lat;
            txtbox_longitude.Text = obj2.Lon;
        }*/

       private void btn_find_Click(object sender, EventArgs e)
        {
            Form1 obj3 = new Form1();
            obj3.Show();
        }

        private void reportlist_gridview_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            reportlist_gridview.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

       
    }
}
