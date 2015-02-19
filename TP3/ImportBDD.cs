using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace TP3
{
    //Classe qui permet l'import des données contenu dans la base afin qu'elles soit écrit en local (table stock)
    class ImportBDD
    {
        private List<string> resultRequest = new List<string>();
        private List<string> tableName = new List<string>();
        private string uid;
        private string pwd;
        public ImportBDD(string uid, string pwd)
        {
            this.uid = uid;
            this.pwd = pwd;
        }
        string secondtest = "commit";
        public MySqlConnection Imported()
        {
            ManagementBDD connec = new ManagementBDD(uid, pwd);
            MySqlConnection result = connec.connection();
            connec.close();
            return result;
        }
        public void readTableName(string request)    //Méthode qui récupère le nom des colonnes d'une table
        {
            ManagementBDD connec = new ManagementBDD(uid, pwd);
            MySqlDataReader dr = connec.read(request);
            string ligne = null;
            while(dr.Read())
            {
                ligne = ligne + (string)dr.GetValue(0).ToString() + ";  ";
            }
            tableName.Add(ligne);
            connec.close();
        }
        public void readBase(string request)
        {
            ManagementBDD connec = new ManagementBDD(uid, pwd);
            //connec.connection();
            //Lecture de la table avec requete en paramètre
            MySqlDataReader dr = connec.read(request);
            int nbFields =dr.VisibleFieldCount;
            while (dr.Read())
            {
                int i; string ligne=null;
                for (i = 0; i<nbFields;i++)  // Si date lu, elle ne doit pas être à zero sinon bug
                {
                    if(!(dr.IsDBNull(i)))
                    {
                        ligne = ligne + (string)dr.GetValue(i).ToString() + ";  ";
                    }
                }
                resultRequest.Add(ligne);
            }
            connec.close();
        }
        public void createFile(string importType)
        {
            string destFile = System.IO.Path.Combine(@"E:\CESI", "ImportData"+importType+".xml");
            TextWriter file;
            file = new StreamWriter(destFile);
            int i = 1; string write = "";
            int limit = resultRequest.Count;

            //Génération tableau de chaine tableName
            string[] tabNameSplit;
            tabNameSplit = tableName[0].ToString().Split(';');
            int limteTabName = tabNameSplit.Length;
            //Génération tableau de chaine resultRequest
            string[] resultRequestSplit;
            
            
            //Boucle constitution du fichier
            foreach(string list in resultRequest)
            {
                //TO DO indiquer table dans le fichier
                resultRequestSplit = list.Split(';');
                int incColumn = 0;
                write = "<Ligne>" + i ;
                string writeColumn="";
                file.Write(write);
                while (incColumn<(limteTabName-1))//-1 car le dernier élément du tableau est toujours vide à cause du split
                {
                    //Ecriture des données correspondant a une ligne de BDD
                    writeColumn = "\n\t<Colonne>" + tabNameSplit[incColumn]+"\n\t\t<Donnée>" +resultRequestSplit[incColumn]+"</Donnée>\n\t</Colonne>" ;
                    file.Write(writeColumn);
                    incColumn++;
                }
                write="\n</Ligne>\n";
                file.Write(write);
                i++;//Incrémentation pour le nombre de ligne
            }
           tableName.Clear();
           resultRequest.Clear();
           file.Close();
        }
    }
}
