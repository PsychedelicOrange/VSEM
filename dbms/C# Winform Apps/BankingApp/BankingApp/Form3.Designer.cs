﻿
namespace BankingApp
{
    partial class Form3
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
            this.Balance_text = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Transfer = new System.Windows.Forms.Button();
            this.benefeciary = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Balance:";
            // 
            // Balance_text
            // 
            this.Balance_text.AutoSize = true;
            this.Balance_text.Location = new System.Drawing.Point(209, 34);
            this.Balance_text.Name = "Balance_text";
            this.Balance_text.Size = new System.Drawing.Size(46, 17);
            this.Balance_text.TabIndex = 1;
            this.Balance_text.Text = "label2";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(205, 117);
            this.amount.Mask = "09999999999";
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(163, 22);
            this.amount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "₹";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transfer amount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tranfer to :";
            // 
            // Transfer
            // 
            this.Transfer.Location = new System.Drawing.Point(81, 181);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(75, 23);
            this.Transfer.TabIndex = 6;
            this.Transfer.Text = "Transfer";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // benefeciary
            // 
            this.benefeciary.Location = new System.Drawing.Point(205, 77);
            this.benefeciary.Name = "benefeciary";
            this.benefeciary.Size = new System.Drawing.Size(163, 22);
            this.benefeciary.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 236);
            this.Controls.Add(this.benefeciary);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.Balance_text);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Balance_text;
        private System.Windows.Forms.MaskedTextBox amount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.TextBox benefeciary;
    }
}