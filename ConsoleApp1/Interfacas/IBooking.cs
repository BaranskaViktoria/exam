using ConsoleApp1.Interfacas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfacas
{
    public interface IBooking
    {
        int ResidenceDuration(int ResidenceDuration);
        int AdultsCount(int AdultsCount);
        int ChildrenCount(int ChildrenCount);
        int BookingNumber(int bookingNumber);
    }
}


