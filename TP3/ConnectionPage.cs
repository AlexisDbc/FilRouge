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
    public partial class ConnectionPage : Form
    {
        enum Table
        {
            t_commandefour,
            t_article, 
            t_catalogue, 
            t_fournisseur,
            t_matierespremieres, 
            t_etatlivraison,
        }
        public ConnectionPage()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //En reflexion (fonctionne)
            Security pwd = new Security();
            string hashMD5 = pwd.ConvertMD5(tBpwd.Text);
            //
            ImportBDD import = new ImportBDD(tBuser.Text, tBpwd.Text);
            if (null != import.Imported())
            {
                MessageBox.Show("Connexion Réussie!");
                //Requete à modifier lors de la mise en commun
                foreach(Table enu in Enum.GetValues(typeof(Table)))
                {
                    import.readTableName("SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='" + enu.ToString() + "'");
                    import.readBase("SELECT * FROM plastprod."+enu.ToString());
                    import.createFile(enu.ToString());
                }
                ActiveForm.Hide();
                Home h = new Home(tBuser.Text);
                h.Show();  
            }
            else
            {
                MessageBox.Show("Echec de la connexion");
            }
        }
    }
}
