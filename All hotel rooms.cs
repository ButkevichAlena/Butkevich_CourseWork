using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_of_the_accomodations
{
    [Serializable]
    public class All_hotel_rooms
    {
        static void TakenDate()
        {
            throw new System.Exception(" This date is taken already. Input another date or name of hotel_room, please!!!");
        }

        public List<Hotel_room> list = new List<Hotel_room>();

        public void create(List<string> slist)
        {
            string name = ""; string category = "";
           
            foreach (string line in slist)
            {
                string[] split = line.Split(' ');
                name = split[0]; category = split[1];
                Hotel_room room = new Hotel_room(name, category);
                list.Add(room);
            }
        }

        public override string ToString()
        {
            StringBuilder bufer = new StringBuilder();
            foreach (Hotel_room room in list)
            {
              bufer.Append(room.ToString() + " "); 
            }
            return bufer.ToString();
        }

        public bool compare(string name)
        {
            bool IsValid = false;
            foreach (Hotel_room room in this.list)
            {
                if (room.Name == name)
                {
                    IsValid = true;
                }
            }
            return IsValid;
        }

        public void add(string name, string client, DateTime startDate, DateTime endDate)
        {
                foreach (Hotel_room room in this.list)
                {
                    if (room.IsHotelRoomFree(startDate, endDate))
                    {
                        if (room.Name == name)
                        {
                            Client ct = new Client();
                            ct.Name = client;
                            ct.StartDate = startDate;
                            ct.EndDate = endDate;
                            room.clients.Add(ct);
                            room.Status = "taken";
                        }
                    }
                }
         }

        public void IsFree(string name, DateTime startDate, DateTime endDate)
        {
            foreach (Hotel_room room in this.list)
            {
                if (room.Name == name && !room.IsHotelRoomFree(startDate, endDate))
                {
                    TakenDate();
                }
            }
        }


        public List<String> freeRooms(string date)
        {
            List<String> freeRoom = new List<String>();
            foreach (Hotel_room room in this.list)
            {
                foreach (Client client in room.clients)
                    if (DateTime.Parse(date) >= client.StartDate && DateTime.Parse(date) <= client.EndDate)
                {
                    room.Status = "taken"; break; 
                }
                    else room.Status = "free";
            }
            foreach (Hotel_room room in this.list)
            {
               if (room.Status == "free") freeRoom.Add(room.Name + " " + room.Category);
            }
            return freeRoom;
        }

        public All_hotel_rooms todayFreeRooms()
        {
            All_hotel_rooms ahr = new All_hotel_rooms();
            foreach (Hotel_room room in this.list)
            {
                foreach (Client client in room.clients)
                    if (client.StartDate <= System.DateTime.Today && client.EndDate >= System.DateTime.Today)
                    {
                        room.Status = "taken"; break;
                    }
                    else room.Status = "free";
                ahr.list.Add(room);
            }
            return ahr;
        }

        public void deleteOldReservations()
        {
            foreach (Hotel_room room in this.list)
            {
                foreach (Client client in room.clients)
                    if ( client.EndDate <= System.DateTime.Today)
                    {
                        room.clients.Remove(client);
                    }
            }
       }
    }
}
