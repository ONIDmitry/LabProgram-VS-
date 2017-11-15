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
    public partial class Lab1Tittle : Form
    {
        public Lab1Tittle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Lab1Continue lb1cnt = new Lab1Continue();
            lb1cnt.Show();
        }
    }
}
