﻿using System.Diagnostics;

namespace helphub
{
    public partial class COMPLAINT : System.Windows.Forms.Form
    {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is not null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        private void InitializeComponent()
        {
            this.Aadhar = new System.Windows.Forms.TextBox();
            this.Dcomplaint = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Button2 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Aadhar
            // 
            this.Aadhar.BackColor = System.Drawing.Color.White;
            this.Aadhar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Aadhar.Enabled = false;
            this.Aadhar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Aadhar.Location = new System.Drawing.Point(79, 178);
            this.Aadhar.Multiline = true;
            this.Aadhar.Name = "Aadhar";
            this.Aadhar.Size = new System.Drawing.Size(320, 31);
            this.Aadhar.TabIndex = 23;
            // 
            // Dcomplaint
            // 
            this.Dcomplaint.BackColor = System.Drawing.Color.White;
            this.Dcomplaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Dcomplaint.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dcomplaint.Location = new System.Drawing.Point(79, 258);
            this.Dcomplaint.Multiline = true;
            this.Dcomplaint.Name = "Dcomplaint";
            this.Dcomplaint.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Dcomplaint.Size = new System.Drawing.Size(320, 84);
            this.Dcomplaint.TabIndex = 22;
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.White;
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Address.Location = new System.Drawing.Point(506, 258);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Address.Size = new System.Drawing.Size(353, 84);
            this.Address.TabIndex = 21;
            // 
            // Contact
            // 
            this.Contact.BackColor = System.Drawing.Color.White;
            this.Contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Contact.Location = new System.Drawing.Point(506, 178);
            this.Contact.Multiline = true;
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(320, 33);
            this.Contact.TabIndex = 20;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Button1.Location = new System.Drawing.Point(590, 665);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(337, 88);
            this.Button1.TabIndex = 18;
            this.Button1.Text = "SUBMIT COMPLAIN";
            this.Button1.UseVisualStyleBackColor = false;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label6.Location = new System.Drawing.Point(79, 152);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(220, 26);
            this.Label6.TabIndex = 17;
            this.Label6.Text = "AADHAR NUMBER";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label5.Location = new System.Drawing.Point(506, 232);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(191, 26);
            this.Label5.TabIndex = 16;
            this.Label5.Text = "FULL ADDRESS";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label4.Location = new System.Drawing.Point(79, 232);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(240, 26);
            this.Label4.TabIndex = 15;
            this.Label4.Text = "COMPLAIN DETAILS";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label3.Location = new System.Drawing.Point(506, 152);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(210, 26);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "MOBILE NUMBER";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label2.Location = new System.Drawing.Point(345, 82);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(243, 26);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "TYPE OF COMPLAIN";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.Label1.Location = new System.Drawing.Point(295, 38);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(347, 39);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "FILE A COMPLAINT";
            // 
            // ComboBox1
            // 
            this.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox1.BackColor = System.Drawing.Color.White;
            this.ComboBox1.DropDownWidth = 579;
            this.ComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "DOMESTIC VOILENCE",
            "ELECTRICITY",
            "ROAD",
            "STREET DOGS",
            "WATER / SEWAGE",
            "OTHER ISSUES"});
            this.ComboBox1.Location = new System.Drawing.Point(326, 112);
            this.ComboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(279, 33);
            this.ComboBox1.TabIndex = 24;
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(282, 363);
            this.Button2.Margin = new System.Windows.Forms.Padding(2);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(360, 78);
            this.Button2.TabIndex = 25;
            this.Button2.Text = "SUBMIT COMPLAINT";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.pictureBox3);
            this.GroupBox1.Controls.Add(this.pictureBox2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.Button2);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Dcomplaint);
            this.GroupBox1.Controls.Add(this.ComboBox1);
            this.GroupBox1.Controls.Add(this.Address);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Aadhar);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Contact);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.pictureBox1);
            this.GroupBox1.Location = new System.Drawing.Point(1, -8);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GroupBox1.MaximumSize = new System.Drawing.Size(909, 528);
            this.GroupBox1.MinimumSize = new System.Drawing.Size(909, 528);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.GroupBox1.Size = new System.Drawing.Size(909, 528);
            this.GroupBox1.TabIndex = 28;
            this.GroupBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::helphub.Properties.Resources.DASHBOARD;
            this.pictureBox3.Location = new System.Drawing.Point(703, 15);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(224, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::helphub.Properties.Resources.LOGOUT;
            this.pictureBox2.Location = new System.Drawing.Point(752, 67);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(244, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::helphub.Properties.Resources.Support_service_with_headphones__Customer_Support_service_logo_template__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-70, -32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 243);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // COMPLAINT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(900, 479);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.GroupBox1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(916, 518);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(916, 518);
            this.Name = "COMPLAINT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMPLAINT - HELPHUB";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        public TextBox Aadhar;
        public TextBox Dcomplaint;
        public TextBox Address;
        public TextBox Contact;
        public Button Button1;
        public Label Label5;
        public Label Label4;
        public Label Label3;
        public Label Label2;
        public Label Label1;
        public ComboBox ComboBox1;
        public Label Label6;
        public Button Button2;
        public GroupBox GroupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}