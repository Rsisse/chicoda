using System;
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
        static public bool erreur1 = false;
        static public bool erreur2 = false;
        static public int score;
        static public int indice = 0;
        public DjikstraForm(int pScore)
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
            score = pScore;
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
            lbl_InfoReponse.Text = "Bonne réponse";
            lbl_InfoReponse.ForeColor = Color.Green;
            if (!CheckString(O, F))
            {
                erreur1 = true;
                lbl_InfoReponse.Text = "Mauvaise réponse";
                lbl_InfoReponse.ForeColor = Color.Red;
            }

            lbl_O.Text = "O{" + O + "}";
            lbl_F.Text = "F{" + F + "}";

            N0 = (Node2)dblNode.L_Ouverts[0];
           
            if (N0.numero == numfinal)
            {
                if (txtBox_Open.Text == "Fin")
                {
                    lbl_InfoReponse.Text = "Bonne réponse";
                    lbl_InfoReponse.ForeColor = Color.Green;
                }
                F += numfinal;
                lbl_F.Text = "F{" + F + "}";
                lbl_O.Text = "Fin";
                btn_End.Visible = true;
                btn_Next.Visible = false;
            }
            txtBox_Closed.Text = "";

            txtBox_Open.Text = "";

        }

        private bool CheckString(string noeudsO,string noeudsF)
        {
            noeudsO = String.Concat(noeudsO.OrderBy(c => c));
            noeudsF = String.Concat(noeudsF.OrderBy(c => c));

            string nO = txtBox_Open.Text;
            string nF = txtBox_Closed.Text;
            
            
            nO=String.Concat(nO.OrderBy(c => c));
            nF=String.Concat(nF.OrderBy(c => c));

            if (nO.Equals(noeudsO) && nF.Equals(noeudsF)) return true;
            return false;
        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            if (!erreur1) score += 2;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
            fillTree();
        }


        private void fillTree()
        {
            g.GetSearchTree(treeView1);
            labelReponseTree.Text = "";
            labelNoeud.Text = "N" + (indice + 1);
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            
            if (textBoxEntrerNoeud.Text == g.listBonNoeuds[indice])
            {
                labelReponseTree.Text = "Bonne réponse";
                labelReponseTree.ForeColor = Color.Green;
            }
            else
            {
                labelReponseTree.Text = "Mauvaise réponse, la bonne réponse était:"+g.listBonNoeuds[indice];
                labelReponseTree.ForeColor = Color.Red;
                erreur2 = true;
            }
            historiqueNoeudsTree.Text += ("N"+(indice+1)+"=" +g.listBonNoeuds[indice]+"\n");
            textBoxEntrerNoeud.Text = "";
            indice++;
            labelNoeud.Text = "N" + (indice + 1);

            if (g.listBonNoeuds.Count == indice)
            {
                label4.Visible = false;
                textBoxEntrerNoeud.Visible = false;
                labelNoeud.Visible = false;
                btnEndTree.Visible = true;
                btn_End.Visible = false;
            }
            
        }

        private void btnEndTree_Click(object sender, EventArgs e)
        {
            if (!erreur2) score += 1;
            this.Close();
        }
    }
}
