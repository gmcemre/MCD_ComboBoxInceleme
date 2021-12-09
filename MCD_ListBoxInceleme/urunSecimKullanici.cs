﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_ListBoxInceleme
{
    public partial class urunSecimKullanici : Form
    {
        urun[] urunListe;
        public urunSecimKullanici(urun[] secilenUrunler)
        {
            InitializeComponent();
            urunListe = secilenUrunler;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void urunSecimKullanici_Load(object sender, EventArgs e)
        {
            foreach (var item in urunListe)
            {
                Button btn = new Button();
                btn.Text = item.urunAdi;
                btn.Name = "btn" + item.id.ToString();
                btn.Size = new System.Drawing.Size(122, 37);
                btn.Tag = item;
                btn.Click += Btn_Click;
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            urun u1 = btn.Tag as urun;
            Form F1 = Application.OpenForms["Form1"];
            GroupBox F1GBOX = (GroupBox)F1.Controls["groupBox1"];
            ((PictureBox)F1.Controls["pctUrunRessim"]).Image = Image.FromFile(u1.urunResim);
            ((TextBox)F1.Controls["txtUrunAdi"]).Text = u1.urunAdi;
            ((TextBox)F1.Controls["txtKategori"]).Text = u1.urunKategori;
            ((TextBox)F1.Controls["txtStokAdet"]).Text = u1.stokAdet.ToString();
            ((TextBox)F1.Controls["txtYazar"]).Text = u1.yazar;
            ((TextBox)F1.Controls["txtUrunAciklama"]).Text = u1.aciklama;
            this.Close();

        }
    }
}
