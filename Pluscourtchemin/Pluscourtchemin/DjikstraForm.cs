﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pluscourtchemin;
using System.IO;

namespace Pluscourtchemin
{
    public partial class DjikstraForm : Form
    {
        static public double[,] matrice;
        static public int nbnodes = 10;
        static public int numinitial;
        static public int numfinal;
        static public string F;
        static public string O;
        static public SearchTree g;
        static public Node2 N0;
        public DjikstraForm()
        {
            InitializeComponent();
            InitGraph();
            F = "";
            O = "0";
            lbl_F.Text = "F{" + F + "}";
            lbl_O.Text = "O{" + O + "}";
            numinitial = 0;
            numfinal = 4;
            g = new SearchTree();
            N0 = new Node2();
            N0.numero = numinitial;
            g.L_Ouverts.Add(N0);
        }

        public void InitGraph()
        {
            StreamReader monStreamReader = new StreamReader("graphe2.txt");

            // Lecture du fichier avec un while, évidemment !
            // 1ère ligne : "nombre de noeuds du graphe
            string ligne = monStreamReader.ReadLine();
            int i = 0;
            while (ligne[i] != ':') i++;
            string strnbnoeuds = "";
            i++; // On dépasse le ":"
            while (ligne[i] == ' ') i++; // on saute les blancs éventuels
            while (i < ligne.Length)
            {
                strnbnoeuds = strnbnoeuds + ligne[i];
                i++;
            }
            nbnodes = Convert.ToInt32(strnbnoeuds);

            matrice = new double[nbnodes, nbnodes];
            for (i = 0; i < nbnodes; i++)
                for (int j = 0; j < nbnodes; j++)
                    matrice[i, j] = -1;

            // Ensuite on a ls tructure suivante : 
            //  arc : n°noeud départ    n°noeud arrivée  valeur
            //  exemple 4 : 
            ligne = monStreamReader.ReadLine();
            while (ligne != null)
            {
                i = 0;
                while (ligne[i] != ':') i++;
                i++; // on passe le :
                while (ligne[i] == ' ') i++; // on saute les blancs éventuels
                string strN1 = "";
                while (ligne[i] != ' ')
                {
                    strN1 = strN1 + ligne[i];
                    i++;
                }
                int N1 = Convert.ToInt32(strN1);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strN2 = "";
                while (ligne[i] != ' ')
                {
                    strN2 = strN2 + ligne[i];
                    i++;
                }
                int N2 = Convert.ToInt32(strN2);

                // On saute les blancs éventuels
                while (ligne[i] == ' ') i++;
                string strVal = "";
                while ((i < ligne.Length) && (ligne[i] != ' '))
                {
                    strVal = strVal + ligne[i];
                    i++;
                }
                double val = Convert.ToDouble(strVal);

                matrice[N1, N2] = val;
                matrice[N2, N1] = val;
                listBoxgraphe.Items.Add(Convert.ToString(N1)
                   + "--->" + Convert.ToString(N2)
                   + "   : " + Convert.ToString(matrice[N1, N2]));

                ligne = monStreamReader.ReadLine();
            }
            // Fermeture du StreamReader (obligatoire) 
            monStreamReader.Close();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            DoubleNode dblNode = g.RechercheNoeudsIntermediaire(N0);
           // lbl_O.Text = "";
         //   lbl_F.Text = "";
            F = "";
            O = "";
            foreach (var item in dblNode.L_Fermes)
            {
                Node2 nF = (Node2)item;
                F += nF.numero.ToString();  
            }
            
            foreach (var item in dblNode.L_Ouverts)
            {
                Node2 nO = (Node2)item;
                O += nO.numero.ToString();     
            }
            if (CheckString(O, F)) // F{0} O {132}
            {
            }
            lbl_O.Text = "O{" + O + "}";
            lbl_F.Text = "F{" + F + "}";
            N0 = (Node2)dblNode.L_Ouverts[0];
            txtBox_Closed.Text = "";
            txtBox_Open.Text = "";


        }

        private bool CheckString(string noeudsO,string noeudsF)
        {
            if ((txtBox_Closed.Text == noeudsF) && (txtBox_Open.Text == noeudsO)) return true;
            return false;
        }
    }
}
