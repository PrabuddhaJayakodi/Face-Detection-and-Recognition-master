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
            dt.Columns.Add("address");
            dt.Columns.Add("contact");
            dt.Columns.Add("name");

            reportlist_gridview.DataSource = dt;


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
            

            for(int i=1; i<3;i++)
            {
                FirebaseResponse response = await client.GetTaskAsync("Cases/"+i);
                Data obj = response.ResultAs<Data>();

                DataRow row = dt.NewRow();

                row["address"] = obj.Address;
                row["contact"] = obj.Contact;
                row["name"] = obj.Name;

                dt.Rows.Add(row);


            }
            
                

            
        }

        private async void btn_retrive_Click(object sender, EventArgs e)
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

        }

        private async void btn_getlocation_Click(object sender, EventArgs e)
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
        }

        private void btn_find_Click(object sender, EventArgs e)
        {
            Form1 obj3 = new Form1();
            obj3.Show();
        }
    }
}
