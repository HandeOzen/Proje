/****************************************************************************
**                        SAKARYA ÜNİVERSİTESİ
**            BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**              BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                NESNEYE DAYALI PROGRAMLAMA DERSİ
**                    2019-2020 BAHAR DÖNEMİ
**
**           PROJE NUMARASI.........: 01
**           ÖĞRENCİ ADI............:HANDE ÖZEN
**           ÖĞRENCİ NUMARASI.......:B181200048
**           DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ndp_Odev3
{
    class Urun
    {
       Random rand = new Random();
       public string ad;
       public string marka;
       public string model;
       public string ozellik;
       public int stokAdedi;
       public double hamFiyat;
       public int secilenAdet;

        public Urun()
        {
            stokAdedi = rand.Next(1, 100);
        }  
    }
}
