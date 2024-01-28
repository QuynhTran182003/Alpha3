namespace Alpha3.Presentation_Tier
{
    partial class ClienPanel
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
            this.btnNewClient = new System.Windows.Forms.Button();
            this.lbClient = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // clientPanel
            // 
            this.clientPanel.Controls.Add(this.btnNewClient);
            this.clientPanel.Controls.Add(this.lbClient);
            this.clientPanel.Controls.Add(this.dataGridView1);
            this.clientPanel.Location = new System.Drawing.Point(3, 3);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(1127, 726);
            this.clientPanel.TabIndex = 8;
            // 
            // btnNewClient
            // 
            this.btnNewClient.Location = new System.Drawing.Point(916, 22);
            this.btnNewClient.Name = "btnNewClient";
            this.btnNewClient.Size = new System.Drawing.Size(192, 55);
            this.btnNewClient.TabIndex = 5;
            this.btnNewClient.Text = "New client";
            this.btnNewClient.UseVisualStyleBackColor = true;
            this.btnNewClient.Click += new System.EventHandler(this.btnNewClient_Click);
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Location = new System.Drawing.Point(3, 22);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(88, 32);
            this.lbClient.TabIndex = 4;
            this.lbClient.Text = "Client";
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
            // ClienPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.clientPanel);
            this.Name = "ClienPanel";
            this.Size = new System.Drawing.Size(1137, 725);
            this.clientPanel.ResumeLayout(false);
            this.clientPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel clientPanel;
        private System.Windows.Forms.Button btnNewClient;
        private System.Windows.Forms.Label lbClient;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
