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
    public partial class DtFilter3 : Form
    {
        public DtFilter3()
        {
            InitializeComponent();
        }

        private void backButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm1 mainForm = new MainForm1();
            mainForm.Show();
        }

        private void DtFilter3_Load(object sender, EventArgs e)
        {
            {
                DB db = new DB();
                DataTable dt3 = new DataTable();

                db.openConnection();

                MySqlDataAdapter adapter2 = new MySqlDataAdapter();

                MySqlCommand command2 = new MySqlCommand("select Coach.`Coach_name`, Coach.`Coach_surname`, Coach.`Coach_phone_number` from `Coach` where Coach.`Coach_name` LIKE '%Valery%'", db.getConnection());

               // command2.Parameters.Add("@coach", MySqlDbType.VarChar).Value = tariffByIDTextbox.Text;
                adapter2.SelectCommand = command2;


                adapter2.Fill(dt3);
                dataGridView3.DataSource = dt3;

                db.closeConnection();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (sortName.Text != "")
            {
                (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = $"Coach_name = '%{sortName.Text}%'";
                DB db = new DB();
                DataTable dt3 = new DataTable();

                db.openConnection();

                MySqlDataAdapter adapter2 = new MySqlDataAdapter();

                MySqlCommand command2 = new MySqlCommand("select Coach.`Coach_name`, Coach.`Coach_surname`, Coach.`Coach_phone_number` from `Coach` where Coach.`Coach_name` LIKE @coach", db.getConnection());

                command2.Parameters.Add("@coach", MySqlDbType.VarChar).Value = sortName.Text;
                adapter2.SelectCommand = command2;


                adapter2.Fill(dt3);
                dataGridView3.DataSource = dt3;

                db.closeConnection();

            }
        }
    }
}
