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
    public partial class Frmteacherquery : Form
    {
        public Frmteacherquery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("select tno,tname,tsalary,tprofession from teacher where tname like '{0}%'", textBox1.Text);
            OracleConnection con = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));User Id=C##D;Password=123456");
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
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
            if (dataGridView1.SelectedRows.Count == 0) return;
            if (MessageBox.Show("是否删除数据", "请确认信息", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string tno = row.Cells[0].Value.ToString();
            string sql = string.Format("delete from teacher where tno ='{0}'", tno);
            OracleConnection con = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));User Id=C##D;Password=123456");
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                if (1 == cmd.ExecuteNonQuery())
                {
                    MessageBox.Show("删除成功");
                    dataGridView1.Rows.Remove(row);
                }
                else
                    MessageBox.Show("没有找到对应课程号的老师");
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0) return;
            FrmteacherUpdate frm = new FrmteacherUpdate();
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            frm.tbtno.Text = row.Cells[0].Value.ToString();
            frm.tbtname.Text = row.Cells[1].Value.ToString();
            frm.tbtsalary.Text = row.Cells[2].Value.ToString();
            frm.tbtprofession.Text = row.Cells[3].Value.ToString();
            frm.ShowDialog(this);
        }
    }
}
