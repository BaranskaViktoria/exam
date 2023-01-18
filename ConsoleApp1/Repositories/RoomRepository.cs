using ConsoleApp1.Interfacas;
using exam.Entities;
using exam.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        public  List<IRoom>  Models { get; }
    }
    public void Addd(IRoom room)
    {
        Models.Add(room);
    }
    public IRoom Select (string roomTypeName)
    {
        return (IRoom)Models.Where(BedCapacity => bedCapacity.PricePerNight == pricePerNight).FirstOrDefault();
    }

}
