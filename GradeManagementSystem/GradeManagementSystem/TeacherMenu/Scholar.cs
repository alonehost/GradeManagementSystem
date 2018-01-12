using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GradeManagementSystem
{
    public partial class Scholar : UserControl
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SG;Integrated Security=True");
        public Scholar()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            string sqlstr = "select top 1  * from temp";
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            con.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, con);
            DataTable mydt = new DataTable();
            myda.Fill(mydt);

            dataGridView1.DataSource = mydt;


            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           
            string sqlstr = "select top 2  * from temp where zhrank > 1 ";
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            con.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, con);
            DataTable mydt = new DataTable();
            myda.Fill(mydt);

            dataGridView2.DataSource = mydt;


            con.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            string sqlstr = "select top 3  * from temp where zhrank > 3 ";
            SqlCommand cmd = new SqlCommand(sqlstr, con);
            con.Open();
            SqlDataAdapter myda = new SqlDataAdapter(sqlstr, con);
            DataTable mydt = new DataTable();
            myda.Fill(mydt);

            dataGridView3.DataSource = mydt;


            con.Close();
        }
    }
}
