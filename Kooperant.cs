﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 using System.Data.SqlClient;

namespace Projekt
{
    public partial class Kooperant : Form
    {

        private const string ConnectionString = @"Data Source=DESKTOP-71KF32U;Initial Catalog=Baza;Integrated Security=True;Pooling=False";
        SqlConnection con = new SqlConnection(ConnectionString);
        public Kooperant()
        {
            InitializeComponent();
        }

        private void Izlaz(object sender, EventArgs e)
        {
            this.Hide();
            Narudzbenica otvori = new Narudzbenica();
            otvori.Show();
        }

        private void Spremi_KOP_Click(object sender, EventArgs e)
        {
            con.Open();


            string zadatak = "INSERT INTO Kooperant(OIB, Naziv,Adresa)  VALUES( "+this.OIB.Text+" ,'" + this.Naziv.Text + "','" + this.Adresa.Text +"'); ";
            SqlCommand cmd = new SqlCommand(zadatak, con);

            cmd.ExecuteNonQuery();
            
            
            con.Close();
            this.OIB.Text = "";
            this.Naziv.Text = "";
            this.Adresa.Text = "";

            

        }

            
    }
    
           






    
        
}
