using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimjenaWindovsKontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RunProgram_Click(object sender, EventArgs e)
            
        {
            if (comboBox1.Text == "Notepad")
                System.Diagnostics.Process.Start(@"C:\Windows\System32\notepad.exe");
            else
                System.Diagnostics.Process.Start(@"C:\Windows\System32\mspaint.exe");
           

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.AutoCheck = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
