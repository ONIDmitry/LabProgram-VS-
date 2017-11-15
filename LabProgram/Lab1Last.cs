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
    public partial class Lab1Last : Form
    {
        public Lab1Last()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Lab1Continue lb1cnt = new Lab1Continue();
            lb1cnt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Lab1Steps1 lb1stp1 = new Lab1Steps1();
            lb1stp1.Show();
        }
    }
}
