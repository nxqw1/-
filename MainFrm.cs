using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainFrm : Form
    {
        //bool login;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void 查询学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmstuquery frm = new Frmstuquery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 添加学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmstuInsert frm = new FrmstuInsert();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 查询课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmcoursequery frm = new Frmcoursequery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmcourseInsert frm = new FrmcourseInsert();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmstatistics frm = new Frmstatistics();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 查询教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmteacherquery frm = new Frmteacherquery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 添加教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmteacherInsert frm = new FrmteacherInsert();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 查询已选课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmscquery frm = new Frmscquery();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            //this.Text = "学生信息管理系统，当前登录的用户名为：" + Frmlogin.loginName;
            if(Frmlogin.login)
            {
                选课中心ToolStripMenuItem.Visible = false;
                统计所选课程及学分ToolStripMenuItem.Visible = false;
                this.Text = "学生信息管理系统，当前登录的用户为：" + Frmlogin.loginName;
            }
            else
            {
                学生管理ToolStripMenuItem.Visible = false;
                课程管理ToolStripMenuItem.Visible = false;
                教师管理ToolStripMenuItem.Visible = false;
                统计信息ToolStripMenuItem.Visible = false;
                成绩录入ToolStripMenuItem.Visible = false;
                this.Text = "学生个人信息系统，当前登录的用户名为：" + Frmlogin.loginName;
            }
        }

        private void 查询各人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmpersonal frm = new Frmpersonal();
            frm.MdiParent = this;
            frm.Show();
            if(Frmlogin.login)
            {
                string sql = "select * from admintor where ano=:ano";
                OracleParameter[] para = new OracleParameter[]
                {
                    new OracleParameter(":ano",OracleDbType.Varchar2,15),
                };
                para[0].Value = Frmlogin.loginName;
                OracleConnection con = new OracleConnection(Program.strCon);
                try
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand(sql, con);
                    cmd.Parameters.AddRange(para);
                    OracleDataReader odr = cmd.ExecuteReader();
                    while(odr.Read())
                    {
                        frm.tbno.Text = odr.GetString(0);
                        frm.tbname.Text = odr.GetString(1);
                        frm.tbsex.Text = odr.GetString(2);
                        frm.tbage.Text = odr.GetString(3);
                        frm.tbpwd.Text = odr.GetString(4);

                    }
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                string sql = "select * from student where sno=:sno";
                OracleParameter[] para = new OracleParameter[]
                {
                    new OracleParameter(":sno",OracleDbType.Varchar2,15),
                };
                para[0].Value = Frmlogin.loginName;
                OracleConnection con = new OracleConnection(Program.strCon);
                try
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand(sql, con);
                    cmd.Parameters.AddRange(para);
                    OracleDataReader odr = cmd.ExecuteReader();
                    while (odr.Read())
                    {
                        frm.tbno.Text = odr.GetString(0);
                        frm.tbname.Text = odr.GetString(1);
                        frm.tbsex.Text = odr.GetString(2);
                        frm.tbage.Text = odr.GetString(3);
                        frm.tbpwd.Text = odr.GetString(5);

                    }
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void 统计ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frmstatistics1 frm = new Frmstatistics1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void 查询及录入成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInsertgrade frm = new FrmInsertgrade();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
