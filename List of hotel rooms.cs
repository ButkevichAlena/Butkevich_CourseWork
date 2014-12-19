using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Reservation_of_the_accomodations
{
    public partial class List_of_hotel_rooms : Form
    {
 
        public List_of_hotel_rooms()
        {
            InitializeComponent();
        }

        Reservation form = new Reservation();
        All_hotel_rooms ahr = new All_hotel_rooms();
        Reader reader = new Reader();

        private void List_of_hotel_rooms_Load(object sender, EventArgs e)
        {
            string text = File.ReadAllText(@"C:\Users\NotePad.by\Documents\HotelRooms.txt");
            rbInformationAboutRooms.Text = text;
           
        }

        private void List_of_hotel_rooms_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btGoToReservation_Click(object sender, EventArgs e)
        {
            Close();
            form.Show();
        }
    }
}
