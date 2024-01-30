namespace Alpha3
{
    partial class IntroForm
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
            this.lbIntro = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnTrip = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.reservationPanel1 = new Alpha3.Presentation_Tier.ReservationPanel();
            this.tripPanel1 = new Alpha3.Presentation_Tier.TripPanel();
            this.clienPanel1 = new Alpha3.Presentation_Tier.ClienPanel();
            this.btnHotel = new System.Windows.Forms.Button();
            this.btnCity = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIntro
            // 
            this.lbIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntro.Location = new System.Drawing.Point(831, 43);
            this.lbIntro.Name = "lbIntro";
            this.lbIntro.Size = new System.Drawing.Size(407, 81);
            this.lbIntro.TabIndex = 0;
            this.lbIntro.Text = "Travel Agent";
            // 
            // btnClient
            // 
            this.btnClient.BackColor = System.Drawing.Color.LightGray;
            this.btnClient.FlatAppearance.BorderSize = 0;
            this.btnClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClient.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClient.Location = new System.Drawing.Point(3, 174);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(343, 65);
            this.btnClient.TabIndex = 1;
            this.btnClient.Text = "Client";
            this.btnClient.UseVisualStyleBackColor = false;
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.LightGray;
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservation.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReservation.Location = new System.Drawing.Point(1, 401);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(345, 65);
            this.btnReservation.TabIndex = 2;
            this.btnReservation.Text = "Reservation";
            this.btnReservation.UseVisualStyleBackColor = false;
            this.btnReservation.Click += new System.EventHandler(this.btnReservation_Click);
            // 
            // btnTrip
            // 
            this.btnTrip.BackColor = System.Drawing.Color.LightGray;
            this.btnTrip.FlatAppearance.BorderSize = 0;
            this.btnTrip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnTrip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrip.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTrip.Location = new System.Drawing.Point(1, 288);
            this.btnTrip.Name = "btnTrip";
            this.btnTrip.Size = new System.Drawing.Size(343, 63);
            this.btnTrip.TabIndex = 3;
            this.btnTrip.Text = "Trip";
            this.btnTrip.UseVisualStyleBackColor = false;
            this.btnTrip.Click += new System.EventHandler(this.btnTrip_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.LightGray;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnReport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnReport.Location = new System.Drawing.Point(0, 820);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(346, 69);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnHotel);
            this.panel1.Controls.Add(this.btnCity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnTrip);
            this.panel1.Controls.Add(this.btnReservation);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 982);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dashboard";
            // 
            // reservationPanel1
            // 
            this.reservationPanel1.Location = new System.Drawing.Point(438, 171);
            this.reservationPanel1.Name = "reservationPanel1";
            this.reservationPanel1.Size = new System.Drawing.Size(1130, 729);
            this.reservationPanel1.TabIndex = 11;
            // 
            // tripPanel1
            // 
            this.tripPanel1.Location = new System.Drawing.Point(438, 175);
            this.tripPanel1.Name = "tripPanel1";
            this.tripPanel1.Size = new System.Drawing.Size(1135, 728);
            this.tripPanel1.TabIndex = 10;
            this.tripPanel1.Visible = false;
            // 
            // clienPanel1
            // 
            this.clienPanel1.Location = new System.Drawing.Point(438, 175);
            this.clienPanel1.Name = "clienPanel1";
            this.clienPanel1.Size = new System.Drawing.Size(1137, 725);
            this.clienPanel1.TabIndex = 9;
            this.clienPanel1.Visible = false;
            // 
            // btnHotel
            // 
            this.btnHotel.BackColor = System.Drawing.Color.LightGray;
            this.btnHotel.FlatAppearance.BorderSize = 0;
            this.btnHotel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnHotel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnHotel.Location = new System.Drawing.Point(3, 522);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(343, 63);
            this.btnHotel.TabIndex = 6;
            this.btnHotel.Text = "Hotel";
            this.btnHotel.UseVisualStyleBackColor = false;
            // 
            // btnCity
            // 
            this.btnCity.BackColor = System.Drawing.Color.LightGray;
            this.btnCity.FlatAppearance.BorderSize = 0;
            this.btnCity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCity.Location = new System.Drawing.Point(3, 635);
            this.btnCity.Name = "btnCity";
            this.btnCity.Size = new System.Drawing.Size(345, 65);
            this.btnCity.TabIndex = 5;
            this.btnCity.Text = "City";
            this.btnCity.UseVisualStyleBackColor = false;
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1691, 980);
            this.Controls.Add(this.reservationPanel1);
            this.Controls.Add(this.tripPanel1);
            this.Controls.Add(this.clienPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbIntro);
            this.Name = "IntroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Travel Agent";
            this.Load += new System.EventHandler(this.IntroForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbIntro;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnTrip;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Presentation_Tier.ClienPanel clienPanel1;
        private Presentation_Tier.TripPanel tripPanel1;
        private Presentation_Tier.ReservationPanel reservationPanel1;
        private System.Windows.Forms.Button btnHotel;
        private System.Windows.Forms.Button btnCity;
    }
}

