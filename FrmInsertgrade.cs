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
    public partial class FrmInsertgrade : Form
    {
        public FrmInsertgrade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = Insertgrade.SelectInsertgrade(this.textBox1.Text);
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
            Insertgrade c = (Insertgrade)row.DataBoundItem;
            try
            {
                if (e.ColumnIndex == 6)
                {
                    FrmInsertgradeInsert frm = new FrmInsertgradeInsert();
                    frm.tbsno.Text = c.Sno;
                    frm.tbsname.Text = c.Sname;
                    frm.tbcno.Text = c.Cno;
                    frm.tbcname.Text = c.Cname;
                    frm.tbgrade.Text = c.Grade;
                    frm.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
