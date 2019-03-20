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
using ReservaAereas.Models;

namespace ReservaAereas
{
    public partial class frmRunway : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.lConnection);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //Id variable used in Updating and Deleting Record  
        int ID = 0;

        public frmRunway()
        {
            InitializeComponent();
            DBTools cmbTools = new DBTools();
            int categoryCode = Properties.Settings.Default.TrackStatusCode;
            //cmbTools.FillDropDownList( $"SELECT * FROM Status WHERE Category_id = {categoryCode}",cmb_StatusId );
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
            adapt = new SqlDataAdapter("SELECT * FROM Runway", con);
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
                cmd = new SqlCommand("INSERT INTO Runway(Name,Description,Status_id) VALUES(@name,@description, @status_id)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@description", txt_Description.Text);
                cmd.Parameters.AddWithValue("@status_id", cmb_StatusId.SelectedIndex);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro insertado con éxito");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("¡Por favor proporcione detalles!");
            }
        }

        /// <summary>
        /// Looks up the users password crypto string in the database
        /// </summary>
        /// <returns></returns>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" && txt_Description.Text != "")
            {
                cmd = new SqlCommand("UPDATE Runway SET Name=@name,Description=@description,Status_id=@status_id WHERE Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                cmd.Parameters.AddWithValue("@description", txt_Description.Text);
                cmd.Parameters.AddWithValue("@status_id", cmb_StatusId.SelectedIndex);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registro actualizado exitosamente");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Seleccione el registro para actualizar");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("DELETE Runway WHERE Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registro eliminado con éxito!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un registro para eliminar");
            }
        }

        private void frmRunway_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'flujoaereoDataSet.Runway' Puede moverla o quitarla según sea necesario.
            this.runwayTableAdapter.Fill(this.flujoaereoDataSet.Runway);
            // TODO: esta línea de código carga datos en la tabla 'flujoaereoDataSet.Status' Puede moverla o quitarla según sea necesario.
            try
            {
                int categoryCode = ((int)(System.Convert.ChangeType(Properties.Settings.Default.TrackStatusCode, typeof(int))));
                this.statusTableAdapter.Fill(this.flujoaereoDataSet.Status);
                this.statusTableAdapter.FillBy(this.flujoaereoDataSet.Status, categoryCode );
                ClearData();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}
