using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace Point_of_Sale
{
    public partial class client_pos : Form
    {
        public client_pos()
        {

           
            //tobi
            string connectionString = "Server=.;Database=PointOfSaleDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

            //kenji

            //string connectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=PointOfSaleDB;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            
            try
            {
                con.Open();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error executing SQL query: {ex.Message}");
            }


            InitializeComponent();

        }

    }
}
