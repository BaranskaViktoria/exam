using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfacas
{
    public interface IRoom
    {
        void SetRrice();

        int BedCapacity { get; set; }
        double PricePerNight { get; set; }
    }
}
