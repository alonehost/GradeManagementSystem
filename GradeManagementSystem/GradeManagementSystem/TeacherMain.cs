using System;
using CCWin;


namespace GradeManagementSystem
{
    public partial class TeacherMain : Skin_Mac
    {
        public ImportGrade importGrade = new ImportGrade();
        public SearchGrade searchGrade = new SearchGrade();
        public InputGrade inputGrade = new InputGrade();
        public CheckGrade checkGrade = new CheckGrade();
        public AlterGrade.AlterGrade alterGrade = new AlterGrade.AlterGrade();
        public AlterGrade.DropGrade dropGrade = new AlterGrade.DropGrade();
        public Scholar scholar = new Scholar();
        public ChangePassword changePassword = new ChangePassword();

        public TeacherMain()
        {
            InitializeComponent();
        }

        private void 成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importGrade.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(importGrade);

        }

        private void 成绩查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchGrade.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(searchGrade);
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);//强制关闭程序
        }

        private void 输入成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputGrade.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(inputGrade);
        }

        private void 成绩审核ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            checkGrade.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(checkGrade);
        }

        private void 修改成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            alterGrade.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(alterGrade);
        }

        private void 删除成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dropGrade.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(dropGrade);
        }

        private void 奖学金查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scholar.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(scholar);
        }

        private void 密码修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePassword.Show();
            groupBox1.Controls.Clear();
            groupBox1.Controls.Add(changePassword);
        }
    }
}
