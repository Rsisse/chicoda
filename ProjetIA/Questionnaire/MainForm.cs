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
        Dictionary<string, List<string>> dico;
        public MainForm()
        {
            InitializeComponent();
            dico = new Dictionary<string, List<string>>();
            InitLabel();
        }

        private void InitLabel()
        {
            XmlTextReader reader = new XmlTextReader("Questions.xml");
            int count = 0;
            while (reader.Read() && count!=1)
            { 
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.

                        while (reader.MoveToNextAttribute()) // Read the attributes.
                            Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        lbl_Question.Text = reader.Value;
                        count++;

                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.

                        break;
                }
        }
        }
    



    




}
}
