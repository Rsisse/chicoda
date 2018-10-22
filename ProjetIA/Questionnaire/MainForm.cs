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
        private List<Question> listeQuestions;
        private List<int> ListeIndex;
        private Random r;
        public MainForm()
        {
            InitializeComponent();
            listeQuestions = Question.CreateListQuestions();
            r = new Random();
            for(int i=0;i<20;i++)
            {
                int rand = r.Next(0, 20);
                
            }
           
            
        }
}
}
