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
using System.Xml.Serialization;

namespace Reservation_of_the_accomodations
{
    public partial class MainForm : Form
    {
 
        List_of_hotel_rooms form = new List_of_hotel_rooms();
        Reservation newForm = new Reservation();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btHotelRooms_Click(object sender, EventArgs e)
        {
            form.Show();
        }

        private void btReservation_Click(object sender, EventArgs e)
        {
            newForm.Show();
        }

   }
}
