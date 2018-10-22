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
using System.Text;

namespace Questionnaire
{
    public partial class MainForm : Form
    {
        //git add * git commit -m '...' git push -u origin master
        private List<Question> listeQuestions;
        private int score = 0;
        int verifReponse;
        private int indice = 1;
        private Random r;
        public MainForm()
        {
            InitializeComponent();
            r = new Random();
            listeQuestions = Question.CreateListQuestions();
            listeQuestions = listeQuestions.OrderBy(x => r.Next(0, 5)).ToList();
            labelModifier.Text = listeQuestions[0].Ennonce;
            radBtn_Rep1.Text = listeQuestions[0].Reponses[0];
            radBtn_Rep2.Text = listeQuestions[0].Reponses[1];
            radBtn_Rep3.Text = listeQuestions[0].Reponses[2];
            lbl_Question.Text = "Question "+indice+"/20";
            
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            RadioButton checkedButton = this.Controls.OfType<RadioButton>()
                                     .FirstOrDefault(r => r.Checked);
            labelTest.Text = listeQuestions[indice].ReponseCorrect[0].ToString()+"score: "+score;
            verifReponse =VerifReponse(checkedButton);
            labelTest.Text = listeQuestions[indice].ReponseCorrect[0].ToString() + " score: " + score+" checkedButton: "+checkedButton;
            ReponseCorrecte(verifReponse);
            

            if (indice<=17)
            {
                labelModifier.Text = listeQuestions[indice].Ennonce;
                radBtn_Rep1.Text = listeQuestions[indice].Reponses[0];
                radBtn_Rep2.Text = listeQuestions[indice].Reponses[1];
                radBtn_Rep3.Text = listeQuestions[indice].Reponses[2];
                indice++;
                lbl_Question.Text = "Question " + indice + "/20";
            }
            else
            {
                FinPartie form = new FinPartie();
                form.ShowDialog();
            }
        }

        public int VerifReponse(RadioButton checkedButton)
        {
            if (checkedButton== radBtn_Rep1)
            {
                return 1;
            }
            else if (checkedButton == radBtn_Rep2)
            {
                return 2;
            }
            else if (checkedButton == radBtn_Rep3)
            {
                return 2;
            }
            return 0;
        }
        public void ReponseCorrecte(int verifReponse)
        {
            if(verifReponse == listeQuestions[indice].ReponseCorrect[0])
            {
                score += 1;
            }
        }
    }
}
