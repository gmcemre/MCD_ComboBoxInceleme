using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //listBoxDoldurV1();
            listBoxDoldurV2();
        }

        private void listBoxDoldurV2()
        {
            lstUrunler.DisplayMember = "urunAdi";
            //lstUrunler.ValueMember  = "id";
            lstUrunler.DataSource   = database.UrunTablo ;

        }

        private void listBoxDoldurV1()
        {
            foreach (var item in database .UrunTablo )
            {
                lstUrunler.Items.Add(item);
            }
        }

        private void lstUrunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int urunSecimAdet = lstUrunler.SelectedItems.Count;
            if (urunSecimAdet ==1)
            {
                ListBox lbox = (ListBox )sender;
                //lbox = sender as ListBox;
                urun U1 = (urun)lbox.SelectedItem;

                pctUrunResim.Image = Image.FromFile(U1.urunResim);
                pctUrunResim.SizeMode  = PictureBoxSizeMode.StretchImage;

                txtUrunAdi.Text = U1.urunAdi;
                txtUrunKategori.Text = U1.urunKategori;
                txtStokAdet.Text = U1.stokAdet.ToString ();
                txtYazar.Text = U1.yazar;
                txtUrunAciklama.Text = U1.aciklama;

            }
        }

        
    }
}
