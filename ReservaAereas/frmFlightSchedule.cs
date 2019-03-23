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
    public partial class frmFlightSchedule : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.lConnection);
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public frmFlightSchedule()
        {
            InitializeComponent();
            tabControl.TabPages[0].Text = "Inicio";
            tabControl.TabPages[1].Text = "Horario";
            tabControl.TabPages[2].Text = "Planificados";

            date_AdmissionTime.Format = DateTimePickerFormat.Custom;
            date_AdmissionTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            date_DepartureTime.Format = DateTimePickerFormat.Custom;
            date_DepartureTime.CustomFormat = "MM/dd/yyyy hh:mm:ss";

        }

        private void ClearData()
        {
            txt_Origin.Text = "";
            txt_Destination.Text = "";
            //txt_Id.Text = "0";
            cmb_AirlineId.Text = "";
            cmb_PlaneId.Text = "";
            //cmb_StatusId.Text = "";
        }

        private void buttonNext1_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPage2);
        }
        private void buttonNext2_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPage3);
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

        private void cmb_PlaneId_DropDown(object sender, EventArgs e)
        {
            if (cmb_AirlineId.SelectedValue != null)
            {
                DataTable dt = new DataTable();

                using (var cn = new SqlConnection(Properties.Settings.Default.lConnection))
                {
                    int AirlineId = -1;
                    Int32.TryParse(cmb_AirlineId.SelectedValue.ToString(), out AirlineId);
                    string statement = $"SELECT Id, Name FROM Plane WHERE Airline_Id={AirlineId} ";
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

                cmb_PlaneId.DataSource = dt;
                cmb_PlaneId.ValueMember = dt.Columns[0].ColumnName;
                cmb_PlaneId.DisplayMember = dt.Columns[1].ColumnName;
            }
            else
            {
                MessageBox.Show("¡Por favor seleccione la Aerolinea primero!");
            }
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (txt_Origin.Text != "" || txt_Destination.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO FlightSchedule(Date,Origin,Admission_time,Destination,Departure_time,Plane_id,Status_id) VALUES(@date,@origin,@admission_time,@destination,@departure_time,@plane_id, 1)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@date", date_calendar.SelectionStart);
                    cmd.Parameters.AddWithValue("@origin", txt_Origin.Text);
                    cmd.Parameters.AddWithValue("@destination", txt_Destination.Text);
                    cmd.Parameters.AddWithValue("@admission_time", date_AdmissionTime.Value);
                    cmd.Parameters.AddWithValue("@departure_time", date_DepartureTime.Value);
                    cmd.Parameters.AddWithValue("@plane_id", cmb_PlaneId.SelectedValue);
                    //cmd.Parameters.AddWithValue("@status_id", cmb_StatusId.SelectedValue);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    tabControl.SelectTab(tabPage1);
                    MessageBox.Show("Registro insertado con éxito");
                    //DisplayData();
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

    }
}
