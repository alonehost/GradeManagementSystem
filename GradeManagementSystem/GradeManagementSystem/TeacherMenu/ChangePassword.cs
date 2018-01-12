using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GradeManagementSystem
{
    public partial class ChangePassword : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SG;Integrated Security=True");
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Username = textBox1.Text;
            string Password = textBox2.Text;

            if (Username == String.Empty || Password == String.Empty)
            {
                MessageBox.Show("请输入用户名和更改后的密码！");
            }
            else
            {
                string sqlstr = "update Teacher set Password = '" + Password + "' where Username = '" + Username + "'";
                SqlCommand cmd = new SqlCommand(sqlstr, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("修改成功！");
                con.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string Username = textBox4.Text;
            string Password = textBox3.Text;

            if (Username == String.Empty || Password == String.Empty)
            {
                MessageBox.Show("请输入用户名和更改后的密码！");
            }
            else
            {
                string sqlstr = "update Student$ set Password = '" + Password + "' where Username = '" + Username + "'";
                SqlCommand cmd = new SqlCommand(sqlstr, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("修改成功！");
                con.Close();
            }
        }
    }
}
