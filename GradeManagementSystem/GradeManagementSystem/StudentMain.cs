using System;
using System.Data;
using System.Windows.Forms;
using CCWin;
using System.Data.SqlClient;


namespace GradeManagementSystem
{
    public partial class StudentMain : Skin_Mac
    {
        string studentname;
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SG;Integrated Security=True");

        public StudentMain(string studentname)
        {
            this.studentname = studentname;
            InitializeComponent();

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SG;Integrated Security=True");
            string sqlstr = "select * from zhb where Sno = " + studentname ;
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void StudentMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login l = new Login();
            l.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string Sno = textBox1.Text;
            string Sname = textBox2.Text;
            string DyGrade = textBox4.Text;
            if (Sno == String.Empty || Sname == String.Empty || DyGrade == String.Empty)
            {
                MessageBox.Show("请输入全部数据！");
            }
            else if (Sno != studentname)
            {
                MessageBox.Show("请输入自己的成绩！");
            }
            else
            {
                string sqlstr = "insert into chb (Sno,Sname,Grade) values ('" + Sno + "','" + Sname + "','" + DyGrade + "')";
                SqlCommand cmd = new SqlCommand(sqlstr, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                MessageBox.Show("插入成功！");
                con.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string sqlstr = "SELECT * FROM chb WHERE Sno = " + studentname;
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
