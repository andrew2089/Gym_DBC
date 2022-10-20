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
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DB db1 = new DB();
            db1.openConnection();
            MySqlCommand command = new MySqlCommand("select client.Client_id, gym.Gym_adress, client.Client_name, Client.Client_surname FROM Gym LEFT join Coach on Coach.Coach_id = Gym.Coach_id LEFT JOIN Client on Client.Client_id = Coach.Client_id where Client.Client_id = 2;", db1.getConnection());

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
            }
            reader.Close();
            //command.Parameters.Add("@searchButton1", MySqlDbType.VarChar).Value = textBox1.Text;

            db1.closeConnection();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            DtFilter1 dtFilter1 = new DtFilter1();
            dtFilter1.Show();

        }

        private void SearchButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DtFilter2 dtFilter2 = new DtFilter2();
            dtFilter2.Show();
        }

        private void tariffByIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searcchButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DtFilter3 dtFilter3 = new DtFilter3();
            dtFilter3.Show();
        }

        private void SearchButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DtFilter4 dtFilter4 = new DtFilter4();
            dtFilter4.Show();
        }

        private void SearchButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DtFilter5 dtFilter5 = new DtFilter5();
            dtFilter5.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
