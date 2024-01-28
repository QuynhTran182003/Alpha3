namespace Alpha3.Presentation_Tier
{
    partial class NewClientForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tBxPhone = new System.Windows.Forms.TextBox();
            this.tBxEmail = new System.Windows.Forms.TextBox();
            this.tBxName = new System.Windows.Forms.TextBox();
            this.tBxSurname = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 54);
            this.label1.TabIndex = 19;
            this.label1.Text = "New Client";
            // 
            // tBxPhone
            // 
            this.tBxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxPhone.Location = new System.Drawing.Point(360, 381);
            this.tBxPhone.Name = "tBxPhone";
            this.tBxPhone.Size = new System.Drawing.Size(428, 45);
            this.tBxPhone.TabIndex = 18;
            // 
            // tBxEmail
            // 
            this.tBxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxEmail.Location = new System.Drawing.Point(360, 308);
            this.tBxEmail.Name = "tBxEmail";
            this.tBxEmail.Size = new System.Drawing.Size(428, 45);
            this.tBxEmail.TabIndex = 17;
            // 
            // tBxName
            // 
            this.tBxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxName.Location = new System.Drawing.Point(360, 232);
            this.tBxName.Name = "tBxName";
            this.tBxName.Size = new System.Drawing.Size(428, 45);
            this.tBxName.TabIndex = 16;
            // 
            // tBxSurname
            // 
            this.tBxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBxSurname.Location = new System.Drawing.Point(360, 160);
            this.tBxSurname.Name = "tBxSurname";
            this.tBxSurname.Size = new System.Drawing.Size(428, 45);
            this.tBxSurname.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(719, 491);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 60);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone.Location = new System.Drawing.Point(153, 384);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(188, 39);
            this.lbPhone.TabIndex = 13;
            this.lbPhone.Text = "Telephone:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(153, 311);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(112, 39);
            this.lbEmail.TabIndex = 12;
            this.lbEmail.Text = "Email:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(153, 235);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(117, 39);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Name:";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSurname.Location = new System.Drawing.Point(153, 163);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(164, 39);
            this.lbSurname.TabIndex = 10;
            this.lbSurname.Text = "Surname:";
            // 
            // NewClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBxPhone);
            this.Controls.Add(this.tBxEmail);
            this.Controls.Add(this.tBxName);
            this.Controls.Add(this.tBxSurname);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbSurname);
            this.Name = "NewClientForm";
            this.Text = "New Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBxPhone;
        private System.Windows.Forms.TextBox tBxEmail;
        private System.Windows.Forms.TextBox tBxName;
        private System.Windows.Forms.TextBox tBxSurname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSurname;
    }
}