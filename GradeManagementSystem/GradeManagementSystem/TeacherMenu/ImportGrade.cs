using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace GradeManagementSystem

{
    public partial class ImportGrade : UserControl
    {
        public ImportGrade()
        {
            InitializeComponent();
        }

        private void ImportGrade_Load(object sender, EventArgs e)
        {

        }

        DataTable dt = new DataTable();
        string connString = "Data Source=.;Initial Catalog=SG;Integrated Security=True";
        SqlConnection conn;

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string fileName = fd.FileName;
                Bind1(fileName);
            }

        }
        private void Bind1(string fileName)
        {
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                 "Data Source=" + fileName + ";" +
                 "Extended Properties='Excel 8.0; HDR=Yes; IMEX=1'";
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT *  FROM [zyb$]", strConn);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                dt = ds.Tables[0];
                this.dataGridView1.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败" + err.ToString());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            conn.Open();
            if (dataGridView1.Rows.Count > 0)
            {
                DataRow dr = null;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dr = dt.Rows[i];
                    InsertToSql(dr);
                }
                conn.Close();
                MessageBox.Show("导入成功");
            }
            else
            {
                MessageBox.Show("没有数据");
            }
        }
        private void InsertToSql(DataRow dr)
        {
            //excel表中的列名和数据库中的列名一定要对应   
            string Sno = dr["Sno"].ToString();
            string Sname = dr["Sname"].ToString();
            int Sc = Convert.ToInt32(dr["Sc"]);
            int Sd = Convert.ToInt32(dr["Sd"]);
            int Se = Convert.ToInt32(dr["Se"]);
            int Grade = Convert.ToInt32(dr["Grade"]);
            int Nopass = Convert.ToInt32(dr["Nopass"]);
            string sql = "insert into zyb values('" + Sno + "','" + Sname + "','" + Sc + "','" + Sd + "','" + Se + "','" + Grade + "','"+ Nopass+ "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }


        private void Button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string fileName = fd.FileName;
                Bind2(fileName);
            }
        }
        private void Bind2(string fileName)
        {
            string strConn = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                 "Data Source=" + fileName + ";" +
                 "Extended Properties='Excel 8.0; HDR=Yes; IMEX=1'";
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT *  FROM [dyb$]", strConn);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                dt = ds.Tables[0];
                this.dataGridView1.DataSource = dt;
            }
            catch (Exception err)
            {
                MessageBox.Show("操作失败" + err.ToString());
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(connString);
            conn.Open();
            if (dataGridView1.Rows.Count > 0)
            {
                DataRow dr = null;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dr = dt.Rows[i];
                    InsertToSql2(dr);
                }
                conn.Close();
                MessageBox.Show("导入成功");
            }
            else
            {
                MessageBox.Show("没有数据");
            }
        }

        private void InsertToSql2(DataRow dr)
        {

            string Sno = dr["Sno"].ToString();
            string Sname = dr["Sname"].ToString();
            int Sc = Convert.ToInt32(dr["Sc"]);
            int Sd = Convert.ToInt32(dr["Sd"]);
            int Se = Convert.ToInt32(dr["Se"]);
            int Sf = Convert.ToInt32(dr["Sf"]);
            int Sg = Convert.ToInt32(dr["Sg"]);
            int Grade = Convert.ToInt32(dr["Grade"]);
            int Nopass = Convert.ToInt32(dr["Nopass"]);
            string sql = "insert into dyb values('" + Sno + "','" + Sname + "','" + Sc + "','" + Sd + "','" + Se + "','" + Sf + "','" + Sg + "','" + Grade + "','"+ Nopass +"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

        }
    }
}
