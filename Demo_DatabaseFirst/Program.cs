using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new CinemaDBEntities();
            var Chude = new ChuDe()
            {
                Id = 7,
                TenChuDe = "Tâm lý"
            };
            context.ChuDes.Add(Chude);
            context.SaveChanges();
        }
    }
}
