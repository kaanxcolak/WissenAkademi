﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AkbilYonetimiUI
{
    public partial class FrmAkbiller : Form
    {
        public FrmAkbiller()
        {
            InitializeComponent();
        }
        string baglantiCumlesi = @"Server=DESKTOP-P4SDEGD;Database=AKBILDB;Trusted_Connection=True;";

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //kontroller

                if (cmbBoxAkbilTipleri.SelectedIndex < 0)
                {
                    MessageBox.Show("Lütfen ekleyeceğiniz Akbilin türünü seçiniz! ");
                    return;
                }


                SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
                SqlCommand komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandType = CommandType.Text;
                komut.CommandText = "insert into Akbiller (AkbilNo,EklenmeTarihi,AkbilTipi,Bakiye,AkbilSahibiId,VizelendigiTarih) " +
                    "values (@akblNo,@ektrh,@tip,@bakiye,@sahibi,null)";
                komut.Parameters.AddWithValue("@akblNo", maskedTextBoxAkbilNo.Text);
                komut.Parameters.AddWithValue("@ektrh", DateTime.Now);
                komut.Parameters.AddWithValue("@tip", cmbBoxAkbilTipleri.SelectedItem);
                komut.Parameters.AddWithValue("@bakiye", 0);
                komut.Parameters.AddWithValue("@sahibi", Properties.Settings1.Default.KullaniciId); //
                //komut.Parameters.AddWithValue("@vizeTrh", null);



                baglanti.Open();
                if (komut.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Akbiliniz sisteme eklendi! ");
                    //Temizlik işlemi yapılacak
                    maskedTextBoxAkbilNo.Clear();
                    cmbBoxAkbilTipleri.SelectedIndex = -1;
                    cmbBoxAkbilTipleri.Text = "akbil türünü seçiniz...";
                    DataGridViewiDoldur();
                }
                else
                {
                    MessageBox.Show("Akbiliniz sisteme EKLENEMEDİ! ");
                }
                baglanti.Close();

            }
            catch (Exception hata)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu! " + hata.Message); ;
            }
        }

        private void FrmAkbiller_Load(object sender, EventArgs e)
        {
            cmbBoxAkbilTipleri.Text = "Akbil tipi seçiniz...";
            cmbBoxAkbilTipleri.SelectedIndex = -1;
            dataGridViewAkbiller.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewiDoldur();
        }

        private void DataGridViewiDoldur()
        {
            try
            {
                SqlConnection connection = new SqlConnection(baglantiCumlesi);
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = $"select * from Akbiller where AkbilSahibiId = @sahibi";
                command.Parameters.AddWithValue("@sahibi",
                    Properties.Settings1.Default.KullaniciId);
                //DataTable 
                //DataSet --> içinde birden çok datatable barındırır.
                //SQLDataAdapter --> adaptör sorgu sonucundaki verileri DataTable/Dataset DOLDURUR.(fiil)

                //SqlDataAdapter adp = new SqlDataAdapter(command);

                SqlDataAdapter adp = new SqlDataAdapter();

                adp.SelectCommand = command;
                DataTable dt = new DataTable();
                connection.Open();
                adp.Fill(dt);
                connection.Close();
                dataGridViewAkbiller.DataSource = dt;

                //bazı kolonlar gizlensin
                dataGridViewAkbiller.Columns["AkbilSahibiId"].Visible = false;
                dataGridViewAkbiller.Columns["VizelendigiTarih"].HeaderText = "Vizelendiği Tarih";
                dataGridViewAkbiller.Columns["VizelendigiTarih"].Width = 200;
            }
            catch (Exception hata)
            {
                MessageBox.Show("Akbilleri listeleyemedim !" + hata.Message);
            }
        }
    }
}
