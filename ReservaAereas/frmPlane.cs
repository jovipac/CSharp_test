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
        }

        private void ClearData()
        {
            txt_Name.Text = "";
            txt_Capacity.Text = "";
            txt_Id.Text = "0";
        }

        private void DisplayData()
        {
            
            con.Open();
            
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Plane", con);
                cmd.CommandType = CommandType.Text;

                adapt = new SqlDataAdapter(cmd);
                adapt.Fill(dt);

                dataGridView1.DataSource = dt;

                Plane _entity = new Plane();
                List<Plane> _planeList = new List<Plane>();

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow lRow in dt.Rows)
                    {
                        _entity.Id = Convert.IsDBNull(lRow["Id"]) ? 0 : Convert.ToInt32(lRow["Id"]);
                        _entity.Capacity = Convert.IsDBNull(lRow["Capacity"]) ? string.Empty : lRow["Capacity"].ToString();

                        _planeList.Add(_entity);
                    }
                }

            }
                catch (Exception ex)
            {

            }
            con.Close();

        }

        /// <summary>
        /// Accion boton insertar
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        private void buttonInsert_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Accion boton actualizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
