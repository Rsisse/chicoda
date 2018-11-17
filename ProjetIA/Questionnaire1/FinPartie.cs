using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire1
{
    public partial class FinPartie : Form
    {
        private double score;
        public FinPartie(double scoreini)
        {
            this.score = scoreini*21/25;
            InitializeComponent();
            labelScore.Text = score.ToString() + "/25" ;
        }

        private void buttonRecommencer_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            
                Application.Exit();
            
        }
    }
}
