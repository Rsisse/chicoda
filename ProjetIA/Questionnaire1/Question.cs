﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Questionnaire1
{
    class Question
    {
        public string Ennonce { get; private set; }
        public List<string> Reponses { get; private set; }

        public string ReponseCorrect { get; private set; }

        public string LienSiImage { get; private set; }

        public Question(): this("",new List<string>(),"","") { }


        public Question(string ennonce,List<string> reponses,string reponseCorrect,string lienSiImage)
        {
            this.Ennonce = ennonce;
            this.Reponses = reponses;
            this.ReponseCorrect = reponseCorrect;
            this.LienSiImage = lienSiImage;
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
            for (int numQuest = 1; numQuest < 22; numQuest++)
            {
                var query = from c in xml.Root.Descendants("Question")
                            where (int)c.Attribute("numQuest") == numQuest
                            select c.Element("ennonce").Value + "." + c.Element("reponse1").Value + "." + c.Element("reponse2").Value + "." + c.Element("reponse3").Value + "." + c.Element("correct").Value + "."+c.Element("image").Value;

                foreach (string name in query)
                {
                    int courant = 0;
                    int nbrPoint = 0;
                    string ennonce = "";
                    string reponseCorrect = "";
                    string lienSiImage = "";
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
                            nbrPoint++;
                        }
                        else if ((name[i] == '.') && (nbrPoint == 4))
                        {
                            for (int y = i+1; y < name.Length; y++)
                            {
                                lienSiImage += name[y].ToString() ;
                            }
                            break;
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
                    list.Add(new Question(ennonce, reponses, reponseCorrect,lienSiImage));
                }
            }

            return list;
        }
    }
}
