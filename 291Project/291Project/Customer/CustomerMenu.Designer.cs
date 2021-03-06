﻿namespace _291Project.Employee
{
    partial class CustomerMenu
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
            this.CreateOrder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MovieSuggestionButton = new System.Windows.Forms.Button();
            this.ReturnOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateOrder
            // 
            this.CreateOrder.Location = new System.Drawing.Point(49, 43);
            this.CreateOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(100, 49);
            this.CreateOrder.TabIndex = 0;
            this.CreateOrder.Text = "Create an Order";
            this.CreateOrder.UseVisualStyleBackColor = true;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(400, 350);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 22);
            this.button2.TabIndex = 1;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // MovieSuggestionButton
            // 
            this.MovieSuggestionButton.Location = new System.Drawing.Point(200, 43);
            this.MovieSuggestionButton.Name = "MovieSuggestionButton";
            this.MovieSuggestionButton.Size = new System.Drawing.Size(101, 49);
            this.MovieSuggestionButton.TabIndex = 2;
            this.MovieSuggestionButton.Text = "Movie Suggestions";
            this.MovieSuggestionButton.UseVisualStyleBackColor = true;
            this.MovieSuggestionButton.Click += new System.EventHandler(this.MovieSuggestionButton_Click);
            // 
            // ReturnOrder
            // 
            this.ReturnOrder.Location = new System.Drawing.Point(49, 122);
            this.ReturnOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReturnOrder.Name = "ReturnOrder";
            this.ReturnOrder.Size = new System.Drawing.Size(100, 49);
            this.ReturnOrder.TabIndex = 3;
            this.ReturnOrder.Text = "Return an Order";
            this.ReturnOrder.UseVisualStyleBackColor = true;
            this.ReturnOrder.Click += new System.EventHandler(this.ReturnOrder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "View Your Current Orders";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PaymentButton
            // 
            this.PaymentButton.Location = new System.Drawing.Point(49, 195);
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.Size = new System.Drawing.Size(100, 46);
            this.PaymentButton.TabIndex = 5;
            this.PaymentButton.Text = "Make A Payment";
            this.PaymentButton.UseVisualStyleBackColor = true;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 383);
            this.Controls.Add(this.PaymentButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReturnOrder);
            this.Controls.Add(this.MovieSuggestionButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreateOrder);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomerMenu";
            this.Text = "CustomerMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateOrder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button MovieSuggestionButton;
        private System.Windows.Forms.Button ReturnOrder;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button PaymentButton;
    }
}