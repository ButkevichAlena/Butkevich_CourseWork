namespace Reservation_of_the_accomodations
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btReservation = new System.Windows.Forms.Button();
            this.btHotelRooms = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btReservation
            // 
            this.btReservation.BackColor = System.Drawing.Color.DarkRed;
            this.btReservation.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btReservation.Location = new System.Drawing.Point(85, 117);
            this.btReservation.Name = "btReservation";
            this.btReservation.Size = new System.Drawing.Size(126, 40);
            this.btReservation.TabIndex = 0;
            this.btReservation.Text = "Reservation";
            this.btReservation.UseVisualStyleBackColor = false;
            this.btReservation.Click += new System.EventHandler(this.btReservation_Click);
            // 
            // btHotelRooms
            // 
            this.btHotelRooms.BackColor = System.Drawing.Color.Maroon;
            this.btHotelRooms.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btHotelRooms.Location = new System.Drawing.Point(266, 117);
            this.btHotelRooms.Name = "btHotelRooms";
            this.btHotelRooms.Size = new System.Drawing.Size(118, 40);
            this.btHotelRooms.TabIndex = 1;
            this.btHotelRooms.Text = "Hotel rooms";
            this.btHotelRooms.UseVisualStyleBackColor = false;
            this.btHotelRooms.Click += new System.EventHandler(this.btHotelRooms_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(164, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hotel \"Grand\" 4*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(469, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btHotelRooms);
            this.Controls.Add(this.btReservation);
            this.ForeColor = System.Drawing.Color.Snow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel \"Grand\" 4*";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReservation;
        private System.Windows.Forms.Button btHotelRooms;
        private System.Windows.Forms.Label label1;


    }
}

