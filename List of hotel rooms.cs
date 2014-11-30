using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservation_of_the_accomodations
{
    public partial class List_of_hotel_rooms : Form
    {
 
        public List_of_hotel_rooms()
        {
            InitializeComponent();
        }

        All_hotel_rooms ahr = new All_hotel_rooms();
        Reader reader = new Reader();

        private void List_of_hotel_rooms_Load(object sender, EventArgs e)
        {
            ahr.create(reader.Read(@"C:\Users\NotePad.by\Documents\Hotel rooms.txt"));
            foreach (Hotel_room room in ahr.list)
            {
                lvListOfHotelRooms.Items.Add(room.ToString());
            }
        }

        private void List_of_hotel_rooms_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
