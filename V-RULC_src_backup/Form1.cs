using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
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
using IPacker;
namespace TEST
{
    public partial class Form1 : Form
    {
        public int dimX, dimY;
        public List<Rectangle> packages = new List<Rectangle>();
        int packagenumber;
        List<string> userAddress = new List<string>();
        public Item _item = new Item();

        // Declaring the variable for storing distance value
        double d;

        //Declaring the variable for storing the lat,long of location for conversion
        List<PointLatLng> points = new List<PointLatLng>();

        //Database Connection String
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Deakin\Sem3\ProjectDelivery\TVRULC_V1.01\TVRULC\custDB.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Deakin\Sem3\ProjectDelivery\TVRULC_V1.01\TVRULC\custDB.mdf;Integrated Security=True;Connect Timeout=30");
        
        public Form1()
        {
            InitializeComponent();
            populateGridEditCust();
            label4.Hide();
            packagingPanel.Hide();
        }

        
        private void Customerdetailsbtn_Click(object sender, EventArgs e)
        {
            Hometab.SelectedTab = CustomertabPage;
            tabLocation.Text = "Tab Location: Customer Details";
        }
        private void Packtruckbtn_Click(object sender, EventArgs e)
        {
            Hometab.SelectedTab = Packtab;
            tabLocation.Text = "Tab Location: Packaging & Truck Details";
        }
        private void GMapControl1_Load(object sender, EventArgs e)
        {

        }
        private void Routingbtn_Click(object sender, EventArgs e)
        {
            Hometab.SelectedTab = Routingtab;
            tabLocation.Text = "Tab Location: Routing";
            //Fixed Point (Warehouse location)
            getPoint("Deakin University, Burwood");
            //Variable Point (Customer Address)
            //getPoint("RMIT University, Melbourne");

            //getPoint("Monash University, Melbourne");
            foreach (var item in userAddress)
            {
                getPoint(item);
                Console.WriteLine("User Address " + item);
            }
            getPoint("Deakin University, Burwood");
            //getPoint(mapAdd);
            //load the map in map controller
            loadMap();


            for (int i = 0; i < points.Count; i++)
            {
                Console.WriteLine("my i is :" + points.Count);
                for (int j = points.Count-1 ; j > 0; j--)
                {
                    Console.WriteLine("my j is :" + j);
                    if (i + 1 <= points.Count - 1)
                    {
                        var route2 = GoogleMapProvider.Instance.GetRoute(points[i], points[i + 1], false, false, 14);
                        var r2 = new GMapRoute(route2.Points, "Route");
                        GMapOverlay over2 = new GMapOverlay("routes");
                        over2.Routes.Add(r2);
                        map.Overlays.Add(over2);
                        r2.Stroke = new Pen(Color.Blue, 3);
                        Console.WriteLine("Ok" + r2.Distance);
                        string duration = r2.Duration;
                    }
                }



                //===Showing Route===

                //if (i < points.Count)
                //{
                //    var route2 = GoogleMapProvider.Instance.GetRoute(points[0], points[points.Count - 1 - i], false, false, 14);
                //    var r2 = new GMapRoute(route2.Points, "Route");
                //    GMapOverlay over2 = new GMapOverlay("routes");
                //    over2.Routes.Add(r2);
                //    map.Overlays.Add(over2);
                //    r2.Stroke = new Pen(Color.Blue, 3);
                //    Console.WriteLine("Ok" + r2.Distance);
                //    string duration = r2.Duration;

                //}



            }

            
        }


        public void loadMap()
        {
            GMapProviders.GoogleMap.ApiKey = "AIzaSyC3EBCJ6VLEJ2wJ0oyLgpqvZGZXzUMeOjU";
            GMap.NET.GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.DragButton = MouseButtons.Left;

            map.MapProvider = GMapProviders.GoogleMap;
            //map.ShowCenter = false;
            //map.MinZoom = 10;
            map.MaxZoom = 24;
            map.Zoom = 14;
        }


        void getPoint(string address)
        {
            GeoCoderStatusCode statusCode = new GeoCoderStatusCode();

            var pointLatLng = map.GeocodingProvider.GetPoint(address, out statusCode);
            Console.WriteLine(statusCode);
            if (statusCode == GeoCoderStatusCode.OK)
            {
                addPoint(pointLatLng.Value.Lat, pointLatLng.Value.Lng);
                setPosition(pointLatLng.Value.Lat, pointLatLng.Value.Lng);
            }
        }

        void addPoint(double lat, double lng)
        {

            points.Add(new PointLatLng(lat, lng));
            GMapOverlay routes = new GMapOverlay("routes");
            GMapRoute route = new GMapRoute(points, "A walk in the park");
            //route.Stroke = new Pen(Color.Red, 3);
            //routes.Routes.Add(route);
            //map.Overlays.Add(routes);

            GMapOverlay markersOverlay = new GMapOverlay("markers");
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(lat, lng),
            GMarkerGoogleType.red_pushpin);
            markersOverlay.Markers.Add(marker);
            map.Overlays.Add(markersOverlay);
            d = route.Distance;

        }

        public void setPosition(double lat, double lng)
        {
            map.Position = new PointLatLng(lat, lng);
            //loadMap();

        }


