using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoFarm_SQL_Lab2
{
    public partial class Form1 : Form
    {
        OdbcConnection connectionODBC;
        SqlConnection connectionSQL;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var table = new DataTable();
            string command = "SELECT * FROM Invoice WHERE [Invoice type] = 2";
            string connectionString_ODBC = "Driver={SQL Server};server=DESKTOP-50OOFA6;trusted_connection=Yes;app=Microsoft® Visual Studio®;wsid=DESKTOP-50OOFA6;database=EcoFarm_DB;language=русский";
            using (connectionODBC = new OdbcConnection(connectionString_ODBC))
            {
                if (connectionODBC.State == ConnectionState.Open)
                    connectionODBC.Close();

                connectionODBC.Open();

                try
                {
                    OdbcCommand selectCommand = new OdbcCommand(command, connectionODBC);
                    table.Load(selectCommand.ExecuteReader());
                    dataGridView1.DataSource = table;
                }
                catch(OdbcException ex)
                {
                    MessageBox.Show(ex.Message + "odbc error");
                }
                finally
                {
                    connectionODBC.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var table = new DataTable();
            string command = "UPDATE Invoice SET[Invoice type] = 2 WHERE[Invoice type] = 1";
            string connectionString_ODBC = "Driver={SQL Server};server=DESKTOP-50OOFA6;trusted_connection=Yes;app=Microsoft® Visual Studio®;wsid=DESKTOP-50OOFA6;database=EcoFarm_DB;language=русский";
            using (connectionODBC = new OdbcConnection(connectionString_ODBC))
            {
                if (connectionODBC.State == ConnectionState.Open)
                    connectionODBC.Close();

                connectionODBC.Open();

                try
                {
                    OdbcCommand updateCommand = new OdbcCommand(command, connectionODBC);
                    var res = updateCommand.ExecuteNonQuery();
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message + "odbc error");
                }
                finally
                {
                    connectionODBC.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var table = new DataTable();
            string command = "SELECT * FROM [Invoice products] WHERE Units = 'kg'";
            string connectionString = @"Data Source=DESKTOP-50OOFA6;Initial Catalog=EcoFarm_DB;Integrated Security=True";
            using (connectionSQL = new SqlConnection(connectionString))
            {
                if (connectionSQL.State == ConnectionState.Open)
                    connectionSQL.Close();

                connectionSQL.Open();

                try
                {
                    SqlCommand selectCommand = new SqlCommand(command, connectionSQL);
                    table.Load(selectCommand.ExecuteReader());
                    dataGridView1.DataSource = table;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message + "sql error");
                }
                finally
                {
                    connectionSQL.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var table = new DataTable();
            string command = "UPDATE [Invoice products] SET [Invoice Number]=1 WHERE Name='Cocumbers'";
            string connectionString = @"Data Source=DESKTOP-50OOFA6;Initial Catalog=EcoFarm_DB;Integrated Security=True";
            using (connectionSQL = new SqlConnection(connectionString))
            {
                if (connectionSQL.State == ConnectionState.Open)
                    connectionSQL.Close();

                connectionSQL.Open();

                try
                {
                    SqlCommand updateCommand = new SqlCommand(command, connectionSQL);
                    var res = updateCommand.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message + "sql error");
                }
                finally
                {
                    connectionSQL.Close();
                }
            }
        }
    }
}
