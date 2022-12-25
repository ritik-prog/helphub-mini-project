﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using FluentValidation;



namespace helphub
{
    public partial class REGISTER : Form
    {
        public class RegisterUser
        {
            public string Contact { get; set; }
            public string username { get; set; }
            public string Password { get; set; }
            public string Aadhar { get; set; }
            public string Email { get; set; }
        }

        public class RegisterValidator : AbstractValidator<RegisterUser>
        {
            public RegisterValidator()
            {
                RuleFor(RegisterUser => RegisterUser.Email).NotNull().EmailAddress();
                RuleFor(RegisterUser => RegisterUser.Contact).NotNull().Matches("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,6}$");
                RuleFor(RegisterUser => RegisterUser.username).NotNull();
                RuleFor(RegisterUser => RegisterUser.Password).NotNull();
                RuleFor(RegisterUser => RegisterUser.Aadhar).NotNull().Matches("^[2-9]{1}[0-9]{3}\\s[0-9]{4}\\s[0-9]{4}$");
            }
        }

        public REGISTER()
        {
            InitializeComponent();
        }

        private async void Button2_Click(object sender, EventArgs e)
        {
            RegisterUser ruser = new RegisterUser();
            RegisterValidator validator = new RegisterValidator();

            ruser.Aadhar = Aadhar.Text;
            ruser.Contact = Contact.Text;
            ruser.Email = Email.Text;
            ruser.Password = Password.Text;
            ruser.username = username.Text;

            var result = validator.Validate(ruser);

            if (!result.IsValid)
            {
                String errors ="Kindly Solve Below Errors\n";
                int i = 1;
                foreach (var failure in result.Errors)
                {
                    errors = ""+ errors + " "+i+") Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage + "\n";
                    i++;
                }
                MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username.Text.Trim() == "" && Password.Text.Trim() == "" && Aadhar.Text.Trim() == "" && Contact.Text.Trim() == "" && Email.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
            string SQLitecnStr = @"Data Source=.\helphub.db";
            SQLiteConnection SQLiteConn = new SQLiteConnection();
            SQLiteCommand SQLitecmd = new SQLiteCommand();

            SQLiteConn.ConnectionString = SQLitecnStr;
            SQLiteConn.Open();

            SQLitecmd.Connection = SQLiteConn;

            SQLitecmd.CommandText = "insert into user(aadharno,username,mobilenumber,password,email) VALUES('"+Aadhar.Text+"','"+ username.Text +"','"+ Contact.Text +"','"+ Password.Text +"','"+ Email.Text +"')";

            try {
                SQLitecmd.ExecuteNonQuery();
                MessageBox.Show("Registered Succesfully", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LOGIN login = new LOGIN();

                login.Show();

                this.Hide(); //Close Form1,the current open form.
            }
            catch (SQLiteException ex)
            {
                    int code = ex.ErrorCode;

                    if (code == 19)
                    {
                        MessageBox.Show("Already Registered Username/Aadhar Number", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Database Error: Error code:- "+ code + ",Error message:- "+ ex.Message +"", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            catch (Exception ex)
            {
                    MessageBox.Show("Registration Failed: "+ ex.Message +"", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            SQLiteConn.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LOGIN login = new LOGIN();

            login.Show();

            this.Hide(); //Close Form1,the current open form.
        }
    }
}
