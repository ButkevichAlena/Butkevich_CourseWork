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
            if (client == " ") { throw new System.Exception("Field 'name of client' is required!!! "); }
        }

        static void InvalidName()
        {
            throw new System.Exception("There are no any hotel room with such name. Chek your input, please!!!");
        }

        Reader reader = new Reader();
        All_hotel_rooms ahr = new All_hotel_rooms();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Users\NotePad.by\Documents\Serialise.txt"))
            {
                XmlSerializer mySerializer = new XmlSerializer(typeof(All_hotel_rooms));
                FileStream myFileStream = new FileStream(@"C:\Users\NotePad.by\Documents\Serialise.txt", FileMode.Open);
                ahr = (All_hotel_rooms)
                mySerializer.Deserialize(myFileStream);
                richTextBox1.Text = ahr.todayFreeRooms().ToString();
                myFileStream.Close();
            }
            else 
            {
                ahr.create(reader.Read(@"C:\Users\NotePad.by\Documents\Hotel rooms.txt"));
                richTextBox1.Text = ahr.ToString(); 
           }
        }

        private void btmakeReservation_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text; string client = textBox2.Text; DateTime startData = DateTime.Parse(textBox3.Text); DateTime endData = DateTime.Parse(textBox4.Text);
                InvalidDate(startData, endData);
                InvalidClient(client);
                ahr.IsFree(name, startData, endData);
                if (ahr.compare(name))
                {
                    ahr.add(name, client, startData, endData);
                }
                else InvalidName();
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Error: Invalid Format of Date");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(All_hotel_rooms));
            StreamWriter stringWriter = new StreamWriter(new FileStream(@"C:\Users\NotePad.by\Documents\Serialise.txt", FileMode.OpenOrCreate, FileAccess.Write));
            xmlSerializer.Serialize(stringWriter, ahr);
        }

        private void btShowFreeRooms_Click(object sender, EventArgs e)
        {
                ahr.deleteOldReservations();
                richTextBox2.Text = ahr.freeRooms(textBox5.Text).ToString();    
        }

   }
}
