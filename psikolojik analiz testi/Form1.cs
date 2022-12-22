using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace psikolojik_analiz_testi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button7.Enabled = false;
        }
        int question = 0;
        int point = 0;
        private void gorunmez()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
        }
        private void button6_Click(object sender, EventArgs e)
        {
                button6.Text = "NEXT";
                button6.Enabled = false;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                question++;
            if (question == 1)
            {
                btntext.Text = "1) Sevgilinizle yada eşinizle 'MÜKEMMEL BİR AKŞAM'size aşağıdakilerden hangisiniz çağrıştırıyor?";
                button1.Text = "BİR ROCK KONSSERİNE GİTMEK";
                button2.Text = "LUNAPARKA GİTMEK";
                button3.Text = "SİNEAYA GİTMEK";
                button4.Text = "MUM IŞIĞINDA ROMANTİK YEMEK YEMEK";
                button5.Text = "ARABAYLA TURLAMAK";
            }
            if (question == 2)
            {
                btntext.Text = "2)En sevdiğiniz müzik türü hangisidir?";
                button1.Text = "ALTERNATİF";
                button2.Text = "ROCK AND ROLL";
                button3.Text = "SOFT ROCK";
                button4.Text = "POP";
                button5.Text = "KLASİK";
            }
            if (question == 3)
            {
                btntext.Text = "3)En çok hangi tür filmeleri izlersiniz?";
                button1.Text = "KORKU";
                button2.Text = "KOMEDİ";
                button3.Text = "MÜZİKAL";
                button4.Text = "ROMANTİK";
                button5.Text = "BELGESEL";
            }
            if (question == 4)
            {
                btntext.Text = "4)Aşağıdaki mesleklerden birini seçmek isteseydiniz hangisini seçerdiniz?";
                button1.Text = "BARMEN";
                button2.Text = "POLİS";
                button3.Text = "ÖĞRETMEN";
                button4.Text = "FUTBOLCU";
                button5.Text = "GARSON";
            }
            if (question == 5)
            {
                btntext.Text = "5)Bir saataboş vaktinizi değerlendirmek için hangisi uygun sizin için?";
                button1.Text = "İNTERNETE GİRMEK";
                button2.Text = "TV İZLEMEK";
                button3.Text = "DIŞARDA DOLAŞMAK";
                button4.Text = "ARKADAŞLARLA KAFEYE GİTMEK";
                button5.Text = "KİTAP OKUMAK";
            }
            if (question == 6)
            {
                button7.Enabled = false;
                btntext.Text = "6)Aşağıdaki renklerden birini seçiniz";
                button1.Text = "KIRMIZI";
                button2.Text = "KAHVERENGİ";
                button3.Text = "SARI";
                button4.Text ="MAVİ";
                button5.Text = "PEMBE";
            }
            if (question == 7)
                
            {
                button7.Enabled = false;
                btntext.Text = "7)Şuan aşağıdaki yiyeceklerden hangisi olsa dayanamayıp yerdiniz?";
                button1.Text = "SUŞİ";
                button2.Text = "DONDURMA";
                button3.Text = "MAKARNA";
                button4.Text = "PİZZA";
                button5.Text = "HAMBURGER";
            }
            if (question == 8)
            {
                button7.Enabled = false;
                btntext.Text = "8)En sevdiğiniz tatil,bayram yada özel gün hangisidir";
                button1.Text = "23 NİSAN COCUK BAYRAMI";
                button2.Text = "YILBAŞI TATİLİ";
                button3.Text = "RAMAZAN BAYRAMI";
                button4.Text = "SEVGİLİLER GÜNÜ";
                button5.Text = "ANNE/BABA'LAR GÜNÜ"; ;
            }
            if (question == 9)
            {
                button7.Enabled = false;
                btntext.Text = "9)Şuan aşağıdakilerden hangisinde olmak isterdin";
                button1.Text = "LAS VEGAS'TA";
                button2.Text = "HAWAİİ'DE";
                button3.Text = "HOLLYWOOD'TA";
                button4.Text = "PARİS'TE";
                button5.Text = "MALDİVLER'DE";
            }
            if (question == 10)
            {
                button7.Enabled = false;
                btntext.Text = "10)Nasıl biri ile vakit geçirmek istersin?";
                button1.Text = "BİR PARTİ CANAVARIYLA";
                button2.Text = "GÜZEL/YAKIŞIKLI BİRİYLE";
                button3.Text = "KAMİK BİRİYLE";
                button4.Text = "DUYGUSAL BİRİYLE";
                button5.Text = "ENERJİK BİRİYLE";
            }
            if (question == 11)
            {
                button7.Enabled = false;
                button6.Enabled = true;
                button6.Text = "FİNİSHED";
                button6.Text = "VIEW MY SCORE";
                label3.Text = "YOUR TEST IS FINISHED THANK YOU";
            }
            if (question == 12)
            {
                button7.Enabled = false;
                label2.Text = point.ToString();
                button7.Enabled = true;   
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            point = point + 1;
            gorunmez();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            point = point + 2;
            gorunmez();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            point = point + 3;
            gorunmez();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            point = point + 4;
            gorunmez();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            point = point + 5;
            gorunmez();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;

            if (point >= 10 && point <= 17)
            {
                btntext .Text = "Vahşi ve çılgın birisiniz eğleniyim derken uçuyorsunuz.Ama her zaman ne yaptığınızın farkındasınız,hayatınızın kontrölünü kaybetmiyorsunuz.İnsanlar olaylara sizin gibi bakmıyorsa bu sizi durdurmuyor. SİZE TAVSİYEMİZ:Bu vahşi karakteriinizle kendinizi ve etrafınızdakileri incitebilirisniz DİKKATLİ OLUN!!!";
            }
            if (point >= 18 && point <= 26)
            {
                btntext.Text = "Siz eğlenceli,arkadaş canlısı ve popülersiniz.Cıvıl cıvıl halinizle etrafa neşe saçıyorsunuz.Çoğu zaman ikili ilişkilerinizde uçuk kaçık davranırsanızda inandığınız değerlerden asl taviz vermiyorsunuz. Evlilik ve çocuk sahibi olmak önemli ama öncelikle yeterince tecrübe edinmek istiyorsunuz. SİZE TAVSİYEMİZ:İNSANLARIN ALDIĞINIZ KARARLARDA SİZİ FAZLA ETKİLEMELERİNE İZİN VERMEYİN!!!";

            }
            if (point >= 27 && point <= 34)
            {
                btntext.Text = "Öyle tatlısınız ki sizi sevmemek imkansız.Siz insanların asla kaybetmek istemeyeceği türden bir dostsunuz. kimseyi incitmemek için kendinizi incittiğiniz bile oluyor. Siz genellikle olaylar karşısınds olgun ve sakin bir tavır takınırsınız. SİZE TAVSİYEMİZ: Herkes göründüğü gibi dağildir,bunu unutmayın.biraz kurnaz olun!!!";

            }
            if (point >= 35 && point <= 42)
            {
                btntext.Text = "Siz iflah olmaz bir romantiksiniz.Şarap,kırmızı güller ,bunlar sizin  yaşam tarzınz.Söz verirseniz ve o sözü ne olursa olsun yerine getirirseniz.Ailenize çok bağlısınız.Annenizi her haftasonu ararsınız,özel günleri asla unutmazsınız. SİZE TAVSİYEMİZ:Fazla romantizmin sizi gerçekten uzaklaitırmasına izin vermeyin!!!";

            }
            if (point >= 43 && point <= 70)
            {
                btntext.Text = "Belirgin özelliğiniz hızlı ve doğru karar verebilmeniz.Herolayiçin kafanıza bir planınız vardır.Fiziksel ve zihinsel gücünüz çok fazla.Mantıklı,ılımlı ve yapıcı tavırarıyla çoğu kişinin kandine örnek aldığı birisiniz. SİZE TAVSİYEMİZ:Küçük gibi görünen bazı olayları gözardı etmeniz ilerlde büyük sorunlara yol açabilir!!! ";
            }
            button7.Enabled = false;
        }
    }
}
