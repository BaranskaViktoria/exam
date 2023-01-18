using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Entities
{
    public abstract class Room : IRoom
    {
        int bedCapacity;
        double pricePerNight;


        public Room(string bedCapacity, double pricePerNight)
        {
            this.BedCapacity = bedCapacity;
            this.PricePerNight = pricePerNight;
        }

        public string BedCapacity
        {
            get {
               return bedCapacity;
            }
            set  {
            bedCapacity = value;
            }
        }
        public double PricePerNight
        {
            get
            {
                return pricePerNight;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannop be negative!");
                pricePerNight = value;
            }
        }
    }
}
