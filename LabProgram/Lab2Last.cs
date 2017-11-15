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
    public partial class Lab2Last : Form
    {
        public Lab2Last()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Lab2Continue lb1cnt = new Lab2Continue();
            lb1cnt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab2Steps1 lb2st = new Lab2Steps1();
            lb2st.Show();
        }
    }
}
