/**
 * @file1= Basamak.cpp
 * @description= basamak.cpp dosyası gerekli fonksiyonlar
 * @course= 2. öğretim c grubu
 * @assignment=1. ödev
 * @date1= 17.11.2023
 * @author1= Şevval Duygu Örklemez
 */

#include "Basamak.hpp"

Basamak::Basamak(int sayi) : sayi(sayi), basamaklar(nullptr), sonraki(nullptr)
{

    int gecici1 = sayi;
    BasamakDugum *oncekiBasamak = nullptr;

    while (gecici1 > 0)
    {
        int basamak = gecici1 % 10;
        BasamakDugum *yeniBasamak = new BasamakDugum(basamak);
        yeniBasamak->sonraki = oncekiBasamak;
        oncekiBasamak = yeniBasamak;
        gecici1 /= 10;
    }
    basamaklar = oncekiBasamak;
}

Basamak::~Basamak()
{

    BasamakDugum *basamakGecici = basamaklar;
    while (basamakGecici != nullptr)
    {
        BasamakDugum *basamakSil = basamakGecici;
        basamakGecici = basamakGecici->sonraki;
        delete basamakSil;
    }
}