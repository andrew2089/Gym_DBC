using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_DBC
{
    public partial class DtFilter4 : Form
    {
        public DtFilter4()
        {
            InitializeComponent();
        }

        private void DtFilter4_Load(object sender, EventArgs e)
        {
            
                DB db = new DB();
                DataTable dt4 = new DataTable();

                db.openConnection();

                MySqlDataAdapter adapter3 = new MySqlDataAdapter();

                MySqlCommand command3 = new MySqlCommand("select Tariff.`Tariff_id`, Tariff.`Tariff_name`, Tariff.`Tariff_price` FROM `Tariff` LEFT join `Payment` on Tariff.`Tariff_id` = Payment.`Tariff_id` WHERE Tariff.`Tariff_name` LIKE '%Basic%'", db.getConnection());

                // command2.Parameters.Add("@coach", MySqlDbType.VarChar).Value = tariffByIDTextbox.Text;
                adapter3.SelectCommand = command3;


                adapter3.Fill(dt4);
                dataGridView4.DataSource = dt4;

                db.closeConnection();

            
        }

        private void backButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm1 mainForm = new MainForm1();
            mainForm.Show();
        }


        private void FilterDt4_TextChanged_1(object sender, EventArgs e)
        {
            if (FilterDt4.Text != "")
            {

                (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = $"Tariff_name = '%{FilterDt4.Text}%'";
                DB db = new DB();
                DataTable dt4 = new DataTable();

                db.openConnection();

                MySqlDataAdapter adapter3 = new MySqlDataAdapter();


                MySqlCommand command3 = new MySqlCommand("select Tariff.`Tariff_id`, Tariff.`Tariff_name`, Tariff.`Tariff_price` FROM `Tariff` LEFT join `Payment` on Tariff.`Tariff_id` = Payment.`Tariff_id` WHERE Tariff.`Tariff_name` LIKE @tar", db.getConnection());

                command3.Parameters.Add("@tar", MySqlDbType.VarChar).Value = FilterDt4.Text;
                adapter3.SelectCommand = command3;


                adapter3.Fill(dt4);
                dataGridView4.DataSource = dt4;

                db.closeConnection();
            }
        }
    }
}
