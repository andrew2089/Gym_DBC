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
    public partial class DtFilter1 : Form
    {
        public DtFilter1()
        {
            InitializeComponent();
        }

        private void DtFilter1_Load(object sender, EventArgs e)
        {

            DB db = new DB();
            DataTable dt = new DataTable();
            
            db.openConnection();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("select client.`Client_id`, gym.`Gym_adress`, client.`Client_name`, Client.`Client_surname` FROM `Gym` LEFT join `Coach` on Coach.`Coach_id` = Gym.`Coach_id` LEFT JOIN `Client` on Client.`Client_id` = Coach.`Client_id` where Client.`Client_id` = 6", db.getConnection());

            adapter.SelectCommand = command;

           
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            db.closeConnection();

        }
        
        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm1 mainForm = new MainForm1();
            mainForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "") { 
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Client_id = '{textBox1.Text}'";
             DB db = new DB();
             DataTable dt = new DataTable();

             db.openConnection();

             MySqlDataAdapter adapter = new MySqlDataAdapter();

             MySqlCommand command = new MySqlCommand("select client.`Client_id`, gym.`Gym_adress`, client.`Client_name`, Client.`Client_surname` FROM `Gym` LEFT join `Coach` on Coach.`Coach_id` = Gym.`Coach_id` LEFT JOIN `Client` on Client.`Client_id` = Coach.`Client_id` where Client.`Client_id` = @id", db.getConnection());

              command.Parameters.Add("@id", MySqlDbType.String).Value = textBox1.Text;
             adapter.SelectCommand = command;


             adapter.Fill(dt);
             dataGridView1.DataSource = dt;

             db.closeConnection();
            }
        }
    }
}
