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
    public partial class DtFilter5 : Form
    {
        public DtFilter5()
        {
            InitializeComponent();
        }

        private void backButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm1 mainForm = new MainForm1();
            mainForm.Show();
        }

        private void DtFilter5_Load(object sender, EventArgs e)
        {

            DB db = new DB();
            DataTable dt5 = new DataTable();

            db.openConnection();

            MySqlDataAdapter adapter4 = new MySqlDataAdapter();

            MySqlCommand command4 = new MySqlCommand("SELECT Payment.`Tariff_id`, Client.`Client_id`, Client.`Client_name`, `Client_surname`,Payment.`Payment_id`, `Payment_date` FROM `Payment` LEFT join `Client` on Client.`Tariff_id` = Payment.`Tariff_id` WHERE Payment.`Tariff_id` = 2", db.getConnection());

            // command2.Parameters.Add("@coach", MySqlDbType.VarChar).Value = tariffByIDTextbox.Text;
            adapter4.SelectCommand = command4;


            adapter4.Fill(dt5);
            dataGridView5.DataSource = dt5;

            db.closeConnection();


        }

        private void filter5_TextChanged(object sender, EventArgs e)
        {
            if (filter5.Text != "")
            {
                (dataGridView5.DataSource as DataTable).DefaultView.RowFilter = $"Tariff_id ='{filter5.Text}'";
                DB db = new DB();
                DataTable dt5 = new DataTable();

                db.openConnection();

                MySqlDataAdapter adapter4 = new MySqlDataAdapter();


                MySqlCommand command4 = new MySqlCommand("SELECT Payment.`Tariff_id`, Client.`Client_id`, Client.`Client_name`, `Client_surname`,Payment.`Payment_id`, `Payment_date` FROM `Payment` LEFT join `Client` on Client.`Tariff_id` = Payment.`Tariff_id` WHERE Payment.`Tariff_id` LIKE @id5", db.getConnection());

                command4.Parameters.Add("@id5", MySqlDbType.VarChar).Value = filter5.Text;
                adapter4.SelectCommand = command4;


                adapter4.Fill(dt5);
                dataGridView5.DataSource = dt5;

                db.closeConnection();
            }
        }
    }
}
