using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluscourtchemin
{   // classe qui permet d'avoir deux listes de noeuds (les ouverts et les fermés)
    public class DoubleNode
    {
        public List<GenericNode> L_Ouverts { get; set; }
        public List<GenericNode> L_Fermes { get; set;}

        public DoubleNode()
        {
            L_Ouverts = new List<GenericNode>();
            L_Fermes = new List<GenericNode>();
        }

        public DoubleNode(List<GenericNode> L_ouverts,List<GenericNode>L_fermes)
        {
            L_Ouverts = L_ouverts;
            L_Fermes = L_fermes;
        }



    }
}
