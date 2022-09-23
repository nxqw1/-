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
    public partial class Frmstuquery : Form
    {
        public Frmstuquery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string sql = "select sno,sname,ssex,sage,sdept from student where sname like '" 
            //+ this.textBox1.Text+"%'";
            string sql = string.Format("select sno,sname,ssex,sage,sdept from student where sname like '{0}%'", textBox1.Text);
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
            string sno = row.Cells[0].Value.ToString();
            string sql = string.Format("delete from student where sno ='{0}'", sno);
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            FrmstuUpdate frm = new FrmstuUpdate();
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            frm.tbsno.Text = row.Cells[0].Value.ToString();
            frm.tbsname.Text = row.Cells[1].Value.ToString();
            frm.tbssex.Text = row.Cells[2].Value.ToString();
            frm.tbsage.Text = row.Cells[3].Value.ToString();
            frm.tbsdept.Text = row.Cells[4].Value.ToString();
            frm.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            if (MessageBox.Show("是否重置密码", "请确认信息", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            string sno = row.Cells[0].Value.ToString();
            string sql = string.Format("Update student set spwd='123456' where sno ='{0}'", sno);
            OracleConnection con = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=127.0.0.1)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=XE)));User Id=C##D;Password=123456");
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand(sql, con);
                if (1 == cmd.ExecuteNonQuery())
                {
                    MessageBox.Show("重置成功");
                    dataGridView1.Rows.Remove(row);
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
