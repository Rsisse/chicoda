using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Questionnaire1
{
    public partial class MainForm : Form
    {
        private List<Question> listeQuestions;
        public int score = 0;
        int reponse=0;
        bool verifReponse;
        private int indice = 0;
        private Random r;
        VisualiseurImage image;
        public MainForm()
        {
            InitializeComponent();
            Menu menu = new Menu();
            this.Hide();
            if(menu.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }

            r = new Random();
            listeQuestions = Question.CreateListQuestions();
            listeQuestions = listeQuestions.OrderBy(x => r.Next(0,10 )).ToList();
            labelModifier.Text = listeQuestions[0].Ennonce;
            radBtn_Rep1.Text = listeQuestions[0].Reponses[0];
            radBtn_Rep2.Text = listeQuestions[0].Reponses[1];
            radBtn_Rep3.Text = listeQuestions[0].Reponses[2];
            
            buttonSuivant.Enabled = false;

            if (listeQuestions[0].LienSiImage != "")
            {
                image = new VisualiseurImage(listeQuestions[indice].LienSiImage);
                image.Show();
            }
            indice++;
            lbl_Question.Text = "Question "+indice+"/20";
            
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            foreach (RadioButton RB in grpBox_1.Controls)
            {
                if (RB.Checked == true)
                {
                    reponse = RB.TabIndex;
                }
            }
            if (indice < 20)
            {
                verifReponse = ReponseCorrecte(reponse);
                if (verifReponse)
                {
                    labelReponse.Text = "Vous avez choisi la bonne réponse";
                    labelReponse.ForeColor = Color.Green;

                }
                else
                {
                    labelReponse.Text = "Mauvaise réponse";
                    labelReponse.ForeColor = Color.Red;
                    labelBonneR.Text = "La bonne réponse est la réponse : " + listeQuestions[indice].ReponseCorrect;
                }
                buttonValider.Enabled = false;
            }
            buttonSuivant.Enabled = true;
        }
        public bool ReponseCorrecte(int verifReponse)
        {
            if (verifReponse.Equals(Convert.ToInt32(listeQuestions[indice-1].ReponseCorrect)))
            {
                score = score + Convert.ToInt32(listeQuestions[indice-1].ReponseCorrect);
                return true;
            }
            //Déterminer les questions qui sont plus difficiles score +=2
            return false;
        }

        private void buttonSuivant_Click(object sender, EventArgs e)
        {
            VisualiseurImage f = Application.OpenForms.OfType<VisualiseurImage>().FirstOrDefault();
            if (f != null)
                f.Close();
           
            labelBonneR.Text = "";
            labelReponse.Text = "";

            if (indice < 20)
            {
                
                labelModifier.Text = listeQuestions[indice].Ennonce;
                radBtn_Rep1.Text = listeQuestions[indice].Reponses[0];
                radBtn_Rep2.Text = listeQuestions[indice].Reponses[1];
                radBtn_Rep3.Text = listeQuestions[indice].Reponses[2];

                if (listeQuestions[indice].LienSiImage != "")
                {
                    image = new VisualiseurImage(listeQuestions[indice].LienSiImage);
                    image.Show();
                }

                indice++;
                lbl_Question.Text = "Question " + indice + "/20";
                buttonValider.Enabled = true;
                buttonSuivant.Enabled = false;
            }

            else
            {
                this.Hide();
                Pluscourtchemin.DjikstraForm form = new Pluscourtchemin.DjikstraForm(score);
                if(form.ShowDialog() == DialogResult.OK)
                {
                    FinPartie formFin = new FinPartie(Pluscourtchemin.DjikstraForm.score);
                    formFin.Show();
                }
            }
        }
    }
}
