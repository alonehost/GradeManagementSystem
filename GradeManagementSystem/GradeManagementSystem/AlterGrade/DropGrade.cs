using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GradeManagementSystem.AlterGrade
{
    
    public partial class DropGrade : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SG;Integrated Security=True");
        string Sno;
        public DropGrade()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Sno = textBox1.Text;

            if (Sno == String.Empty)
            {
                MessageBox.Show("请输入学号！");
            }
            else
            {
                string sqlstr1 = "DELETE FROM zyb where Sno = " + Sno;
                SqlCommand cmd1 = new SqlCommand(sqlstr1, con);
                con.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);

                string sqlstr2 = "DELETE FROM dyb where Sno = " + Sno;
                SqlCommand cmd2 = new SqlCommand(sqlstr2, con);
                //con.Open();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                con.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Sno = textBox1.Text;

            if (Sno == String.Empty)
            {
                MessageBox.Show("请输入学号！");
            }
            else
            {
                string sqlstr1 = "select * from zyb where Sno = " + Sno;
                SqlCommand cmd1 = new SqlCommand(sqlstr1, con);
                con.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);
                dataGridView1.DataSource = dt1;

                string sqlstr2 = "select * from dyb where Sno = " + Sno;
                SqlCommand cmd2 = new SqlCommand(sqlstr2, con);
                //con.Open();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);
                dataGridView2.DataSource = dt2;

                con.Close();
            }
        }
    }
}
