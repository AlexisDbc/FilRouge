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
            int i; int j;
            dGVFournisseur.ColumnCount = tab.GetLength(1);
            for (i = 0; i < tab.GetLength(0); i++)
            {
                string[] row = new string[tab.GetLength(1)];
                for (j = 0; j < tab.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        dGVFournisseur.Columns[j].Name = tab[i, j];
                    }
                    row[j] = tab[i, j];
                }
                dGVFournisseur.Rows.Add(row);
            }
        }
        
    }
}
