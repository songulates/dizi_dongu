using System;
namespace console_programlama
{ 
    class Program
    {
        static void Main(string[] args)//
        {
            string[] renkler=new string[5];
            string[] hayvanlar={"kedi","kuş","panda"};
            int[] dizi;
            dizi=new int[5];
            renkler[0]="red";
            dizi[3]=10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(hayvanlar[2]);
            //klavyeden girilen n tane sayının ortalamasını alan program
            Console.WriteLine("dizi eleman sayisini girin");
            int dizi_eleman=int.Parse(Console.ReadLine());
            int[] sayidizisi=new int[dizi_eleman];
            for (int i = 0; i < dizi_eleman; i++)
            {
                 Console.WriteLine("{0}.sayiyi girin : ",i+1);
                 sayidizisi[i]=int.Parse(Console.ReadLine());
                
            }
            int toplam=0;
            foreach (var sayi in sayidizisi)
                toplam+=sayi;
            Console.WriteLine("ortalama: " + toplam/dizi_eleman);
        }
    }
}