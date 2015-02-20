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
            remplirDataGrid();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void remplirDataGrid()
        {
            XmlFileRead tabFournisseur = new XmlFileRead();
            string[,] tab = tabFournisseur.read("t_fournisseur");

            
            
        }
        
    }
}
