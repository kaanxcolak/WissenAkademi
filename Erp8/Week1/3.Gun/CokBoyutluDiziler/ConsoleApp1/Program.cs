 Console.WriteLine("Çok Boyutlu Diziler");

int[,] dizi = new int[2, 3];
int[,,] dizi2 = new int[3, 3, 3];

dizi[0, 0] = 1;
dizi[0, 1] = 2;
dizi[1, 0] = 3;
dizi[1, 1] = 4;

Random rnd = new();
for (int i = 0; i < dizi.GetLength(0); i++)
{
    for (int j = 0; j < dizi.GetLength(1); j++)
    {

        Console.WriteLine(dizi[i, j]); 
    }
}

Console.ReadKey();

//Ödev1- cin ali döngülerle  yapılacak. İki boyutlu dizi de kullanılıcak
//Ödev2- Adam asmaca; harf sayısına göre 7*100 puan  sorudizisi yazılacak kelimeler için--- tahminler de metot kullanılacak
//hak=6


