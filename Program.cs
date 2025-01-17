using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Game gm = new Game(1280,720))
            {
                gm.Run();
            }
        }
    }
}
