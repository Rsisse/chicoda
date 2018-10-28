using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Questionnaire1
{
    public partial class VisualiseurImage : Form
    {
        public VisualiseurImage(string lienImage)
        {
            InitializeComponent();
            //  pictureBox_ImageQuestion.Image = Image.FromFile(@"Images\a.bmp");
            
            Image img = Image.FromFile(lienImage);
            this.Size = img.Size;
            pictureBox_ImageQuestion.Size = img.Size;
            pictureBox_ImageQuestion.Image = img;
            

        }
    }
}
