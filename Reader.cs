using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Reservation_of_the_accomodations
{
    public class Reader 
    {
        public List<string> Read(string nameOfFile)
        {
            string line;
            List<String> list = new List<string>();
            StreamReader file = new StreamReader(nameOfFile);
            while ((line = file.ReadLine()) != null)
            {
                list.Add(line);
            }
            return list;
        }
   }
}
