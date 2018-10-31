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
            Image img = Image.FromFile(lienImage);
            Size tailleImage = img.Size;
            tailleImage.Height += 40;
            tailleImage.Width += 10;
            this.Size = tailleImage;
            pictureBox_ImageQuestion.Size = img.Size;
            pictureBox_ImageQuestion.Image = img;
        }
    }
}
