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
    public partial class FrmcourseInsert : Form
    {
        public FrmcourseInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Cno = tbcno.Text;
            c.Cname = tbcname.Text;
            c.Tno = tbtno.Text;
            c.Ccredit = Convert.ToInt32(tbccredit.Text);
            try
            {
                Course.InsertCourse(c);
                MessageBox.Show("插入成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
