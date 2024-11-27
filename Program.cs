using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CSITStudnet csit = new CSITStudnet();
            csit.id = 1001;
            csit.name = "Test";

            csit.displayDetail();

        }
    }
}
