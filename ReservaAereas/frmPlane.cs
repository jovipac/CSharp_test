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
    public partial class frmPlane : Form
    {

        SqlConnection con = new SqlConnection(Properties.Settings.Default.lConnection);
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //Id variable used in Updating and Deleting Record  
        int ID = 0;

        public frmPlane()
        {
            InitializeComponent();
            DisplayData();
        }

        private void ClearData()
        {
            txt_Name.Text = "";
            txt_Capacity.Text = "";
            txt_Id.Text = "0";
            cmb_AirlineId.Text = "";
            cmb_StatusId.Text = "";
            cmb_PlaneTypeId.Text = "";
        }

        private void DisplayData()
        {
            
            con.Open();
            
            try
            {
                DataTable dt = new DataTable();
                string statement = $"SELECT p.Id, p.Name,a.Name as Airline,Type_id,p.Capacity, s.Name as Status  FROM Plane p " +
                    $"INNER JOIN Airline a ON(P.Airline_id = a.Id)" +
                    $"INNER JOIN Status s ON(P.Status_id = s.Id)";
                SqlCommand cmd = new SqlCommand(statement, con);
                cmd.CommandType = CommandType.Text;

                adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);

                dataGridView.DataSource = dt;

                Plane _entity = new Plane();
                List<Plane> _planeList = new List<Plane>();

                if (dt.Rows.Count > 0)
                {
                    PlaneType planeTypes = new PlaneType();

                    foreach (DataRow lRow in dt.Rows)
                    {
                        _entity.Id = Convert.IsDBNull(lRow["Id"]) ? 0 : Convert.ToInt32(lRow["Id"]);
                        _entity.Capacity = Convert.IsDBNull(lRow["Capacity"]) ? string.Empty : lRow["Capacity"].ToString();
                        _entity.Status_id = Convert.IsDBNull(lRow["Status_id"]) ? -1 : Convert.ToInt32(lRow["Status_id"]);
                        _entity.Type_id = Convert.IsDBNull(lRow["Type_id"]) ? -1 : Convert.ToInt32(lRow["Type_id"]);
                        _planeList.Add(_entity);
                    }
                }

            }
                catch (Exception ex)
            {

            }
            con.Close();

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

        /// <summary>
        /// Accion boton insertar
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text != "" || txt_Capacity.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO Plane(Name,Capacity,Type_id,Airline_id,Status_id) VALUES(@name,@capacity,@type_id,@airline_id, @status_id)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@capacity", txt_Capacity.Text);
                    cmd.Parameters.AddWithValue("@type_id", cmb_PlaneTypeId.SelectedValue);
                    cmd.Parameters.AddWithValue("@airline_id", cmb_AirlineId.SelectedValue);
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
        /// Accion boton actualizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Int32.TryParse(txt_Id.Text, out ID);

            if (txt_Name.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("UPDATE Plane SET Name=@name,Capacity=@capacity,Type_id=@type_id,Airline_id=@airline_id,Status_id=@status_id WHERE Id=@id", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@id", ID);
                    cmd.Parameters.AddWithValue("@name", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@capacity", txt_Capacity.Text);
                    cmd.Parameters.AddWithValue("@type_id", cmb_PlaneTypeId.SelectedValue);
                    cmd.Parameters.AddWithValue("@airline_id", cmb_AirlineId.SelectedValue);
                    cmd.Parameters.AddWithValue("@status_id", cmb_StatusId.SelectedValue);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro actualizado exitosamente");
                    con.Close();
                    DisplayData();
                    ClearData();

                }
                catch (Exception er)
                {
                    MessageBox.Show("Error al intentar actualizar \n" + er.ToString() );
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
                cmd = new SqlCommand("DELETE Plane WHERE Id=@id", con);
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

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void cmb_StatusId_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var cn = new SqlConnection(Properties.Settings.Default.lConnection))
            {
                int categoryCode = ((int)(System.Convert.ChangeType(Properties.Settings.Default.PlaneStatusCode, typeof(int))));
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
                        MessageBox.Show("Se ha producido un error al acceder a sus datos. DETALLE: " + er.ToString());
                    }
                }
            }

            cmb_StatusId.DataSource = dt;
            cmb_StatusId.ValueMember = dt.Columns[0].ColumnName;
            cmb_StatusId.DisplayMember = dt.Columns[1].ColumnName;
        }

        private void cmb_AirlineId_DropDown(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (var cn = new SqlConnection(Properties.Settings.Default.lConnection))
            {
                string statement = $"SELECT Id, Name FROM Airline ";
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
                        MessageBox.Show("Se ha producido un error al acceder a sus datos. DETALLE: " + er.ToString());
                    }
                }
            }

            cmb_AirlineId.DataSource = dt;
            cmb_AirlineId.ValueMember = dt.Columns[0].ColumnName;
            cmb_AirlineId.DisplayMember = dt.Columns[1].ColumnName;
        }

        private void cmb_PlaneTypeId_DropDown(object sender, EventArgs e)
        {
            PlaneType planeTypes = new PlaneType();
            cmb_PlaneTypeId.DataSource = planeTypes.Examples();
            cmb_PlaneTypeId.ValueMember = "Id";
            cmb_PlaneTypeId.DisplayMember = "Name";
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
            cmb_AirlineId.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_PlaneTypeId.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Capacity.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmb_StatusId.Text = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
    }
}
