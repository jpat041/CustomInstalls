using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace CDBrowser001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void pbAdobe_Click(object sender, EventArgs e)
        {
            Process.Start("https://get.adobe.com/reader/");
          
        }

       

        private void pbGoogle_Click(object sender, EventArgs e)
        {

            Process.Start("https://www.google.com/chrome/browser/desktop/index.html");
        }

        private void pbStratTrader_Click(object sender, EventArgs e)
        {
            Process.Start(".\\Setup\\setup.exe");
        }

        private void pbIE_Click(object sender, EventArgs e)
        {
            Process.Start(".\\Installs\\EIE11_EN-US_WOL_WIN764.EXE");
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblStratTrader_Click(object sender, EventArgs e)
        {
            //Process.Start("Setup\\setup.exe");
            Process.Start("C:\\Users\\Patrick\\Documents\\Visual Studio 2013\\Projects\\CDBrowser001\\CDBrowser001\\Setup\\setup.exe");
        }

        private void lblIE_Click(object sender, EventArgs e)
        {
            //Process.Start("Installs\\EIE11_EN-US_WOL_WIN764.EXE");
            Process.Start("C:\\Users\\Patrick\\Documents\\Visual Studio 2013\\Projects\\CDBrowser001\\CDBrowser001\\Installs\\EIE11_EN-US_WOL_WIN764.EXE");
        }

        private void lblGoogle_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/chrome/browser/desktop/index.html");
        }

        private void lblAdobe_Click(object sender, EventArgs e)
        {
            Process.Start("https://get.adobe.com/reader/");
        }

        
    }
}
