using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TestXML
{
    class Program
    {

        

        static void Main(string[] args)
        {
            List<Question> maListe = Question.CreateListQuestions();

            foreach (var item in maListe)
            {
                Console.WriteLine(item);
            }


        }


    }
}
