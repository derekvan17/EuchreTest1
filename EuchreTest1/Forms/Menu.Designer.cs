﻿namespace EuchreTest1
{
    partial class Menu
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
            this.newSinglePlayerGameBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newSinglePlayerGameBtn
            // 
            this.newSinglePlayerGameBtn.Location = new System.Drawing.Point(248, 178);
            this.newSinglePlayerGameBtn.Name = "newSinglePlayerGameBtn";
            this.newSinglePlayerGameBtn.Size = new System.Drawing.Size(134, 23);
            this.newSinglePlayerGameBtn.TabIndex = 0;
            this.newSinglePlayerGameBtn.Text = "Single Player";
            this.newSinglePlayerGameBtn.UseVisualStyleBackColor = true;
            this.newSinglePlayerGameBtn.Click += new System.EventHandler(this.newSinglePlayerGameBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Euchre!";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(637, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newSinglePlayerGameBtn);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newSinglePlayerGameBtn;
        private System.Windows.Forms.Label label1;
    }
}