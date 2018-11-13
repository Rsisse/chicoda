using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluscourtchemin
{
    public class Node2 : GenericNode 
    {

        static public double[,] matrice;
        public int numero;

        // Méthodes abstrates, donc à surcharger obligatoirement avec override dans une classe fille
        public override bool IsEqual(GenericNode N2)
        {
            Node2 N2bis = (Node2)N2;
            return numero == N2bis.numero;
        }

        public override double GetArcCost(GenericNode N2)
        {
            Node2 N2bis = (Node2)N2;
            return DjikstraForm.matrice[numero, N2bis.numero];
        }

        public override bool EndState()
        {
            return (numero == DjikstraForm.numfinal);
        }

        public override List<GenericNode> GetListSucc()
        {
            List<GenericNode> lsucc = new List<GenericNode>();

            for (int i=0; i < DjikstraForm.nbnodes; i++)
            {
                if (DjikstraForm.matrice[numero, i] != -1)
                {
                    Node2 newnode2 = new Node2();
                    newnode2.numero = i;
                    lsucc.Add(newnode2);
                }
            }
            return lsucc;
        }


        public override double CalculeHCost()
        {
            return( 0 );
        }

        public override string ToString()
        {
            return Convert.ToString(numero);
        }
    }
}
