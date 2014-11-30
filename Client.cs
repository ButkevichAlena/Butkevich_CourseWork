using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation_of_the_accomodations
{
    [Serializable]
    public class Client
    {
        private string name;
        private DateTime startDate;
        private DateTime endDate;

        public string Name { get; set;}
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public override string ToString()
        {
            string bufer = Name + '\n';
            return bufer;
        }
    }
}
