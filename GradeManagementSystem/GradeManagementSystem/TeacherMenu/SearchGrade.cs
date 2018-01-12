using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GradeManagementSystem
{
    public partial class SearchGrade : UserControl
    {
        string Str;
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SG;Integrated Security=True");
        public SearchGrade()
        {
            InitializeComponent();
        }

    
        private void Button1_Click(object sender, EventArgs e)
        {
            Str = comboBox1.Text;

            if (Str == String.Empty)
            {
                MessageBox.Show("请选择要查询的表！");
            }
            else
            {
                string sqlstr = "select * from " + Str;
                SqlCommand cmd = new SqlCommand(sqlstr, con);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                con.Close();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Str = comboBox1.Text;
            string Sno = textBox1.Text;
            if (Str == String.Empty || Sno == String.Empty)
            {
                MessageBox.Show("请选择要查询的表或输入学号！");
            }
            else
            {
                string sqlstr = "select * from " + Str + " where Sno = " + Sno;
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
}
