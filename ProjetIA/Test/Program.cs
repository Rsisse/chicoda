using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> test= new List<string>(); 
            XmlTextReader reader = new XmlTextReader("Questions.xml");
            Dictionary<string, List<string>> dico = new Dictionary<string, List<string>>();
            bool propo = false;
            string test2 = "";
            bool first = false;
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        if (reader.Name == "enonce")
                        {
                            first = true; // à explorer
                        }
                        else if (reader.Name == "proposition")
                        {
                            propo = true;
                        }
                        else
                        {
                            propo = false;
                        }
              //          Console.Write("<" + reader.Name);
                //        Console.WriteLine(">");

                        break;
                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine(reader.Value);

                        if (propo == true)
                        {
                            test.Add(reader.Value);
                        }
                       
                        break;
                    case XmlNodeType.EndElement: //Display the end of the element.
                       // Console.Write("</" + reader.Name);
                        //Console.WriteLine(">");
                       // ici faire un test sur propositions
                        break;
                }
            }


            foreach (KeyValuePair<string, List<string>> item in dico)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }


        }
    }
}
