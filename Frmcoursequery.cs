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
    public partial class Frmcoursequery : Form
    {
        public Frmcoursequery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = Course.SelectCourse(this.textBox1.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(e.RowIndex.ToString() + "," + e.ColumnIndex.ToString());
            if (e.RowIndex < 0) return;//标题行编号是-1
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Course c = (Course)row.DataBoundItem;
            try
            {
                if (e.ColumnIndex == 4)
                {
                    if (MessageBox.Show("是否删除数据", "请确认信息",MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                    if (1 == Course.DeleteCourse(c.Cno))
                        MessageBox.Show("删除成功");
                    else MessageBox.Show("没有找到对应课程号的课程");
                }
                else if (e.ColumnIndex == 5)
                {
                    FrmcourseUpdate frm = new FrmcourseUpdate();
                    frm.tbcno.Text = c.Cno;
                    frm.tbcname.Text = c.Cname;
                    frm.tbtno.Text = c.Tno;
                    frm.tbccredit.Text = c.Ccredit.ToString();
                    frm.ShowDialog(this);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
