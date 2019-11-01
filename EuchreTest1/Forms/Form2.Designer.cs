namespace EuchreTest1
{
    partial class Form2
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
            this.orderUpButton = new System.Windows.Forms.Button();
            this.clubsButton = new System.Windows.Forms.Button();
            this.heartsButton = new System.Windows.Forms.Button();
            this.spadesButton = new System.Windows.Forms.Button();
            this.diamondsButton = new System.Windows.Forms.Button();
            this.passButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // orderUpButton
            // 
            this.orderUpButton.Location = new System.Drawing.Point(100, 10);
            this.orderUpButton.Name = "orderUpButton";
            this.orderUpButton.Size = new System.Drawing.Size(83, 23);
            this.orderUpButton.TabIndex = 46;
            this.orderUpButton.Text = "Order Up";
            this.orderUpButton.UseVisualStyleBackColor = true;
            this.orderUpButton.Click += new System.EventHandler(this.orderUpButton_Click);
            // 
            // clubsButton
            // 
            this.clubsButton.BackColor = System.Drawing.Color.White;
            this.clubsButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clubsButton.Location = new System.Drawing.Point(101, 9);
            this.clubsButton.Name = "clubsButton";
            this.clubsButton.Size = new System.Drawing.Size(22, 26);
            this.clubsButton.TabIndex = 45;
            this.clubsButton.UseVisualStyleBackColor = false;
            this.clubsButton.Click += new System.EventHandler(this.clubsButton_Click);
            // 
            // heartsButton
            // 
            this.heartsButton.BackColor = System.Drawing.Color.White;
            this.heartsButton.Location = new System.Drawing.Point(161, 9);
            this.heartsButton.Name = "heartsButton";
            this.heartsButton.Size = new System.Drawing.Size(22, 26);
            this.heartsButton.TabIndex = 44;
            this.heartsButton.UseVisualStyleBackColor = false;
            this.heartsButton.Click += new System.EventHandler(this.heartsButton_Click);
            // 
            // spadesButton
            // 
            this.spadesButton.BackColor = System.Drawing.Color.White;
            this.spadesButton.Location = new System.Drawing.Point(141, 9);
            this.spadesButton.Name = "spadesButton";
            this.spadesButton.Size = new System.Drawing.Size(22, 26);
            this.spadesButton.TabIndex = 43;
            this.spadesButton.UseVisualStyleBackColor = false;
            this.spadesButton.Click += new System.EventHandler(this.spadesButton_Click);
            // 
            // diamondsButton
            // 
            this.diamondsButton.BackColor = System.Drawing.Color.White;
            this.diamondsButton.Location = new System.Drawing.Point(121, 9);
            this.diamondsButton.Name = "diamondsButton";
            this.diamondsButton.Size = new System.Drawing.Size(22, 26);
            this.diamondsButton.TabIndex = 42;
            this.diamondsButton.UseVisualStyleBackColor = false;
            this.diamondsButton.Click += new System.EventHandler(this.diamondsButton_Click);
            // 
            // passButton
            // 
            this.passButton.Location = new System.Drawing.Point(11, 10);
            this.passButton.Name = "passButton";
            this.passButton.Size = new System.Drawing.Size(82, 23);
            this.passButton.TabIndex = 41;
            this.passButton.Text = "Pass";
            this.passButton.UseVisualStyleBackColor = true;
            this.passButton.Click += new System.EventHandler(this.passButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(198, 35);
            this.ControlBox = false;
            this.Controls.Add(this.orderUpButton);
            this.Controls.Add(this.clubsButton);
            this.Controls.Add(this.heartsButton);
            this.Controls.Add(this.spadesButton);
            this.Controls.Add(this.diamondsButton);
            this.Controls.Add(this.passButton);
            this.Location = new System.Drawing.Point(210, 100);
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Select Trump!";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button orderUpButton;
        public System.Windows.Forms.Button clubsButton;
        public System.Windows.Forms.Button heartsButton;
        public System.Windows.Forms.Button spadesButton;
        public System.Windows.Forms.Button diamondsButton;
        public System.Windows.Forms.Button passButton;
    }
}