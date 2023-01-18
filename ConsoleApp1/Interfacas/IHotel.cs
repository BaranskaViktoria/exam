using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfacas
{
   public interface IHotel
    {
        string FullName { get; set; }
        int  Category { get; set; }

        double pricePerNight { get; set; }


    }
}
