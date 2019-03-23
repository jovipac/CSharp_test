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
    public partial class frmAirline : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.lConnection);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //Id variable used in Updating and Deleting Record  
        int ID = 0;

        public frmAirline()
        {
            InitializeComponent();
            int categoryCode = Properties.Settings.Default.StatusCode;
            DisplayData();
        }

        private void ClearData()
        {
            txt_Name.Text = "";
            txt_Id.Text = "0";
            if (cmb_StatusId.Items.Count > 0)
            {
                cmb_StatusId.Text = "";
            }
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("SELECT * FROM Airline", con);
            adapt.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" )
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Airline(Name,Status_id) VALUES(@name, @status_id)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);
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
                    MessageBox.Show("Error al intentar actualizar \n" + er.ToString());
                    con.Close();
                }
        }
            else
            {
                MessageBox.Show("¡Por favor proporcione detalles!");
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Int32.TryParse(txt_Id.Text, out ID);

            if (txt_Name.Text != "" )
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Airline SET Name=@name,Status_id=@status_id WHERE Id=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);
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
                cmd = new SqlCommand("DELETE Airline WHERE Id=@id", con);
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

        public void FillDropDownList(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            // Where possible, use the using block for data access. The 
            // using block handles disposal of resources and connection 
            // cleanup for you:
            using (var cn = new SqlConnection(Properties.Settings.Default.lConnection))
            {
                int categoryCode = ((int)(System.Convert.ChangeType(Properties.Settings.Default.StatusCode, typeof(int))));
                string statement = $"SELECT Id, Name FROM Status WHERE Category_id = {categoryCode}";
                using (var da = new SqlDataAdapter(statement, cn))
                {
                    cn.Open();

                    try
                    {
                        da.Fill(dt);
                    }
                    catch (SqlException er)
                    {
                        // Do some logging or something. 
                        MessageBox.Show("There was an error accessing your data. DETAIL: " + er.ToString());
                    }
                }
            }

            cmb_StatusId.DataSource = dt;
            cmb_StatusId.ValueMember = dt.Columns[0].ColumnName;
            cmb_StatusId.DisplayMember = dt.Columns[1].ColumnName;
        }

            private void frmAirline_Load(object sender, EventArgs e)
        {
            try
            {
                //ClearData();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}
