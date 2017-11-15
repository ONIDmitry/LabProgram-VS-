using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProgram
{
    public partial class Lab2Steps1 : Form
    {
        public Lab2Steps1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExObjTemp exobj = new ExObjTemp();
            exobj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab2Last lb2l = new Lab2Last();
            lb2l.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExEvent exe = new ExEvent();
            exe.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExInt exe1 = new ExInt();
            exe1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExTempRule ext = new ExTempRule();
            ext.Show();
        }
    }
}
