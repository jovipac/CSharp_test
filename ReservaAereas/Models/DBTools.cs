using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ReservaAereas.Models
{
    class DBTools
    {
        SqlConnection dbConnection = new SqlConnection(Properties.Settings.Default.lConnection);

        public void FillDropDownList(string Query, ComboBox DropDownName)
        {
            SqlDataReader dr;
            try
            {
                dbConnection.Open();

                //Check whether the Drop Down has existing items. If YES, empty it.
                if (DropDownName.Items.Count > 0)
                    DropDownName.Items.Clear();

                SqlCommand cmd = new SqlCommand(Query, dbConnection);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                    DropDownName.Items.Add(dr[0].ToString());

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            dbConnection.Close();
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
                MessageBox.Show(ex.Message.ToString());
            }
            return result;
        }
    }
}
