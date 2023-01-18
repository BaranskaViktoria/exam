using exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Entities
{
    public class Booking : IBooking
    {
        IRoom room;
        int residenceDuration;
        int adultsCount;
        int childrenCount;
        int bookingNumber;
    }

    public Booking(int residenceDuration, int adultsCount,int childrenCount, int bookingNumber)
    {
        this.ResidenceDuration = residenceDuration;
        this.AdultsCount = adultsCount;
        this.ChildrenCount = childrenCount;
        this.BookingNumber = bookingNumber;

    }

    public IRoom Room 
    {
        get
        {
            return room;
        }
        set
        {
            room = value;
        }
    }

    public int ResidenceDuration
    {
        get
        {
            return residenceDuration;
        }

        set
        {
            if (value < 0)
                throw new ArgumentException("Duration cannot be negative or zero!!!");
            residenceDuration = value;
        }
    }

    public int AdultsCount
    {
        get
        {
            return adultsCount;
        }

        set
        {
            if (value < 1)
                throw new ArgumentException("Adults cannot be negative or zero!!!");
            adultsCount = value;
        }
    }

    public int ChildrenCount
    {
        get
        {
            return childrenCount;
        }

        set
        {
            if (value < 0)
                throw new ArgumentException(" Children  coutn cannot be negative");
            childrenCount = value;
        }
    }

    public int BookingNumber
    {
        get { 
            return true;
        }
        set
        {
            bookingNumber = value;
        }
    }

}
