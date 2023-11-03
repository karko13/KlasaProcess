using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlassaPorcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("IExplore.exe");
            ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");

            startInfo.WindowStyle = ProcessWindowStyle.Normal;
            startInfo.Arguments = "www.sser.hr";
            Process.Start(startInfo);
        }
    }
}
