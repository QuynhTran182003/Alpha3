namespace Alpha3.Presentation_Tier
{
    partial class ReservationPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clientPanel = new System.Windows.Forms.Panel();
            this.btnNewRese = new System.Windows.Forms.Button();
            this.lbReservation = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientPanel
            // 
            this.clientPanel.Controls.Add(this.btnNewRese);
            this.clientPanel.Controls.Add(this.lbReservation);
            this.clientPanel.Controls.Add(this.dataGridView1);
            this.clientPanel.Location = new System.Drawing.Point(3, 3);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(1127, 726);
            this.clientPanel.TabIndex = 9;
            // 
            // btnNewRese
            // 
            this.btnNewRese.Location = new System.Drawing.Point(859, 22);
            this.btnNewRese.Name = "btnNewRese";
            this.btnNewRese.Size = new System.Drawing.Size(249, 55);
            this.btnNewRese.TabIndex = 5;
            this.btnNewRese.Text = "New reservation";
            this.btnNewRese.UseVisualStyleBackColor = true;
            // 
            // lbReservation
            // 
            this.lbReservation.AutoSize = true;
            this.lbReservation.Location = new System.Drawing.Point(3, 22);
            this.lbReservation.Name = "lbReservation";
            this.lbReservation.Size = new System.Drawing.Size(166, 32);
            this.lbReservation.TabIndex = 4;
            this.lbReservation.Text = "Reservation";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1124, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // ReservationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientPanel);
            this.Name = "ReservationPanel";
            this.Size = new System.Drawing.Size(1130, 729);
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel clientPanel;
        private System.Windows.Forms.Button btnNewRese;
        private System.Windows.Forms.Label lbReservation;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
