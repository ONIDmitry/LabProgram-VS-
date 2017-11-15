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
    public partial class Lab1Steps1 : Form
    {
        public Lab1Steps1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process MyProc = new System.Diagnostics.Process();
            MyProc.StartInfo.FileName = @"C:\Users\user\Desktop\Подсистема имитационного моделирования\Подсистема имитационного моделирования\visualization object editor (сергей капочкин)\visualization backup11\bin\Debug\Visualization.exe";
            MyProc.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Lab1Tittle lb1ttl = new Lab1Tittle();
            lb1ttl.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExTypeRes extres = new ExTypeRes();
            extres.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExRes exres = new ExRes();
            exres.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExOper exopr = new ExOper();
            exopr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process MyProc = new System.Diagnostics.Process();
            MyProc.StartInfo.FileName = @"C:\Users\user\Desktop\Подсистема имитационного моделирования\Подсистема имитационного моделирования\attranslation(иван пиянин + со тиха аунг)\bin\Debug\ATTranslation.exe";
            MyProc.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
            Lab1Steps2 lb1stp2 = new Lab1Steps2();
            lb1stp2.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ExNewOpr exopr = new ExNewOpr();
            exopr.Show();
        }
    }
}