        // Database Section
        void populateGridEditCust()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM [dbo].[CustTable]", sqlCon);
                DataTable dataTable1 = new DataTable();
                sqlDa.Fill(dataTable1);
                customerdataGridView.DataSource = dataTable1;
            }
        }




        //Closing the entire application on clicking 'X' button
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CustomerdataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (customerdataGridView.CurrentRow != null)
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    sqlCon.Open();

                    //Declaring an object of the Datagrid View
                    DataGridViewRow dgvRow = customerdataGridView.CurrentRow;
                    SqlCommand sqlCmd = new SqlCommand("CustAddOrEdit", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    //Insert Operation 
                    if (dgvRow.Cells["txtCustId"].Value == DBNull.Value)
                        sqlCmd.Parameters.AddWithValue("@CustId", 0);
                    else
                        sqlCmd.Parameters.AddWithValue("@CustId", Convert.ToInt32(dgvRow.Cells["txtCustId"].Value));
                    sqlCmd.Parameters.AddWithValue("@CustName", dgvRow.Cells["txtCustName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtCustName"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@EmailAdd", dgvRow.Cells["txtEmailAdd"].Value == DBNull.Value ? "" : dgvRow.Cells["txtEmailAdd"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@Address", dgvRow.Cells["txtAdd"].Value == DBNull.Value ? "" : dgvRow.Cells["txtAdd"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@NoOfPackages", Convert.ToInt32(dgvRow.Cells["txtNoOfPackages"].Value == DBNull.Value ? "0" : dgvRow.Cells["txtNoOfPackages"].Value.ToString()));
                    sqlCmd.Parameters.AddWithValue("@DeliveryDate", dgvRow.Cells["txtDeliveryDate"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDeliveryDate"].Value.ToString());
                    sqlCmd.Parameters.AddWithValue("@DueDate", dgvRow.Cells["txtDueDate"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDueDate"].Value.ToString());
                    sqlCmd.ExecuteNonQuery();
                    populateGridEditCust();
                }
            }
        }

        void FillDataGridViewName()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

            //Adapter for reading data from the database

            SqlDataAdapter sqlDa = new SqlDataAdapter("CustomerNameSearch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@CustName", searchByNameTxt.Text.Trim());

            //Creating a datatable to save result from database
            DataTable dtable1 = new DataTable();
            sqlDa.Fill(dtable1);

            //Populating the Datagrid with the Table of results found
            packtruckdataGridView.DataSource = dtable1;

            sqlCon.Close();
        }

        void CustTabDataGridViewFill()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

            //Adapter for reading data from the database

            SqlDataAdapter sqlDa = new SqlDataAdapter("CustTabSearch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@CustName", customernamesearchtxtbox.Text.Trim());

            //Creating a datatable to save result from database
            DataTable dt1 = new DataTable();
            sqlDa.Fill(dt1);

            //Populating the Datagrid with the Table of results found
            customerdataGridView.DataSource = dt1;

            sqlCon.Close();
        }

        private void SearchByName_Click(object sender, EventArgs e)
        {
            try
            {
                FillDataGridViewName();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }


        // Function to accept Customers Address into Routing Function
        private void CustomerdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customerdataGridView.CurrentRow.Index != -1)
            {
                userAddress.Add(customerdataGridView.CurrentRow.Cells[3].Value.ToString());
                
  
            }
        }

        private void Customernamesearchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                CustTabDataGridViewFill();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }

        private void PacktruckdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (packtruckdataGridView.CurrentRow.Index != -1)
            {

                //{

                //    packagenumber = Convert.ToInt32(customerdataGridView.CurrentRow.Cells[4].Value.ToString());
                //    label4.Text = (packagenumber.ToString() + " Packages");
                //    Console.WriteLine("Value is" + label4.Text);
                //    label4.Show();
                _item.width.Add(Convert.ToInt32(packtruckdataGridView.CurrentRow.Cells[0].Value.ToString()));
                _item.height.Add(Convert.ToInt32(packtruckdataGridView.CurrentRow.Cells[1].Value.ToString()));
                Console.WriteLine(_item.width.ElementAt<int>(0));
                //}
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                // Opening a stored procedure command instance

                SqlCommand sqlCmd = new SqlCommand("AddOrEdit", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                // Adding values from form into database

                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@PackId", "0");
                sqlCmd.Parameters.AddWithValue("@PackWidth", widthtxtvalue.Text.Trim());
                //_item.width.Add(Convert.ToInt32(widthtxtvalue.Text.Trim()));
                //Console.WriteLine(_item.width.ElementAt<int>(0));
                sqlCmd.Parameters.AddWithValue("@PackHeight", heighttxtvalue.Text.Trim());
                //_item.height.Add(Convert.ToInt32(heighttxtvalue.Text.Trim()));
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Success");
                
                

                packagingPanel.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }

            // Closing connection on completion

            finally
            {
                sqlCon.Close();
            }
        }

        private void PackagingPanel_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics l = e.Graphics;
            Graphics box = e.Graphics;
            Pen p = new Pen(Color.Blue, 4);
            Pen p2 = new Pen(Color.Black, 4);
            if (dimX != null && dimY != null)
            {
                l.DrawRectangle(p, 120, 80, dimX, dimY);
                //l.Dispose();
                //foreach(var item in boxX)
                //{
                //    box.DrawRectangle(p2, 550 + item, 150 + item , item, item);
                //}
                for (int i = 0; i < packages.Count; i++)
                {
                    Console.WriteLine("Testing packages" + packages[i].Width);
                    box.DrawRectangle(p2, 122 + packages[i].X, 82 + packages[i].Y, packages[i].Width, packages[i].Height);
                }
                //box.DrawRectangle(p2, 550, 150, 25, 25);
                box.Dispose();
            }
        }


    }
}

