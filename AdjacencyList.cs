using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAdjacencyList
{
    [Serializable]
    public class AdjacencyList
    {
        private int vertices;
        private LinkedList<int>[] list;

        public int Vertices
        {
            get { return vertices; }
            set { vertices = value; }
        }
        public LinkedList<int>[] List
        {
            get { return list; }
            set { list = value; }
        }

        public AdjacencyList()
        {
            Vertices = 0;
            List = null;
        }

        public AdjacencyList(AdjacencyList list)
        {
            this.Vertices = list.Vertices;
            this.List = list.List;
        }
        
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append(Vertices); sb.AppendLine();
            for (int i = 0; i < Vertices; i++)
            {
                foreach (var item in List[i])
                {
                    sb.Append($"{item + 1} ");
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }
}
