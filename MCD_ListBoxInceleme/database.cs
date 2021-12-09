using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_ListBoxInceleme
{
    public class database
    {
        public static List<urun> UrunTablo = new List<urun>()
        {
            new urun
            {
                id=1,
                urunAdi ="Serenad",
                stokAdet =10,
                urunKategori ="Roman",
                aciklama ="Her şey, 2001 yılının Şubat ayında soğuk bir gün, İstanbul Üniversitesi'nde halkla ilişkiler görevini yürüten Maya Duran'ın (36) ABD'den gelen Alman asıllı Profesör Maximilian Wagner'i (87) karşılamasıyla başlar.1930'lu yıllarda İstanbul Üniversitesi'nde hocalık yapmış olan profesörün isteği üzerine, Maya bir gün onu Şile'ye götürür. Böylece, katları yavaş yavaş açılan dokunaklı bir aşk hikâyesine karışmakla kalmaz, dünya tarihine ve kendi ailesine ilişkin birtakım sırları da öğrenir.",
                yazar="Zülfi Livaneli",
                urunResim =@"C:\Users\103AKSAM_EMRE\Desktop\1.jpg"
            },

            new urun
            {
                id=2,
                urunAdi ="Tutunamayanlar",
                stokAdet =20,
                urunKategori ="Roman",
                aciklama ="Tutunamayanlar Oğuz Atay ismiyle özdeşleşmiş bir roman olarak, büyük yazarımızın hayatından izler taşımasıyla da kısmen otobiyografik bir eser olarak da değerlendirilebilir. Roman, son derece üst düzey diliyle çevirisi en zor romanlar arasında yer alır.Tutunamayanlar, sadece birkaç dile çevrilebilmiştir. “Het levenin stukken” adı altında Flemenkçeye (Hollanda Dili) çevrilen eser, eserin Hollandalı çevirmenine ödül kazandırmıştır.",
                yazar="Oğuz Atay",
                urunResim =@"C:\Users\103AKSAM_EMRE\desktop\2.jpg"
            },

            new urun
            {
                id=3,
                urunAdi ="İz Bıraktığın Kadar Varsın",
                stokAdet =30,
                urunKategori ="Roman",
                aciklama ="NE KADAR İZ BIRAKIRSANIZ O KADAR VAZGEÇİLMEZ OLURSUNUZ.Kusursuz bir bütün için harikulade parçalar gerekir. Tıkırtıkır işleyen bir sistem ancak böyle yürür, bir kovandaki arıları ya da devasa bir karınca yuvasını düşünün. İlişkiler de böyledir, hiçbir şey tek başına tüm ilişkiyi ayakta tutmaya yetmez. Fırtınaya yakalanmış bir tekneye yelkenler tek başına yardımcı olamaz, sağlam bir motor, belki devreye girmesi gereken kürekler ve güvertede teknenin seyrini sağlayan hünerli birkaç insan lazımdır.",
                yazar="Esra Ezmeci",
                urunResim =@"C:\Users\103AKSAM_EMRE\desktop\3.jpg"
            }
        };

    }
}
