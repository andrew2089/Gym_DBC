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
    public partial class DtFilter2 : Form
    {
        public DtFilter2()
        {
            InitializeComponent();
        }

        private void DtFilter2_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            DataTable dt2 = new DataTable();

            db.openConnection();

            MySqlDataAdapter adapter1 = new MySqlDataAdapter();

            MySqlCommand command1 = new MySqlCommand("select client.`Client_id`, Tariff.`Tariff_id`, Tariff.`Tariff_name`, Tariff.`Tariff_price` FROM `Tariff` LEFT join `Client` on Client.`Tariff_id` = Tariff.`Tariff_id` WHERE Client.`Client_id` = 3", db.getConnection());

            //command.Parameters.Add("@id", MySqlDbType.Int16).Value = TextBox.;
            adapter1.SelectCommand = command1;


            adapter1.Fill(dt2);
            dataGridView2.DataSource = dt2;

            db.closeConnection();

        }

        private void backButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm1 mainForm = new MainForm1();
            mainForm.Show();
        }



        private void sortDT2_TextChanged_1(object sender, EventArgs e)
        {
            if (sortDT2.Text != "")
            {
                (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"Client_id = '{sortDT2.Text}'";
                DB db = new DB();
                DataTable dt2 = new DataTable();

                db.openConnection();

                MySqlDataAdapter adapter1 = new MySqlDataAdapter();

                MySqlCommand command1 = new MySqlCommand("select client.`Client_id`, Tariff.`Tariff_id`, Tariff.`Tariff_name`, Tariff.`Tariff_price` FROM `Tariff` LEFT join `Client` on Client.`Tariff_id` = Tariff.`Tariff_id` WHERE Client.`Client_id` = @id2", db.getConnection());

                command1.Parameters.Add("@id2", MySqlDbType.String).Value = sortDT2.Text;
                adapter1.SelectCommand = command1;


                adapter1.Fill(dt2);
                dataGridView2.DataSource = dt2;

                db.closeConnection();
            }
        }
    }
}
