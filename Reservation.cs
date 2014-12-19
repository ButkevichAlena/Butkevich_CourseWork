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
using System.Runtime.Serialization.Formatters.Binary;


namespace Reservation_of_the_accomodations
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        static void InvalidDate(DateTime data1, DateTime data2)
        {
            if (data1 < System.DateTime.Today || data1 > data2) { throw new System.Exception(" This data is not valid. Repeat input, please!!!"); }
        }

        static void InvalidDate(DateTime data)
        {
            if (data < System.DateTime.Today) { throw new System.Exception(" This data is not valid. Repeat input, please!!!"); }
        }
        static void InvalidClient(string client)
        {
            if (String.IsNullOrWhiteSpace(client)) { throw new System.Exception("Field 'name of client' is required!!! "); }
        }

        static void InvalidName()
        {
            throw new System.Exception("There are no any hotel room with such name. Chek your input, please!!!");
        }

        All_hotel_rooms ahr = new All_hotel_rooms();
        Reader reader = new Reader();

        private void Reservation_Load(object sender, EventArgs e)
        {

            BinaryFormatter formatter = new BinaryFormatter();
            string curFile = @"C:\Users\NotePad.by\Documents\serialise.dat";
            if (File.Exists(curFile))
            {
                using (FileStream fs = new FileStream(@"C:\Users\NotePad.by\Documents\serialise.dat", FileMode.Open))
                {
                    List<Hotel_room> list = (List<Hotel_room>)formatter.Deserialize(fs);
                    ahr.list = list;
                    ahr.deleteOldReservations();
                  
                    dataGridView1.DataSource = ahr.todayFreeRooms().list;
                }
            }
             else
            {
                ahr.create(reader.Read(@"C:\Users\NotePad.by\Documents\Hotel rooms.txt"));
            }  
        }

        private void btMakeReservation_Click(object sender, EventArgs e)
        {
            try
            {
                InvalidDate(DateTime.Parse(tbBeginOfReservation.Text), DateTime.Parse(tbEndOfReservation.Text));
                InvalidDate(DateTime.Parse(tbBeginOfReservation.Text));
                InvalidClient(tbNameOfClient.Text);
                ahr.IsFree(tbNameOfRoom.Text, DateTime.Parse(tbBeginOfReservation.Text), DateTime.Parse(tbEndOfReservation.Text));

                if (!ahr.compare(tbNameOfRoom.Text)) InvalidName();
                else { ahr.add(tbNameOfRoom.Text, tbNameOfClient.Text, DateTime.Parse(tbBeginOfReservation.Text), DateTime.Parse(tbEndOfReservation.Text)); }
                dataGridView1.DataSource = ahr.todayFreeRooms().list;
                tbBeginOfReservation.Clear(); tbEndOfReservation.Clear(); tbNameOfRoom.Clear(); tbNameOfClient.Clear();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: Invalid data!!!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void btShowFreeRooms_Click(object sender, EventArgs e)
        {
            try
            {
                InvalidDate(DateTime.Parse(tbDate.Text));
                listBox2.Items.Clear();
                foreach (string room in ahr.freeRooms(tbDate.Text))
                {
                    listBox2.Items.Add(room.ToString());
                }
                tbDate.Clear();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error: Invalid data!!!");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void Reservation_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream(@"C:\Users\NotePad.by\Documents\serialise.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, ahr.list);
            }

            e.Cancel = true;
            Hide();
        }
    }
}
