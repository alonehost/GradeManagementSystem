using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GradeManagementSystem
{
    public partial class InputGrade : UserControl
    {
        public InputGrade()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Sno = textBox1.Text;
            string Sname = textBox2.Text;
            string ZyGrade = textBox3.Text;
            string DyGrade = textBox4.Text;

            if (Sno == String.Empty || Sname == String.Empty || ZyGrade == String.Empty || DyGrade == String.Empty)
            {
                MessageBox.Show("请输入全部数据！");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SG;Integrated Security=True");
                string sqlstr1 = "insert into zyb (Sno,Sname,Grade) values ('" + Sno + "','" + Sname + "','" + ZyGrade + "')";
                SqlCommand cmd1 = new SqlCommand(sqlstr1, con);
                con.Open();
                SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);

                string sqlstr2 = "insert into dyb (Sno,Sname,Grade) values ('" + Sno + "','" + Sname + "','" + DyGrade + "')";
                SqlCommand cmd2 = new SqlCommand(sqlstr2, con);
                //con.Open();
                SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                da2.Fill(dt2);

                MessageBox.Show("插入成功！");
                con.Close();
            }      
        }
    }
}
