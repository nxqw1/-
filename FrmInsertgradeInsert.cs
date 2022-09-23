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
    public partial class FrmInsertgradeInsert : Form
    {
        public FrmInsertgradeInsert()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insertgrade c = new Insertgrade();
            c.Sno = tbsno.Text;
            c.Cno = tbcno.Text;
            c.Grade = tbgrade.Text;
            try
            {
                if (1 == Insertgrade.InsertInsertgrade(c))
                {
                    MessageBox.Show("录入成功");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
