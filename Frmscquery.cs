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
    public partial class Frmscquery : Form
    {
        public Frmscquery()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = Sc.SelectSc(this.textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;//标题行编号是-1
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            Sc s = (Sc)row.DataBoundItem;
            try
            {
                if (e.ColumnIndex == 5)
                {
                    if (MessageBox.Show("是否退课", "请确认信息", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                    if (1 == Sc.DeleteSc(s.Cno))
                        MessageBox.Show("退课成功");
                    else MessageBox.Show("没有找到对应课程号的课程");
                }
                else if (e.ColumnIndex == 6)
                {
                    if (MessageBox.Show("是否选课", "请确认信息", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        return;
                    if (1 == Sc.InsertSc(s))
                        MessageBox.Show("选课成功");
                    else MessageBox.Show("没有找到对应课程号的课程");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
