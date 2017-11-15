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
    public partial class Lab3Continue : Form
    {
        public Lab3Continue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab3Tittl lb3t = new Lab3Tittl();
            lb3t.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab3Steps1 lb3s = new Lab3Steps1();
            lb3s.Show();
            Close();
        }
    }
}
