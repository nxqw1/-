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
    public partial class FrmcourseUpdate : Form
    {
        public FrmcourseUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Course c = new Course();
            c.Cno = this.tbcno.Text;
            c.Cname = this.tbcname.Text;
            c.Tno = this.tbtno.Text;
            c.Ccredit = Convert.ToInt32(tbccredit.Text);
            try
            {
                if (1 == Course.UpdateCourse(c))
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else MessageBox.Show("没有找到对应课程号的课程");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
