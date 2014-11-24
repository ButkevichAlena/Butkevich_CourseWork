using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_of_the_accomodations
{
    public class Hotel_room
    {
<<<<<<< HEAD


=======
>>>>>>> origin/master
        public List<Client> clients = new List<Client>();

        private string name;
        private string status;
        private string category;

        public string Name {get; set;}
        public string Category {get; set;}
        public string Status { get; set; }

        public Hotel_room(string name_, string category_) { this.Name = name_; this.Category = category_; this.Status = "free"; }
        public Hotel_room() { }

        public override string ToString()
        {
            StringBuilder bufer = new StringBuilder();
            StringBuilder sbufer = new StringBuilder();
            bufer.Append(Name + " " + Category + " " + Status + " " + sbufer.ToString() +'\n');
            foreach (Client client in clients)
            {
               sbufer.Append(client.ToString());
            }
            return bufer.ToString();
        }

        public bool IsHotelRoomFree( DateTime date1, DateTime date2)
        {
            bool IsFree = true;
            foreach (Client client in this.clients)
            {
                if (client.StartDate <= date1 || client.EndDate >= date2)
                {
                    IsFree = false; 
                }
            }
            return IsFree;
        }


    }
}
