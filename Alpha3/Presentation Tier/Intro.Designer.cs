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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panContent = new System.Windows.Forms.Panel();
            this.lbContent = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIntro
            // 
            this.lbIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIntro.Location = new System.Drawing.Point(770, 27);
            this.lbIntro.Name = "lbIntro";
            this.lbIntro.Size = new System.Drawing.Size(452, 81);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Location = new System.Drawing.Point(0, 820);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 69);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClient);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnTrip);
            this.panel1.Controls.Add(this.btnReservation);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 926);
            this.panel1.TabIndex = 6;
            // 
            // panContent
            // 
            this.panContent.Controls.Add(this.lbContent);
            this.panContent.Controls.Add(this.dataGridView1);
            this.panContent.Location = new System.Drawing.Point(404, 157);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(1080, 726);
            this.panContent.TabIndex = 7;
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Location = new System.Drawing.Point(3, 9);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(0, 32);
            this.lbContent.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dashboard";
            // 
            // IntroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1531, 926);
            this.Controls.Add(this.panContent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbIntro);
            this.Name = "IntroForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Travel Agent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panContent.ResumeLayout(false);
            this.panContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbIntro;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.Button btnReservation;
        private System.Windows.Forms.Button btnTrip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Label label1;
    }
}

