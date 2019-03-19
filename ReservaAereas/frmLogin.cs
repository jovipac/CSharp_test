using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ReservaAereas
{
    public partial class frmLogin : Form
    {
        /// <summary>
        /// Key for the crypto provider
        /// </summary>
        private static readonly byte[] _key = { 0xA1, 0xF1, 0xA6, 0xBB, 0xA2, 0x5A, 0x37, 0x6F, 0x81, 0x2E, 0x17, 0x41, 0x72, 0x2C, 0x43, 0x27 };
        /// <summary>
        /// Initialization vector for the crypto provider
        /// </summary>
        private static readonly byte[] _initVector = { 0xE1, 0xF1, 0xA6, 0xBB, 0xA9, 0x5B, 0x31, 0x2F, 0x81, 0x2E, 0x17, 0x4C, 0xA2, 0x81, 0x53, 0x61 };
        public frmLogin()
        {
            InitializeComponent();
        }
#if (DEBUG) //Only compile this method for local debugging.
        /// <summary>
        /// Decrypt a string
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        private static string Decrypt(string Value)
        {
            SymmetricAlgorithm mCSP;
            ICryptoTransform ct = null;
            MemoryStream ms = null;
            CryptoStream cs = null;
            byte[] byt;
            byte[] _result;
            mCSP = new RijndaelManaged();
            try
            {
                mCSP.Key = _key;
                mCSP.IV = _initVector;
                ct = mCSP.CreateDecryptor(mCSP.Key, mCSP.IV);
                byt = Convert.FromBase64String(Value);
                ms = new MemoryStream();
                cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
                cs.Write(byt, 0, byt.Length);
                cs.FlushFinalBlock();
                cs.Close();
                _result = ms.ToArray();
            }
            catch
            {
                _result = null;
            }
            finally
            {
                if (ct != null)
                    ct.Dispose();
                if (ms != null)
                    ms.Dispose();
                if (cs != null)
                    cs.Dispose();
            }
            return ASCIIEncoding.UTF8.GetString(_result);
        }
#endif
        /// <summary>
        /// Encrypt a string
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>
        private static string Encrypt(string Password)
        {
            if (string.IsNullOrEmpty(Password))
                return string.Empty;
            byte[] Value = Encoding.UTF8.GetBytes(Password);
            SymmetricAlgorithm mCSP = new RijndaelManaged();
            mCSP.Key = _key;
            mCSP.IV = _initVector;
            using (ICryptoTransform ct = mCSP.CreateEncryptor(mCSP.Key, mCSP.IV))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, ct, CryptoStreamMode.Write))
                    {
                        cs.Write(Value, 0, Value.Length);
                        cs.FlushFinalBlock();
                        cs.Close();
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
        }
        /// <summary>
        /// Looks up the users password crypto string in the database
        /// </summary>
        /// <param name="Username"></param>
        /// <returns></returns>
        private static DataTable LookupUser(string Username)
        {
            /*
             * The reason I return a datatable here is so you can also bring back the user's full
             * name, email address, security rights in the application, etc. I have a "User" class
             * where I defined meta information for users.
             */
            const string connStr = "Data Source=802PACAJOJ\\SQLEXPRESS;Initial Catalog=flujoaereo;Integrated Security=True;";
            const string query = "Select Password From Users (NOLOCK) Where UserName = @UserName";
            DataTable result = new DataTable();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = Username;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        result.Load(dr);
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Obviously the .Focus() code doesn't apply to ASP.NET
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text))
            {
                //Focus box before showing a message
                textBoxUsername.Focus();
                MessageBox.Show("Enter your username", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Focus again afterwards, sometimes people double click message boxes and select another control accidentally
                textBoxUsername.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                textBoxPassword.Focus();
                MessageBox.Show("Enter your password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBoxPassword.Focus();
                return;
            }
            //OK they enter a user and pass, lets see if they can authenticate
            using (DataTable dt = LookupUser(textBoxUsername.Text))
            {
                if (dt.Rows.Count == 0)
                {
                    textBoxUsername.Focus();
                    MessageBox.Show("Invalid username.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUsername.Focus();
                    return;
                }
                else
                {
                    //Always compare the resulting crypto string or hash value, never the decrypted value
                    //By doing that you never make a call to Decrypt() and the application is harder to
                    //reverse engineer. I included the Decrypt() method here for informational purposes
                    //only. I do not recommend shipping an assembly with Decrypt() methods.
                    string dbPassword = Convert.ToString(dt.Rows[0]["Password"]).Trim();
                    string appPassword = Encrypt(textBoxPassword.Text); //we store the password as encrypted in the DB
                    if (string.Compare(dbPassword, appPassword) == 0)
                    {
                        //frmLogin.ActiveForm.Close();
                    }
                    else
                    {
                        //You may want to use the same error message so they can't tell which field they got wrong
                        textBoxPassword.Focus();
                        MessageBox.Show("Invalid Password", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxPassword.Focus();
                        return;
                    }
                }
            }
        }
    }
}
