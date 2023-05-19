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

namespace mazegamefinalproj.Properties
{
    public partial class scores : Form
    {
        string cs = @"server=localhost;userid=admin;password=password;database=mazegamescores";
        int playersplunders = 0;
        public scores(int splunders)
        {
            playersplunders = splunders;
            InitializeComponent();
            using var con = new MySqlConnection(cs);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM players", con);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = reader[0];
                    row.Cells[1].Value = reader[1];
                    dataGridView1.Rows.Add(row);
                }
            }
            dataGridView1.Sort(clmScore, ListSortDirection.Descending);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {

            } else
            {
                button1.Visible = false;
                textBox1.Visible = false;
                label2.Visible = false;
                string un = textBox1.Text;
                using var con = new MySqlConnection(cs);
                con.Open();
                using var cmd = new MySqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"INSERT INTO players(username, score) VALUES ('{un}', '{playersplunders}')";
                cmd.ExecuteNonQuery();
                updateTable(un);
            }
        }

        public void updateTable(string un)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = un;
            row.Cells[1].Value = playersplunders;
            dataGridView1.Rows.Add(row);
            dataGridView1.Sort(clmScore, ListSortDirection.Descending);
        }
    }
}
