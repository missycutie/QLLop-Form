using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnection conn; 
        SqlCommand cmd;
        string str = "Data Source=(local);Initial Catalog=QLSVNhom;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from LOP";
            adapter.SelectCommand = cmd;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.ReadOnly = true;
            int i;
            i = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
 
        }

        private void Them_Click(object sender, EventArgs e)
        {
            try {
                cmd = conn.CreateCommand();
                cmd.CommandText = "insert into LOP values ('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "')";
                cmd.ExecuteNonQuery();
                loadData(); }
            catch {
                MessageBox.Show("Invalid input value");
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "update LOP set TENLOP ='" + textBox2.Text + "', MANV='" + textBox3.Text + "' WHERE MALOP='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                loadData();
            }
            catch
            {
                MessageBox.Show("Invalid input value");
            }
        }
    }
}