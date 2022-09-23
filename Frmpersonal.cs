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
    public partial class Frmpersonal : Form
    {
        public Frmpersonal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Frmlogin.login)
            {
                string sql = "update admintor set aname=:aname,asex=:asex,aage=:aage,apwd=:apwd where ano=:ano";
                OracleParameter[] para = new OracleParameter[]
                {
                    new OracleParameter(":aname",OracleDbType.Varchar2,20),
                    new OracleParameter(":asex",OracleDbType.Varchar2,3),
                    new OracleParameter(":aage",OracleDbType.Varchar2,20),
                    new OracleParameter(":apwd",OracleDbType.Varchar2,10),
                    new OracleParameter(":ano",OracleDbType.Varchar2,15),
                };
                para[0].Value = this.tbname.Text;
                para[1].Value = this.tbsex.Text;
                para[2].Value = this.tbage.Text;
                para[3].Value = this.tbpwd.Text;
                para[4].Value = Frmlogin.loginName;
                OracleConnection con = new OracleConnection(Program.strCon);
                try
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand(sql, con);
                    cmd.Parameters.AddRange(para);
                    cmd.ExecuteNonQuery();
                    
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
            else
            {
                string sql = "update student set sname=:sname,ssex=:ssex,sage=:sage,spwd=:spwd where sno=:sno";
                OracleParameter[] para = new OracleParameter[]
                {
                    new OracleParameter(":sname",OracleDbType.Varchar2,20),
                    new OracleParameter(":ssex",OracleDbType.Varchar2,3),
                    new OracleParameter(":sage",OracleDbType.Varchar2,20),
                    new OracleParameter(":spwd",OracleDbType.Varchar2,10),
                    new OracleParameter(":sno",OracleDbType.Varchar2,15),
                };
                para[0].Value = this.tbname.Text;
                para[1].Value = this.tbsex.Text;
                para[2].Value = this.tbage.Text;
                para[3].Value = this.tbpwd.Text;
                para[4].Value = Frmlogin.loginName;
                OracleConnection con = new OracleConnection(Program.strCon);
                try
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand(sql, con);
                    cmd.Parameters.AddRange(para);
                    cmd.ExecuteNonQuery();

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
