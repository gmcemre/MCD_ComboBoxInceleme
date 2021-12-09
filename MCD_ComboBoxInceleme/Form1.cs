using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_ComboBoxInceleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Items.Add metodu kullanılarak değerler comboBox eklendi..
            //ComboBoxDoldurV1();
            ComboBoxDoldurV2();
        }

        private void ComboBoxDoldurV2()
        {
            cmbUrunListe.DataSource = database.UrunTablo;
        }

        private void ComboBoxDoldurV1()
        {
            foreach (var item in database.UrunTablo  )
            {
                cmbUrunListe.Items.Add(item);
            }
        }

        private void cmbUrunListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1.Yöntem
            object O1 = cmbUrunListe.SelectedItem;
            urun U1 = (urun)O1;

            //U1 = cmbUrunListe.SelectedItem == null ? null : cmbUrunListe.SelectedItem as urun;

            //2.Yöntem
            ComboBox secilenComboBox = sender as ComboBox;

            //1.Yöntem eğer form içerisinde bulunan form elemanına özel bir metot yazıldı ise o zaman ilgili fom elemanını direkt olarak çağırmak daha mantıklıdır.

            //2.Yöntem çalışma zamanında oluşturmuş olduğumuz form elemanlarından hangisine tıklandıldığını veya işlem yapıldığını bilmediğimiz için ve metodumuz birden fazla form elemanında olay metedu olarak tanımlandığı için biz sender üzerinden gelen nesneyi kullanır kullanıcının hangi windows form elemanında işlem yapmış olduğunu anlarız.

            pctUrunResim.Image = Image.FromFile(U1.urunResim);
            pctUrunResim.SizeMode = PictureBoxSizeMode.StretchImage;

            txtUrunAdi.Text = U1.urunAdi;
            txtUrunKategori.Text = U1.urunKategori;
            txtStokAdet.Text = U1.stokAdet.ToString();
            txtYazar.Text = U1.yazar;
            txtUrunAciklama.Text = U1.aciklama;
        }
    }
}
