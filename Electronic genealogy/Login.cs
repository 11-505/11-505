using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Electronic_genealogy
{
    public partial class MainForm : Form
    {
        public static int loginin = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {

            if (comboBoxID.Text == "用户")
            {
                DataTable dt = DB.Select("select M_id,U_pwd from Users where M_id='" + textBoxID.Text +
    "'and U_pwd='" + textBoxPassword.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    loginin = 1;
                    MessageBox.Show("登陆成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                    this.Close();
                }
                else if (textBoxID.Text == null)
                {
                    MessageBox.Show("账号不能为空！");
                }
                else if (textBoxPassword.Text == null)
                {
                    MessageBox.Show("密码不能为空!");
                }
                else
                {
                    MessageBox.Show("账号或密码错误");
                }
            }
            else if (comboBoxID.Text == "族谱管理员")
            {
                DataTable dt = DB.Select("select GA_id,GA_pwd from Geadmins where GA_id='" + textBoxID.Text +
  "'and GA_pwd='" + textBoxPassword.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    loginin = 2;
                    MessageBox.Show("登陆成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                    this.Close();
                }
                else if (textBoxID.Text == null)
                {
                    MessageBox.Show("账号不能为空！");
                }
                else if (textBoxPassword.Text == null)
                {
                    MessageBox.Show("密码不能为空!");
                }
                else
                {
                    MessageBox.Show("账号或密码错误");
                }
            }
            else if (comboBoxID.Text == "系统管理员")
            {
                DataTable dt = DB.Select("select SA_id,SA_pwd from Systemadmins where SA_id='" + textBoxID.Text +
     "'and SA_pwd='" + textBoxPassword.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    loginin = 3;
                    MessageBox.Show("登陆成功！");
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                    this.Close();               
                }
                else if (textBoxID.Text == null)
                {
                    MessageBox.Show("账号不能为空！");
                }
                else if (textBoxPassword.Text == null)
                {
                    MessageBox.Show("密码不能为空!");
                }
                else
                {
                    MessageBox.Show("账号或密码错误");
                }
            }
        }
    }
}
