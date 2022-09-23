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
    public partial class Frmstatistics1 : Form
    {
        public Frmstatistics1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select student.sno,student.sname,sc.cno,course.cname,sc.grade from sc,course,student where student.sno=:sno and course.cno=sc.cno and student.sno=sc.sno";
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
                if (odr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = odr;
                    dataGridView1.DataSource = bs;
                }
                else dataGridView1.DataSource = null;
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

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "select sum(ccredit)获得的总学分 from student,course,sc where course.cno=sc.cno and sc.sno=student.sno and grade>=60 and student.sno=:sno";
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
                if (odr.HasRows)
                {
                    BindingSource bs = new BindingSource();
                    bs.DataSource = odr;
                    dataGridView1.DataSource = bs;
                }
                else dataGridView1.DataSource = null;
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
