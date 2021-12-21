using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_12_Cuma
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Database:objelerden oluşur.En önemli objesi tablodur(table) Çünkü datalar tableda tutulur.
            SQL-Server(Yapısal sorgulama dili)
            minimum tekrar,tutarlı veri

            tablolar(entity)
            1-1(tc kimlik numarası gibi bir insanda bir tane olur)
            1-m(bir tarafta karşısında çok var,2 arabamız olabilir gibi)
            m-m(öğrenci ders ilişkisi gibi,bir öğrenci birden çok ders alabilir.bi dersi birden çok öğrenci alabilir.)
            /*//*/Bir yerde m-m ilişki varsa ekstra bir tabloya(entity) ihtiyac vardır.
            ms-T SQL
            oracle-PI SQL
            *veriyi tutmak marifet değildir.veriyi daha sonra istediğimde ne kadar hızlı getiriyorum önemli olan o.
            Sıralı arama(tablescan):tek tek aramaya denir.
            algoritma çalışma mantığı
            98 milyarı arıyorum.elimdeki küme 1 ile 100milyar arasında.
            Kayıt kümesi sıralı olmalı.
            Yarısı olan 50milyarı bulduk.98 milyar sağında olduğu için solunu attık. Bu işlem terkrarlanır.
            

            T-SQL kodları kendi içinde ikiye ayrılır.
            1-DML(data manupilation language)                                       2-DDL(data definition language)
            DATAYI DEĞİŞTİRMEYLE İLGİLİ KOMUTLAR(data üzerinde çalışır)           | Veritabanı objeleri uzerinde çalışır.              
            1-SELECT(VAROLAN BİLGİLİ İSTENİLEN ŞEKİLDE SEÇMEK İÇİN KULLANILIR.)   | 1-CREATE                                                           
            2-İNSERT(HERHANGİ BİR TABLOYA VERİ EKLEMEK İÇİN KULLANILIR.)          | 2-ALTER 
            3-UPDATE(VAROLAN VERİYİ GÜNCELLEMEK İÇİN KULLANILIR.)                 | 3-DROP 
            4-DELETE(SİLMEK İÇİN KULLANILIR)                                      |  

            VERİ TABANINDA ASLA VERİ SİLİNMEMELİ**

            SQL             C#
            tinyint    =>   byte
            smallint   =>   short
            int        =>   int
            bigint     =>   long
            bit        =>   bool
            money      =>   decimal(virgülden sonra 4 "0" gelir.{,0000})
            decimal    =>   decimal
            
            
            char:(her karakter 1 byte)Boşluk karakteri kullanır.Onlar için de yer açar.Boşa yer kaplıyor.
            nchar:(her karakter 2 byte)Unicode
            varchar:(Ne kadar karakter girilirse o kadar yer açar)
            nvarchar:(Unicode)Alfabe farklı olursa kullanılır.
            varchar:(MAX)8000 karakter sınırı var.
            nvarchar:(MAX)4000 karakter sınırı var.
            smalldatetime:1900~2079 yılları arasında değer tutabiliyor.(2 byte)
            datetime:1700-9999 yılları arasında değer tutabiliyor.(8byte)
            datetime2:0-9999 yılları arasında değer tutabiliyor.






             */
        }
    }
}
