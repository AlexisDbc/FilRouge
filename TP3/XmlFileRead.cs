using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace TP3
{
    class XmlFileRead
    {

        public XmlFileRead()
        {

        }

        public void read() //string pathFile
        {
            int j = 0 ;              //Nb Colonne
            string fileText = File.ReadAllText(@"E:\CESI\ImportDatat_fournisseur.xml", System.Text.Encoding.UTF8);   //Emplacement du fichier et lecture
            XmlDocument unxml = new XmlDocument();                                               
            unxml.LoadXml(fileText);                        //Ouverture du document au format XML
            XmlNode root = unxml.DocumentElement;           //Récupération du noeud principal 
            List<string> test = new List<string>();         //Liste tempo

            XmlNode table = unxml.SelectSingleNode("Table");                
            XmlNodeList lignes = table.SelectNodes("Ligne");
            foreach (XmlNode noeud in lignes)
            {
                XmlNode ligne = noeud;
                j = 0;
                foreach (XmlNode noeudEnfant in ligne)
                {
                    j++;
                    test.Add(noeudEnfant.InnerText);   
                                         
                }
            }
            string[,] tab = new string[lignes.Count, j];  //Tableau contenant la table
            int tempoI=0; int tempoJ =0;
            foreach (string s in test)
            {
                tab[tempoI, tempoJ] = s;
                tempoJ++;
                if (tempoJ == 12) { tempoI++; tempoJ = 0; }
            }
        }
    }
}
