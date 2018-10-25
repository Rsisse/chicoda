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


namespace Questionnaire
{
    public partial class MainForm : Form
    {
        //git add * git commit -m '...' git push -u origin master
        private List<Question> listeQuestions;
        public int score = 0;
        int verifReponse=0;
        private int indice = 0;
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
            labelTest.Text = listeQuestions[indice].ReponseCorrect[0].ToString() + " score: " + score + " checkedButton: " + verifReponse;
            lbl_Question.Text = "Question "+indice+"/20";
            
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            
            foreach (RadioButton RB in grpBox_1.Controls)
            {
                if (RB.Checked == true)
                {
                    verifReponse = RB.TabIndex;
                }
            }
            ReponseCorrecte(verifReponse);

            if (indice<17)
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
                FinPartie form = new FinPartie(score);
                
                if (form.ShowDialog() == DialogResult.OK)
                {
                    form.Close();
                    Application.Restart();
                    
                }
                else
                {
                    Application.Exit();
                } 

            }
        }
        public void ReponseCorrecte(int verifReponse)
        {
          //labelTest.Text = "Reponse correcte: " + listeQuestions[indice].ReponseCorrect[0] + " score: " + score + " checkedButton: " + verifReponse;
           
            if (verifReponse.Equals(Convert.ToInt32(listeQuestions[indice].ReponseCorrect)))
            {
                score += 1;
            }
            //Déterminer les questions qui sont plus difficiles score +=2
        }
    }
}
