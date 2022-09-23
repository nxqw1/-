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
    public partial class FrmteacherUpdate : Form
    {
        public FrmteacherUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("Update teacher set tname='{0}',tsalary='{1}',tprofession='{2}' where tno='{3}'",
                tbtname.Text, tbtsalary.Text, tbtprofession.Text, tbtno.Text);
            OracleConnection con = new OracleConnection(Program.strCon);
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                if (1 == cmd.ExecuteNonQuery())
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                    MessageBox.Show("没有找到对应教工号的教师");
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
