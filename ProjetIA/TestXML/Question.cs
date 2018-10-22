using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TestXML
{
    class Question
    {
        private string Ennonce { get; set; }
        private List<string> Reponses { get; set; }

        private string ReponseCorrect { get; set; }

        public Question(): this("",new List<string>(),"") { }
  
        public Question(string ennonce,List<string> reponses,string reponseCorrect)
        {
            this.Ennonce = ennonce;
            this.Reponses = reponses;
            this.ReponseCorrect = reponseCorrect;
        }

        public void AjouterReponse(string reponse)
        {
            this.Reponses.Add(reponse);
        }

        public override string ToString()
        {
            string reponses = "";
            foreach (var item in Reponses)
            {
                reponses += "-"+item +"\n";
            }
            return "Ennoncé: " + Ennonce + "\nLes réponses:\n" + reponses + "Numéro bonne réponse:\n" + ReponseCorrect;
        }

        public static List<Question> CreateListQuestions()
        {
            List<Question> list = new List<Question>();
            var xml = XDocument.Load("Questions.Xml");
            for (int numQuest = 1; numQuest < 19; numQuest++)
            {
                var query = from c in xml.Root.Descendants("Question")
                            where (int)c.Attribute("numQuest") == numQuest
                            select c.Element("ennonce").Value + "." + c.Element("reponse1").Value + "." + c.Element("reponse2").Value + "." + c.Element("reponse3").Value + "." + c.Element("correct").Value;

                foreach (string name in query)
                {
                    int courant = 0;
                    int nbrPoint = 0;
                    string ennonce = "";
                    string reponseCorrect = "";
                    List<string> reponses = new List<string>();
                    for (int i = 0; i < name.Length; i++)
                    {
                        if ((name[i] == '.') && nbrPoint == 0)
                        {
                            ennonce = name.Substring(0, i);
                            nbrPoint++;
                            string reponse = "";
                            do
                            {
                                i++;
                                reponse += name[i].ToString();
                            } while (name[i + 1] != '.');
                            reponses.Add(reponse);
                            courant = i;
                        }
                        else if ((name[i] == '.') && (nbrPoint == 3))
                        {
                            reponseCorrect = name[i + 1].ToString();
                        }
                        else if (name[i] == '.')
                        {
                            string reponse = "";
                            do
                            {
                                i++;
                                reponse += name[i].ToString();
                            } while (name[i + 1] != '.');
                            reponses.Add(reponse);
                            nbrPoint++;
                        }
                    }
                    list.Add(new Question(ennonce, reponses, reponseCorrect));
                }
            }

            return list;
        }
    }
}
