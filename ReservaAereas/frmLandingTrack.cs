using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaAereas
{
    public partial class frmLandingTrack : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.lConnection);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;

        public frmLandingTrack()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            txt_Name.Text = "";
            txt_Description.Text = "";
            ID = 0;
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from LandingTrack", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        /// <summary>
        /// Looks up the users password crypto string in the database
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Description.Text != "")
            {
                cmd = new SqlCommand("insert into LandingTrack(Name,Description) values(@name,@description)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@description", txt_Description.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        /// <summary>
        /// Looks up the users password crypto string in the database
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Description.Text != "")
            {
                cmd = new SqlCommand("update LandingTrack set Name=@name,Description=@description where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@description", txt_Description.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete LandingTrack where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

    }
}
