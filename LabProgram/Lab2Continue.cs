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
    public partial class Lab2Continue : Form
    {
        public Lab2Continue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Lab2Tittle lb1cnt = new Lab2Tittle();
            lb1cnt.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Lab2Last lb1cnt = new Lab2Last();
            lb1cnt.Show();
        }
    }
}
