namespace Alpha3.Presentation_Tier
{
    partial class TripPanel
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
            this.btnNewTrip = new System.Windows.Forms.Button();
            this.lbTrip = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientPanel
            // 
            this.clientPanel.Controls.Add(this.btnNewTrip);
            this.clientPanel.Controls.Add(this.lbTrip);
            this.clientPanel.Controls.Add(this.dataGridView1);
            this.clientPanel.Location = new System.Drawing.Point(3, 3);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(1127, 726);
            this.clientPanel.TabIndex = 9;
            // 
            // btnNewTrip
            // 
            this.btnNewTrip.Location = new System.Drawing.Point(916, 22);
            this.btnNewTrip.Name = "btnNewTrip";
            this.btnNewTrip.Size = new System.Drawing.Size(192, 55);
            this.btnNewTrip.TabIndex = 5;
            this.btnNewTrip.Text = "New Trip";
            this.btnNewTrip.UseVisualStyleBackColor = true;
            this.btnNewTrip.Click += new System.EventHandler(this.btnNewTrip_Click);
            // 
            // lbTrip
            // 
            this.lbTrip.AutoSize = true;
            this.lbTrip.Location = new System.Drawing.Point(3, 22);
            this.lbTrip.Name = "lbTrip";
            this.lbTrip.Size = new System.Drawing.Size(63, 32);
            this.lbTrip.TabIndex = 4;
            this.lbTrip.Text = "Trip";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1124, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // TripPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientPanel);
            this.Name = "TripPanel";
            this.Size = new System.Drawing.Size(1135, 728);
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel clientPanel;
        private System.Windows.Forms.Button btnNewTrip;
        private System.Windows.Forms.Label lbTrip;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
