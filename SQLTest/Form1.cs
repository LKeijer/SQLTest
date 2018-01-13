using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenConnection();
            CloseConnection();
        }

        public static void OpenConnection()
        { 
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Waffl\\Desktop\\C#\\SQL\\SQLTest\\SQLTest\\Database1.mdf;Integrated Security=True";
            SqlConnection connecThong = new SqlConnection();
            connecThong.ConnectionString = connectionString;
            connecThong.Open();
        }
        public static void CloseConnection()
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Waffl\\Desktop\\C#\\SQL\\SQLTest\\SQLTest\\Database1.mdf;Integrated Security=True";
            SqlConnection connecThong = new SqlConnection();
            connecThong.ConnectionString = connectionString;
            connecThong.Close();
        }
    }
}
