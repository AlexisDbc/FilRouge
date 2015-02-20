using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class Home : Form
    {
        string userName;
        public Home(string userName)
        {
            InitializeComponent();
            this.userName = userName;
            label1.Text = "Bienvenu "+userName;

            XmlFileRead test = new XmlFileRead();
            test.read();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
    }
}
