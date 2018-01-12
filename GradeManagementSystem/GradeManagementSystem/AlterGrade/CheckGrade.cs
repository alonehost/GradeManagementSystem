using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GradeManagementSystem
{
    public partial class CheckGrade : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SG;Integrated Security=True");
        
        public CheckGrade()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == String.Empty)
            {
                MessageBox.Show("请输入学号！");
            } else{
                string Sno = textBox1.Text;
                string sqlstr = "DELETE FROM chb where Sno = " + Sno;
                SqlCommand cmd = new SqlCommand(sqlstr, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }

            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string sqlstr = "select * from chb ";
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
