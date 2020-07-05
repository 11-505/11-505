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
    public partial class Checkgenealogy : Form
    {
        public Checkgenealogy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source= .;Initial Catalog=Genealogy Data; User ID=sa;Password=123456";
            string Ge_id = textBox1.Text;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string sql = @"SELECT * FROM Genealogy WHERE Ge_id='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (!dr.Read())
            {
                MessageBox.Show("该族谱不存在！请检查是否输入错误！");
                return;
            }
            textBox2.Text = dr["Ge_name"].ToString();
            textBox3.Text = dr["Ge_xs"].ToString();
            textBox4.Text = dr["Ge_itr"].ToString();
            textBox5.Text = dr["Ge_jx"].ToString();
            textBox6.Text = dr["Ge_bf"].ToString();
            textBox7.Text = dr["Ge_things"].ToString();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connString = @"Data Source= .;Initial Catalog=Genealogy Data; User ID=sa;Password=123456";
            StringBuilder sb = new StringBuilder();
            sb.Append("您修改的信息为：");
            sb.Append("\n族谱ID：" + textBox1.Text);
            sb.Append("\n族谱名称：" + textBox2.Text);
            sb.Append("\n族谱姓氏：" + textBox3.Text);
            sb.Append("\n族谱简介：" + textBox4.Text);
            sb.Append("\n家族对成员教诲：" + textBox5.Text);
            sb.Append("\n家族备份：" + textBox6.Text);
            sb.Append("\n家族大事件：" + textBox7.Text);
            MessageBox.Show(sb.ToString(), "请检查", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            string sql = @"UPDATE Genealogy SET Ge_name='" + textBox2.Text + "',Ge_xs='" + textBox3.Text + "',Ge_itr='" + textBox4.Text + "',Ge_jx='" + textBox5.Text + "',Ge_bf='" + textBox6.Text + "',Ge_things='" + textBox7.Text + "' WHERE Ge_id='" + textBox1.Text + "' ";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("信息成功修改！");
            }
            catch (Exception msg)
            {
                MessageBox.Show("出问题了！\n错误原因：" + msg.Message);
            }
            conn.Close();
        }

        private void Newgenealogy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("退出系统前请确认数据已经存储！继续退出吗？", "请提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dr.Equals(DialogResult.No))
                e.Cancel = true;
        }
    }
    
}
