using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
namespace WindowsFormsApp2
{
    public partial class Frmlogin : Form
    {
        public static string loginName = null;
        public static bool login;
        public Frmlogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//学生登录
        {
            string username = tbusername.Text;
            string pwd = tbpwd.Text;
            string sql = "select * from student where sno=:sno and spwd=:spwd";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":sno",OracleDbType.Varchar2,15),
                new OracleParameter(":spwd",OracleDbType.Varchar2,20),
            };
            para[0].Value = username;
            para[1].Value = pwd;
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                OracleDataReader odr = cmd.ExecuteReader();
                if (odr.Read())
                {
                    loginName = odr.GetString(0);
                    login = false;
                    this.DialogResult = DialogResult.OK;
                }
                else MessageBox.Show("用户名或密码错误");
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

        private void button2_Click(object sender, EventArgs e)//管理员登录
        {
            string username = tbusername.Text;
            string pwd = tbpwd.Text;
            string sql = "select * from admintor where aname=:aname and apwd=:apwd";
            OracleParameter[] para = new OracleParameter[]
            {
                new OracleParameter(":aname",OracleDbType.Varchar2,15),
                new OracleParameter(":apwd",OracleDbType.Varchar2,20),
            };
            para[0].Value = username;
            para[1].Value = pwd;
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                cmd.Parameters.AddRange(para);
                OracleDataReader odr = cmd.ExecuteReader();
                if (odr.Read())
                {
                    loginName = odr.GetString(0);
                    login = true;
                    this.DialogResult = DialogResult.OK;
                }
                else MessageBox.Show("用户名或密码错误");
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
