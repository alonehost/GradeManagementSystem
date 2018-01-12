using System;

namespace GradeManagementSystem
{
    partial class TeacherMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.成绩导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.输入成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩审核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.奖学金查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.密码修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.成绩导入ToolStripMenuItem,
            this.成绩查询ToolStripMenuItem,
            this.成绩修改ToolStripMenuItem,
            this.奖学金查询ToolStripMenuItem,
            this.密码修改ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(4, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 成绩导入ToolStripMenuItem
            // 
            this.成绩导入ToolStripMenuItem.Name = "成绩导入ToolStripMenuItem";
            this.成绩导入ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.成绩导入ToolStripMenuItem.Text = "成绩导入";
            this.成绩导入ToolStripMenuItem.Click += new System.EventHandler(this.成绩录入ToolStripMenuItem_Click);
            // 
            // 成绩查询ToolStripMenuItem
            // 
            this.成绩查询ToolStripMenuItem.Name = "成绩查询ToolStripMenuItem";
            this.成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.成绩查询ToolStripMenuItem.Text = "成绩查询";
            this.成绩查询ToolStripMenuItem.Click += new System.EventHandler(this.成绩查询ToolStripMenuItem_Click);
            // 
            // 成绩修改ToolStripMenuItem
            // 
            this.成绩修改ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.输入成绩ToolStripMenuItem,
            this.成绩审核ToolStripMenuItem,
            this.修改成绩ToolStripMenuItem,
            this.删除成绩ToolStripMenuItem});
            this.成绩修改ToolStripMenuItem.Name = "成绩修改ToolStripMenuItem";
            this.成绩修改ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.成绩修改ToolStripMenuItem.Text = "成绩修改";
            // 
            // 输入成绩ToolStripMenuItem
            // 
            this.输入成绩ToolStripMenuItem.Name = "输入成绩ToolStripMenuItem";
            this.输入成绩ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.输入成绩ToolStripMenuItem.Text = "输入成绩";
            this.输入成绩ToolStripMenuItem.Click += new System.EventHandler(this.输入成绩ToolStripMenuItem_Click);
            // 
            // 成绩审核ToolStripMenuItem
            // 
            this.成绩审核ToolStripMenuItem.Name = "成绩审核ToolStripMenuItem";
            this.成绩审核ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.成绩审核ToolStripMenuItem.Text = "成绩审核";
            this.成绩审核ToolStripMenuItem.Click += new System.EventHandler(this.成绩审核ToolStripMenuItem_Click);
            // 
            // 修改成绩ToolStripMenuItem
            // 
            this.修改成绩ToolStripMenuItem.Name = "修改成绩ToolStripMenuItem";
            this.修改成绩ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改成绩ToolStripMenuItem.Text = "修改成绩";
            this.修改成绩ToolStripMenuItem.Click += new System.EventHandler(this.修改成绩ToolStripMenuItem_Click);
            // 
            // 删除成绩ToolStripMenuItem
            // 
            this.删除成绩ToolStripMenuItem.Name = "删除成绩ToolStripMenuItem";
            this.删除成绩ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除成绩ToolStripMenuItem.Text = "删除成绩";
            this.删除成绩ToolStripMenuItem.Click += new System.EventHandler(this.删除成绩ToolStripMenuItem_Click);
            // 
            // 奖学金查询ToolStripMenuItem
            // 
            this.奖学金查询ToolStripMenuItem.Name = "奖学金查询ToolStripMenuItem";
            this.奖学金查询ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.奖学金查询ToolStripMenuItem.Text = "奖学金查询";
            this.奖学金查询ToolStripMenuItem.Click += new System.EventHandler(this.奖学金查询ToolStripMenuItem_Click);
            // 
            // 密码修改ToolStripMenuItem
            // 
            this.密码修改ToolStripMenuItem.Name = "密码修改ToolStripMenuItem";
            this.密码修改ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.密码修改ToolStripMenuItem.Text = "密码修改";
            this.密码修改ToolStripMenuItem.Click += new System.EventHandler(this.密码修改ToolStripMenuItem_Click);
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出登录ToolStripMenuItem.Text = "退出系统";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(7, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(741, 384);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // TeacherMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(755, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeacherMain";
            this.ShowDrawIcon = false;
            this.Text = "教师主界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 成绩导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 密码修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 输入成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 奖学金查询ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem 成绩审核ToolStripMenuItem;
    }
}