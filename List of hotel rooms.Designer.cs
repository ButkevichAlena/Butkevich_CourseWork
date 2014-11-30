namespace Reservation_of_the_accomodations
{
    partial class List_of_hotel_rooms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(List_of_hotel_rooms));
            this.lvListOfHotelRooms = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvListOfHotelRooms
            // 
            this.lvListOfHotelRooms.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lvListOfHotelRooms.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lvListOfHotelRooms.ForeColor = System.Drawing.Color.Maroon;
            this.lvListOfHotelRooms.FullRowSelect = true;
            this.lvListOfHotelRooms.GridLines = true;
            this.lvListOfHotelRooms.Location = new System.Drawing.Point(30, 30);
            this.lvListOfHotelRooms.Name = "lvListOfHotelRooms";
            this.lvListOfHotelRooms.Size = new System.Drawing.Size(385, 365);
            this.lvListOfHotelRooms.TabIndex = 0;
            this.lvListOfHotelRooms.TileSize = new System.Drawing.Size(100, 40);
            this.lvListOfHotelRooms.UseCompatibleStateImageBehavior = false;
            this.lvListOfHotelRooms.View = System.Windows.Forms.View.Tile;
            // 
            // List_of_hotel_rooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(445, 427);
            this.Controls.Add(this.lvListOfHotelRooms);
            this.Name = "List_of_hotel_rooms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_of_hotel_rooms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.List_of_hotel_rooms_FormClosing);
            this.Load += new System.EventHandler(this.List_of_hotel_rooms_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvListOfHotelRooms;

    }
}