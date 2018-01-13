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
            // TODO: This line of code loads data into the 'database1DataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.database1DataSet.Account);

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

        public static void GetData()
        {
            string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Waffl\\Desktop\\C#\\SQL\\SQLTest\\SQLTest\\Database1.mdf;Integrated Security=True";
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                string list = "select * from Account";
                SqlDataAdapter dataadapter = new SqlDataAdapter(list, myConnection);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds, "Account");
                
                //grid.DataSource = ds.Tables[0];
            }

           // SqlCommand command = new SqlCommand("select * from Account;");


        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
