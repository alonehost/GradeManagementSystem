using System;
using System.Data;
using System.Windows.Forms;
using CCWin;
using System.Data.SqlClient;

namespace GradeManagementSystem
{
    public partial class Login : Skin_Mac
    {

        public Login()
        {
            InitializeComponent();
        }

        private void Teacher_Login_Click(object sender, EventArgs e)
        {
            if (txUsername.Text == "")
            {
                MessageBox.Show("请输入账号或密码");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SG;Integrated Security=True");

                try
                {
                    string sql = "select * from  Teacher where Teacher.Username=@username and Teacher.Password=@pwd";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@username", txUsername.Text);
                    cmd.Parameters.AddWithValue("@pwd", txPassword.Text);

                    con.Open();
                    //cmd.Connection = con;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("登录成功！");
                        this.Hide();
                        TeacherMain teacher = new TeacherMain();
                        teacher.Show();
                    }
                    else
                    {
                        MessageBox.Show("账号、密码错误！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Student_Login_Click(object sender, EventArgs e)
        {
            if (txUsername.Text == "")
            {
                MessageBox.Show("请输入账号或密码");
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SG;Integrated Security=True");

                try
                {
                    string sql = "select * from  Student$ where Student$.Username=@username and Student$.Password=@pwd";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    string studentname = txUsername.Text;
                    cmd.Parameters.AddWithValue("@username", studentname);
                    cmd.Parameters.AddWithValue("@pwd", txPassword.Text);

                    con.Open();
                    //cmd.Connection = con;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("登录成功！");
                        this.Hide();
                        StudentMain student = new StudentMain(studentname);
                        student.Show();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码错误！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}