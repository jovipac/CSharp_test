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
        }

        private void ClearData()
        {
            txt_Name.Text = "";
            txt_Description.Text = "";
            cmb_StatusId.Text = "";
            txt_Id.Text = "0";
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Runway", con);
            adapt.Fill(dt);
            dataGridView.DataSource = dt;
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
                try
                { 
                    cmd = new SqlCommand("INSERT INTO Runway(Name,Description,Status_id) VALUES(@name,@description, @status_id)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@description", txt_Description.Text);
                    cmd.Parameters.AddWithValue("@status_id", cmb_StatusId.SelectedValue);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Int32.TryParse(txt_Id.Text, out ID);
                    MessageBox.Show("Registro insertado con éxito");
                    DisplayData();
                    ClearData();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Error al intentar insertar \n" + er.ToString());
                    con.Close();
                }
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
            Int32.TryParse(txt_Id.Text, out ID);

            if (txt_Name.Text != "" && txt_Description.Text != "")
            {
                try
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
                catch (Exception er)
                {
                    MessageBox.Show("Error al intentar actualizar \n" + er.ToString());
                    con.Close();
                }

            }
            else
            {
                MessageBox.Show("Seleccione el registro para actualizar");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Int32.TryParse(txt_Id.Text, out ID);
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

            try
            {
                DisplayData();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void cmb_StatusId_DropDown(object sender, EventArgs e)
        {
            DBTools cmbTools = new DBTools();
            int categoryCode = ((int)(System.Convert.ChangeType(Properties.Settings.Default.RunwayStatusCode, typeof(int))));
            cmbTools.FillDropDownList( $"SELECT * FROM Status WHERE Category_id = {categoryCode}", cmb_StatusId );
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var rowsCount = dataGridView.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) return;

            var row = dataGridView.SelectedRows[0];
            if (row == null) return;

            ID = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_Id.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Name.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmb_StatusId.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Description.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
