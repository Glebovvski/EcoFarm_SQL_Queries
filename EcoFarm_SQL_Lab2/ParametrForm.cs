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
    public partial class ParametrForm : Form
    {
        OdbcConnection connectionODBC;
        SqlConnection connectionSQL;

        string connesctionStringSQL = "Data Source=DESKTOP-50OOFA6;Initial Catalog=EcoFarm_DB;Integrated Security=True";
        string connesctionStringODBC = "Driver={SQL Server};server=DESKTOP-50OOFA6;trusted_connection=Yes;app=Microsoft® Visual Studio®;wsid=DESKTOP-50OOFA6;database=EcoFarm_DB;language=русский";

        public ParametrForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int param;
            var table = new DataTable();
            OdbcParameter parameter = new OdbcParameter();
            bool typeParam = int.TryParse(ParamTB.Text, out param);
            if (typeParam)
            {
                parameter.DbType = DbType.Int32;
                parameter.Value = param;
            }
            else
            {
                parameter.DbType = DbType.String;
                parameter.Value = ParamTB.Text;
            }

            string command = "SELECT * FROM [" + comboBox1.SelectedItem + "] WHERE [" + comboBox2.SelectedItem + "] = ?";

            //string connectionString_ODBC = "Driver={SQL Server};server=DESKTOP-50OOFA6;trusted_connection=Yes;app=Microsoft® Visual Studio®;wsid=DESKTOP-50OOFA6;database=EcoFarm_DB;language=русский";
            using (connectionODBC = new OdbcConnection(connesctionStringODBC))
            {
                if (connectionODBC.State == ConnectionState.Open)
                    connectionODBC.Close();

                connectionODBC.Open();

                try
                {
                    OdbcCommand selectCommand = new OdbcCommand(command, connectionODBC);
                    selectCommand.Parameters.Add(parameter);
                    table.Load(selectCommand.ExecuteReader());
                    dataGridViewParam.DataSource = table;
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var invoiceList = new List<string>()
            {
                "Invoice number",
                "Date",
                "Supplier code",
                "Invoice type",
                "Supplier",
                "Reciever"
            };

            var invProdList = new List<string>()
            {
                "Product code",
                "Name",
                "Units",
                "Number of units",
                "Unit price",
                "Total price",
                "Invoice number"
            };

            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(invoiceList.ToArray());
            }
            else
            {
                comboBox2.Items.Clear();
                comboBox2.Items.AddRange(invProdList.ToArray());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int param;
            var table = new DataTable();
            OdbcParameter parameter = new OdbcParameter();
            bool typeParam = int.TryParse(ParamTB.Text, out param);
            if (typeParam)
            {
                parameter.OdbcType = OdbcType.Int;
                parameter.Value = param;
            }
            else
            {
                parameter.OdbcType = OdbcType.VarChar;
                parameter.Value = ParamTB.Text;
            }

            string command = "SELECT * FROM [" + comboBox1.SelectedItem + "] WHERE [" + comboBox2.SelectedItem + "] = ?";

            //string connectionString_ODBC = "Driver={SQL Server};server=DESKTOP-50OOFA6;trusted_connection=Yes;app=Microsoft® Visual Studio®;wsid=DESKTOP-50OOFA6;database=EcoFarm_DB;language=русский";
            using (connectionODBC = new OdbcConnection(connesctionStringODBC))
            {
                if (connectionODBC.State == ConnectionState.Open)
                    connectionODBC.Close();

                connectionODBC.Open();
                try
                {
                    OdbcCommand selectCommand = new OdbcCommand(command, connectionODBC);
                    selectCommand.Parameters.Add(parameter);
                    ParamTB.Text = selectCommand.ExecuteScalar().ToString();
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
            int param;
            var table = new DataTable();
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@Param";
            bool typeParam = int.TryParse(ParamTB.Text, out param);
            if (typeParam)
            {
                parameter.DbType = DbType.Int32;
                parameter.Value = param;
            }
            else
            {
                parameter.DbType = DbType.String;
                parameter.Value = ParamTB.Text;
            }

            string command = "SELECT * FROM [" + comboBox1.SelectedItem + "] WHERE [" + comboBox2.SelectedItem + "] = @Param";

            //string connectionString_Sql = "Data Source=DESKTOP-50OOFA6;Initial Catalog=EcoFarm_DB;Integrated Security=True";
            using (connectionSQL = new SqlConnection(connesctionStringSQL))
            {
                if (connectionSQL.State == ConnectionState.Open)
                    connectionSQL.Close();

                connectionSQL.Open();

                try
                {
                    SqlCommand selectCommand = new SqlCommand(command, connectionSQL);
                    selectCommand.Parameters.Add(parameter);
                    table.Load(selectCommand.ExecuteReader());
                    dataGridViewParam.DataSource = table;
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
            int param;
            var table = new DataTable();
            SqlParameter parameter = new SqlParameter();
            parameter.ParameterName = "@Param";
            bool typeParam = int.TryParse(ParamTB.Text, out param);
            if (typeParam)
            {
                parameter.DbType = DbType.Int32;
                parameter.Value = param;
            }
            else
            {
                parameter.DbType = DbType.String;
                parameter.Value = ParamTB.Text;
            }

            string command = "SELECT * FROM [" + comboBox1.SelectedItem + "] WHERE [" + comboBox2.SelectedItem + "] = @Param";

            //string connectionString_ODBC = "Driver={SQL Server};server=DESKTOP-50OOFA6;trusted_connection=Yes;app=Microsoft® Visual Studio®;wsid=DESKTOP-50OOFA6;database=EcoFarm_DB;language=русский";
            using (connectionSQL = new SqlConnection(connesctionStringSQL))
            {
                if (connectionSQL.State == ConnectionState.Open)
                    connectionSQL.Close();

                connectionSQL.Open();
                try
                {
                    SqlCommand selectCommand = new SqlCommand(command, connectionSQL);
                    selectCommand.Parameters.Add(parameter);
                    ParamTB.Text = selectCommand.ExecuteScalar().ToString();
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

        private void button5_Click(object sender, EventArgs e)
        {
            var table = new DataTable();
            OdbcParameter date;
            OdbcParameter supCode;
            OdbcParameter invoiceType;
            OdbcParameter supplier;
            OdbcParameter reciever;
            try
            {
                date = new OdbcParameter();
                date.Value = DateTime.Parse(DateTB.Text);
                supCode = new OdbcParameter();
                supCode.Value = int.Parse(SupCodeTB.Text);
                invoiceType = new OdbcParameter();
                invoiceType.Value = int.Parse(InvoiceTypeTB.Text);
                supplier = new OdbcParameter();
                supplier.Value = SupplierTB.Text;
                reciever = new OdbcParameter();
                reciever.Value = RecieverTB.Text;

                string command = "INSERT INTO [Invoice]([Date], [Supplier code], [Invoice type], Supplier, Reciever) VALUES(?, ?, ?, ?, ?)";
                //string connectionString_ODBC = "Driver={SQL Server};server=DESKTOP-50OOFA6;trusted_connection=Yes;app=Microsoft® Visual Studio®;wsid=DESKTOP-50OOFA6;database=EcoFarm_DB;language=русский";
                using (connectionODBC = new OdbcConnection(connesctionStringODBC))
                {
                    if (connectionODBC.State == ConnectionState.Open)
                        connectionODBC.Close();

                    connectionODBC.Open();

                    try
                    {
                        OdbcCommand insertCommand = new OdbcCommand(command, connectionODBC);
                        insertCommand.Parameters.Add(date);
                        insertCommand.Parameters.Add(supCode);
                        insertCommand.Parameters.Add(invoiceType);
                        insertCommand.Parameters.Add(supplier);
                        insertCommand.Parameters.Add(reciever);
                        int res =insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Insert successfully\n"+ res+" rows affected");
                    }
                    catch (OdbcException ex)
                    {
                        MessageBox.Show(ex.Message + " odbc error");
                    }
                    finally
                    {
                        connectionODBC.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Make sure data is correct");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var table = new DataTable();
            SqlParameter name;
            SqlParameter units;
            SqlParameter numOfUnits;
            SqlParameter unitPrice;
            SqlParameter totalPrice;
            SqlParameter invoiceNumber;
            try
            {
                name = new SqlParameter("@Name", SqlDbType.VarChar);
                name.Value = NameTB.Text;
                units = new SqlParameter("@Units", SqlDbType.VarChar);
                units.Value = UnitsTB.Text;
                numOfUnits = new SqlParameter("@NumOfUnits", SqlDbType.Float);
                numOfUnits.Value = float.Parse(NumOfUnitsTB.Text);
                unitPrice = new SqlParameter("@UnitPrice", SqlDbType.Float);
                unitPrice.Value = float.Parse(UnitPriceTB.Text);
                totalPrice = new SqlParameter("@TotalPrice", SqlDbType.Float);
                totalPrice.Value = float.Parse(TotalPriceTB.Text);
                invoiceNumber = new SqlParameter("@InvoiceNum", SqlDbType.Int);
                invoiceNumber.Value = int.Parse(InvNumberTB.Text);

                string command = "INSERT INTO [Invoice products] VALUES(@Name, @Units, @NumOfUnits, @UnitPrice, @TotalPrice, @InvoiceNum)";
                //string connectionString_ODBC = "Driver={SQL Server};server=DESKTOP-50OOFA6;trusted_connection=Yes;app=Microsoft® Visual Studio®;wsid=DESKTOP-50OOFA6;database=EcoFarm_DB;language=русский";
                using (connectionSQL = new SqlConnection(connesctionStringSQL))
                {
                    if (connectionSQL.State == ConnectionState.Open)
                        connectionSQL.Close();

                    connectionSQL.Open();

                    try
                    {
                        SqlCommand insertCommand = new SqlCommand(command, connectionSQL);
                        insertCommand.Parameters.Add(name);
                        insertCommand.Parameters.Add(units);
                        insertCommand.Parameters.Add(numOfUnits);
                        insertCommand.Parameters.Add(unitPrice);
                        insertCommand.Parameters.Add(totalPrice);
                        insertCommand.Parameters.Add(invoiceNumber);
                        var res = insertCommand.ExecuteNonQuery();
                        MessageBox.Show("Insert successfully\n" + res+" rows affected");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message + " sql error");
                    }
                    finally
                    {
                        connectionSQL.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Make sure data is correct");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
