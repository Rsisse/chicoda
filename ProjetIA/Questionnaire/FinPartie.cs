using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire
{
    public partial class FinPartie : Form
    {
        private int score;
        public FinPartie(int score)
        {
            this.score = score;
            InitializeComponent();
            labelScore.Text = score.ToString();
        }

        private void buttonRecommencer_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
