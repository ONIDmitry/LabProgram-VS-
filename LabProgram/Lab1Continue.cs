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
    public partial class Lab1Continue : Form
    {
        public Lab1Continue()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Lab1Tittle lb1ttl = new Lab1Tittle();
            lb1ttl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Lab1Last lb1lst = new Lab1Last();
            lb1lst.Show();
        }
    }
}
