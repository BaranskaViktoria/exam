using ConsoleApp1.Interfacas;
using exam.Entities;
using exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        public List<IBooking> Models { get; }


        public void Add(IBooking booking)
        {
            Models.Add(booking);
        }

        public IBooking Select(int bookingNumberToSrting)
        {
            return (IBooking)Models.Where(a => a.BookingNumber == bookingNumber).FirstOrDefault();
        }
    }
}
