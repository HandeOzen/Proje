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
    class Sepet
    {
        public double kdvliToplamFiyat = 0;
        public string ad="";
        public int adet=0;
        
        public double kdvliToplamFiyatHesapla(CepTelefonu ceptelefonu,LedTv ledtv,Buzdolabi buzdolabi,Laptop laptop)
        {
            kdvliToplamFiyat = ceptelefonu.kdvUygula() + laptop.kdvUygula() + ledtv.kdvUygula() + buzdolabi.kdvUygula();
            return kdvliToplamFiyat;
        }
        
        public void sepeteUrunEkle(Urun urun)
        {
            ad = urun.ad;
            adet = urun.secilenAdet;       
        }
    }
}
