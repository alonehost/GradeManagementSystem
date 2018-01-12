using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GradeManagementSystem.AlterGrade
{
    public partial class AlterGrade : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SG;Integrated Security=True");
        public AlterGrade()
        {
            InitializeComponent();
            
            string sqlstr = "select * from dyb";
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Sno = textBox1.Text;
            string Grade = textBox2.Text;

            if (Sno == String.Empty || Grade == String.Empty)
            {
                MessageBox.Show("请输入要更新的德育成绩和学生学号！");
            }
            else
            {
                string sqlstr = "update dyb set Grade = " + Grade + " where Sno = " + Sno;
                SqlCommand cmd = new SqlCommand(sqlstr, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                MessageBox.Show("更新成功！");
                con.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sqlstr = "select * from dyb";
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }
    }
}
