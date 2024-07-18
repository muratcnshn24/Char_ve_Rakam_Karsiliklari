using System;

namespace Char_ve_Rakam_Karsiliklari
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 32; i <= 126; i++)         // 32 den başlayıp 126ya kadar gitmeyi ifade ediyor. bu aralıkta klavyediki tüm karakterleri yazar.
            {
                Console.Write("{0,5}",(char)i);    //write yan yana yazdırır.  {0,5} rakalar arası boşluk
                if (i % 5 == 0) Console.WriteLine(); //5 Karakterde bir aşağıya satırı geçir.
            }
        }
    }
}
