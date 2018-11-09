using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcoFarm_SQL_Lab2
{
    public partial class Form1 : Form
    {
        OdbcConnection connection;
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
            using (connection = new OdbcConnection(connectionString_ODBC))
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                connection.Open();

                try
                {
                    OdbcCommand selectCommand = new OdbcCommand(command, connection);
                    table.Load(selectCommand.ExecuteReader());
                    dataGridView1.DataSource = table;
                    MessageBox.Show("Should work");
                }
                catch(OdbcException ex)
                {
                    MessageBox.Show(ex.Message + "odbc error");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var table = new DataTable();
            string command = "UPDATE Invoice SET[Invoice type] = 2 WHERE[Invoice type] = 1";
            string connectionString_ODBC = "Driver={SQL Server};server=DESKTOP-50OOFA6;trusted_connection=Yes;app=Microsoft® Visual Studio®;wsid=DESKTOP-50OOFA6;database=EcoFarm_DB;language=русский";
            using (connection = new OdbcConnection(connectionString_ODBC))
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();

                connection.Open();

                try
                {
                    OdbcCommand updateCommand = new OdbcCommand(command, connection);
                    var res = updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Should work");
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message + "odbc error");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
