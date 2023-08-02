using Microsoft.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
// Written by: James Fehr
// Description: This program allows the user to enter a location and its coordinates into a database, and then export the data to a CSV file.
namespace MapData
{
    public partial class Form1 : Form
    {
        // Create a new SQL Connection object
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Stark\\Documents\\Documents\\GitHub\\VS Projects\\C#\\MapDatabase\\MapData\\MapData.mdf\";Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        void Form1_Load(object sender, EventArgs e)
        {   // Load the data from the database
            try
            {
                conn.Open();
                // Create a new SQL Command object to execute query
                SqlCommand cmd = new SqlCommand("SELECT * FROM Location", conn);
                // Create a new SQL Data Reader object to read data
                SqlDataReader dr = cmd.ExecuteReader();
                // Read the data and store them in the list box
                while (dr.Read())
                {
                    textBox1.Text = dr["Latitude"].ToString();
                    textBox2.Text = dr["Longitude"].ToString();
                    textBox3.Text = dr["Site"].ToString();
                    Output.Text = dr["Site, Latitude, Longitude"].ToString();
                }
                // Close the data reader object
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Output_Click(object sender, EventArgs e)
        {
            try
            {
                // set the path of the CSV file
                string csvFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "mapdata.csv");
                // create a new stream writer object
                using (StreamWriter writer = new StreamWriter(csvFilePath))
                {
                    // open the connection
                    conn.Open();
                    // create a new SQL Command object to execute query
                    SqlCommand cmd = new SqlCommand("SELECT Site, Latitude, Longitude FROM Location", conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    // write the column headers
                    writer.WriteLine("Site,Latitude,Longitude");
                    // read the data and write them to the CSV file
                    while (dr.Read())
                    {
                        writer.WriteLine($"{dr["Site"]},{dr["Latitude"]},{dr["Longitude"]}");
                    }
                    // close the data reader object
                    dr.Close();
                }
                // show a message box to confirm the file was created
                MessageBox.Show($"CSV file generated and saved at: {csvFilePath}");
            }
            catch (Exception ex)
            {
                // show a message box if an error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // close the connection
                conn.Close();
            }
        }



        void Load_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                // Create a new SQL Command object to execute query
                SqlCommand cmd = new SqlCommand("SELECT * FROM Location", conn);
                // Create a new SQL Data Reader object to read data
                SqlDataReader dr = cmd.ExecuteReader();
                // Read the data and store them in the list box
                OutputBox.Clear();  // Clear the list box
                while (dr.Read())
                {
                    textBox3.Text = dr["Site"].ToString();
                    textBox1.Text = dr["Latitude"].ToString();
                    textBox2.Text = dr["Longitude"].ToString();
                    OutputBox.Text += dr["Site"].ToString() + ": ";
                    OutputBox.Text += dr["Latitude"].ToString() + ", ";
                    OutputBox.Text += dr["Longitude"].ToString() + "\n";

                }
                // Close the data reader object
                dr.Close();
                // Close the connection
                conn.Close();

            }
            catch (Exception ex)
            {
                // Show a message box if an error occurs
                MessageBox.Show(ex.Message);
            }
        }

        void Coordinates_Click(object sender, EventArgs e)
        {
            // Check if the text boxes are empty
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "" && textBox3.Text.Trim() != "")
            {
                try
                {
                    // Open the connection
                    using (SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Stark\\Documents\\Documents\\GitHub\\VS Projects\\C#\\MapDatabase\\MapData\\MapData.mdf\";Integrated Security=True"))
                    {
                        conn.Open();
                        // Create a new SQL Command object to execute query
                        string query = "INSERT INTO Location (Site, Latitude, Longitude) VALUES (@Site, @Latitude, @Longitude)";
                        // Create a new SQL Command object to execute query
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Site", textBox3.Text);
                            cmd.Parameters.AddWithValue("@Latitude", textBox1.Text);
                            cmd.Parameters.AddWithValue("@Longitude", textBox2.Text);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Location added");

                            }
                            else
                            {
                                MessageBox.Show("Location not added");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
            conn.Close();
        }



    }
}
