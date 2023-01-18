using ConsoleApp1.Interfacas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities
{
    public class Hotel : IHotel
    {
        string FullName;
        int Category;
        double pricePerNight;
        IRoomRepository Rooms;
        IBookingRepository Bookings;
    }
}
