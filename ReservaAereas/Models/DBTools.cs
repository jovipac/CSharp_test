using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ReservaAereas.Models
{
    class DBTools
    {
        SqlConnection dbConnection = new SqlConnection(Properties.Settings.Default.lConnection);

        public void FillDropDownList(string Query, System.Windows.Forms.ComboBox DropDownName)
        {
            DataTable dt = new DataTable();

            using (var cn = new SqlConnection(Properties.Settings.Default.lConnection))
            {
                using (var da = new SqlDataAdapter(Query, cn))
                {
                    cn.Open();

                    try
                    {
                        da.Fill(dt);
                    }
                    catch (SqlException er)
                    {
                        System.Windows.Forms.MessageBox.Show("There was an error accessing your data. DETAIL: " + er.ToString());
                    }
                }
            }

            DropDownName.DataSource = dt;
            DropDownName.ValueMember = dt.Columns[0].ColumnName;
            DropDownName.DisplayMember = dt.Columns[1].ColumnName;
        }

        public Object ReturnScalar(string Query)
        {
            object result = null;
            try
            {
                dbConnection.Open();
                SqlCommand cmd = new SqlCommand(Query, dbConnection);
                result = cmd.ExecuteScalar();
                dbConnection.Close();
                return result;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
            }
            return result;
        }
    }
}
