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
    public partial class FrmstuUpdate : Form
    {
        public FrmstuUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("Update student set sname='{0}',ssex='{1}',sage='{2}',sdept='{3}' where sno='{4}'",
                tbsname.Text, tbssex.Text, tbsage.Text, tbsdept.Text, tbsno.Text);
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
                    MessageBox.Show("没有找到对应学号的学生");
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
