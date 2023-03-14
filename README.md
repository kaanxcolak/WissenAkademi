Wissen Akademi
=========================
Wissen Akademi ile aldığımız C# eğitiminde yaptğımız çalışmalar ve teknik bazı bilgiler.

-------------------------

## Notlar

> **1)** signed int aynı zamanda negatif değerleride tutabiliyorken uint sadece 0 ve pozitif değerleri tutar.
-------------------------
> **2)** &(Bitwise and) ve &&(Kısa devre ve) arasındaki fark; & hem bitsel hemde mantıksal bir operatör iken && sadece mantıksal operatördür. & ifadenin her iki tarafını değerlendirirken, && işleci ise son sonucu ifade etmek için ifadenin yalnızca sol tarafını değerlendirir.
-------------------------
> **3)** string path = @"c:\new\falan.txt"; 
>> @ işareti escape sequances kısmını normal karakter olarak algılanmasını sağlıyor.
-------------------------
> **4)** Dizi aynı tipteki değişkenleri ya da verileri bir arada tutabildiğimiz bir yapıdır.
-------------------------
> **5)** int[] yeniSayilar = sayilar[0..^3];  
>> 0'dan 3. indexe kadar 3(dahil değil) elemanları yeni diziye aktarır.
-------------------------
> **6)** bool xorDeneme = true ^ false; 
>> true döner. 
-------------------------
> **7)** string sonuc = sayi2 % 2 == 0 ? "Çift" : "Tek"; 
>> Ternary if!
-------------------------
> **8)** recursive function -  özyinelemeli yani kendi kendini yineliyor.
-------------------------
> **9)** ref-out kullanımı; referans yolu ile metoda parametre olarak geçtiğimiz değişken üzerinde yapılacak bütün değişiklikler orjinal değeri etkileyecektir 
çünkü artık o metod içerisinde değişkenin bir kopyası değilde RAM'de ki adresi bulunmaktadır. out anahtar sözcüğü iki veya daha fazla geriye döndürmek istediğimizde kullandığımız bir anahtar sözcüktür. ref parametresi de aynı işlemi gerçekleştirebilir.
-------------------------
> **10)** property yazımında isim büyük harfle başlar! get okur ve dışarı aktarır(output), set ise üzerinde işlem yapmamızı sağlar(input). 
-------------------------
> **11)** Full Property 1adet field'ın encapsule edilmesi ile oluşur.
-------------------------
> **12)** public DateTime IslemTarihi { get; private set; } = DateTime.Now;
>> Auto Property!
-------------------------
> **13)** public int Yas => DateTime.Now.Year - this.DogumTarihi.Year;
>> Readonly property - Sadece okuma
-------------------------
> **14)** _Ad.Substring(0, 1).ToUpper() + _ad.Substring(1).ToLower(); 
>> Substring içindeki 2.parametre 1 adet al anlamında!(0 dan başla 1 adet al).
-------------------------
> **15)** Tc kimlik numarası veya telefon int alınmaz. String olarak düşünülmesi gerekir!
-------------------------
> **16)** 
>- 1 nibble = 4 bit
>- 1 byte = 8 bit
>- 1 kB = 2^10 byte = 1024 byte
>- 1 MB = 1024 kB = 2^20 byte = 1048576 byte
>- 1 GB = 1024 MB = 2^30 byte = 1073741824 byte
>- 1 TB = 1024 Gb = 2^40 byte = 1099511627776 byte
>- 1 PB = 1024 TB = 2^50 byte = 1125899906842624 byte
>- 1 EB = 1024 PB = 2^60 byte = 1152921504606846976 byte
-------------------------
> **17)** Bilgisayarın; aynı önceliğe sahip işlemleri gerçekleştirme sırası, soldan sağa (baştan sona) doğrudur.
-------------------------
> **18)** Herhangi bir komut kullanmadan büyük-küçük harf dönüşümü yapmak için, ilgili harfin ,ASCII koduna 32 eklenebilir/çıkarılabilir.
-------------------------
> **19)** 
>- Bütün koşullar sağlanması gerektiğinde 'VE',
>- Koşullardan herhangi birinin sağlanması yeterli olduğunda 'VEYA' ,
>- Koşulu sağlamayan gerektiğinde ise koşulun başına 'DEĞİL' yazılır.
-------------------------
> **20)** Mantıksal işlemlerde 'n' tane koşul/değişken varsa, '2^n' tane farklı durum oluşur.
-------------------------
> **21)** Programlarda ne kadar az işlem varsa, o kadar hızlı çalışacaklarını unutmayalım.
-------------------------
> **22)** Programlardaki sayısal verilerde herhangi bir taban belirtme simgesi yoksa 10 tabanında(decimal) kabul edilirler.
-------------------------
> **23)** üstel belirtme biçimi olan "sayıeüs" veya "sayıEüs" anlamı "sayı.10^üs" tür.
-------------------------
> **24)** Programlarda sayısal veriler doğrudan, alfasayısal veriler ise tek/çift tırnak içinde gösterilirler.
-------------------------
> **25)** Çarpım değişkenine, başlangıç değeri olarak çarpma işleminin etkisiz elemanı olan 1 atanır.
-------------------------
> **26)** enum temelRenkler {kırmızı,yeşil, mavi} ----> enum; numaralandırma/sıralama tiplerinin (kümelerin) tanımlandığı kısımdır.
-------------------------
> **27)** string'i int'e dönüştürmek ----> System.Int32.Parse("42");
-------------------------
> **28)** string'i int'e dönüştürmek ----> System.Int32.Parse("42");