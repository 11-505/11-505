using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_genealogy
{
    public partial class Newgenealogy : Form
    {
        public Newgenealogy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source = .; Initial Catalog = Genealogy Data; User ID = sa; Password = 123456";
            string Sql = @"INSERT INTO Genealogy(Ge_id,Ge_name,Ge_xs,Ge_jx,Ge_bf,Ge_things,Ge_itr)VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox4.Text + "')";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(Sql, conn);
            cmd.ExecuteNonQuery();
            this.Hide();
            NewgenealogyT book = new NewgenealogyT();
            book.ShowDialog();
            this.Close();
        }
    }
}
