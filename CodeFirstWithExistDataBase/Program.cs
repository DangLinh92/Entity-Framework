using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstWithExistDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var contex = new PlutoContext();
            var authors = contex.Authors;
            foreach (var author in authors)
            {
                Console.WriteLine(author.Name);
            }
        }
    }
}
