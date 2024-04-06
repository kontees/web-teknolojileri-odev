/**
 * @file1= Sayi.cpp
 * @description= işlemleri yapan fonksiyonlar
 * @course= 2. öğretim c grubu
 * @assignment=1. ödev
 * @date1= 17.11.2023
 * @author1= Şevval Duygu Örklemez
 */

#include "Sayi.hpp"
#include <iostream>
#include <iomanip>
#include <fstream>
#include <sstream>
#include <climits>

Sayi::Sayi()
{
    ilk = nullptr;
}

Sayi::~Sayi()
{
    Basamak *gecici = ilk;

    while (gecici != nullptr)
    {
        Basamak *silinecek = gecici;
        gecici = gecici->sonraki;
        delete silinecek;
    }
}

void Sayi::ekle(int veri)
{
    Basamak *yeni = new Basamak(veri);
    if (ilk == nullptr)
    {
        ilk = yeni;
        return;
    }

    Basamak *gecici = ilk;
    while (gecici->sonraki != nullptr)
        gecici = gecici->sonraki;
    gecici->sonraki = yeni;
}

void Sayi::yazdir()
{
    using namespace std;

    Basamak *gecici = ilk;
    while (gecici != nullptr)
    {
        cout << "########### *********      *********     *********    *********" << endl;
        cout << "#" << &gecici->basamaklar << " #";

        BasamakDugum *basamakGecici = gecici->basamaklar;
        while (basamakGecici != nullptr)
        {
            cout << "  " << basamakGecici << setw(4) << "  ";
            basamakGecici = basamakGecici->sonraki;
        }
        cout << endl;
        cout << "#---------# *********      *********     *********    *********" << endl;
        cout << "#" << setw(3) << gecici->sayi << setw(6) << "     #";

        basamakGecici = gecici->basamaklar;
        while (basamakGecici != nullptr)
        {
            cout << "     " << basamakGecici->basamak << setw(14);
            basamakGecici = basamakGecici->sonraki;
        }

        cout << endl;
        cout << "########### *********      *********     *********    *********" << endl;

        cout << endl;
        cout << "-------------------------------------------------------------------" << endl;
        cout << endl;
        cout << endl;
        gecici = gecici->sonraki;
    }
}

void Sayi::temizle()
{
    while (ilk != nullptr)
    {
        cikar();
    }
}

void Sayi::enBuyuguSil()
{
    using namespace std;

    Basamak *gecici = ilk;
    Basamak *enBuyukSayi = nullptr;
    int maxSayi = INT_MIN;

    // En büyük sayı
    while (gecici != nullptr)
    {
        if (gecici->sayi > maxSayi)
        {
            maxSayi = gecici->sayi;
            enBuyukSayi = gecici;
        }
        gecici = gecici->sonraki;
    }

    if (enBuyukSayi != nullptr)
    {

        if (enBuyukSayi == ilk)
        {
            ilk = ilk->sonraki;
        }
        else
        {

            gecici = ilk;
            while (gecici->sonraki != enBuyukSayi)
            {
                gecici = gecici->sonraki;
            }
            gecici->sonraki = enBuyukSayi->sonraki;
        }

        BasamakDugum *basamakGecici = enBuyukSayi->basamaklar;
        while (basamakGecici != nullptr)
        {
            BasamakDugum *temp = basamakGecici;
            basamakGecici = basamakGecici->sonraki;
            delete temp;
        }

        delete enBuyukSayi;
    }

    else
    {
        cout << "Listede silinecek eleman yok." << endl;
        return;
    }

    int yeniSayi = 0;
    BasamakDugum *duzenlenmisGecici = enBuyukSayi->basamaklar;
    while (duzenlenmisGecici != nullptr)
    {
        yeniSayi = yeniSayi * 10 + duzenlenmisGecici->basamak;
        duzenlenmisGecici = duzenlenmisGecici->sonraki;
    }

    gecici = ilk;
    while (gecici != nullptr)
    {
        cout << "########### *********      *********     *********    *********" << endl;
        cout << "#" << &gecici->basamaklar << " #";

        yeniSayi = 0;

        BasamakDugum *basamakGecici = gecici->basamaklar;
        while (basamakGecici != nullptr)
        {
            yeniSayi = yeniSayi * 10 + basamakGecici->basamak;
            cout << "  " << basamakGecici << setw(4) << "  ";
            basamakGecici = basamakGecici->sonraki;
        }
        cout << endl;
        cout << "#---------# *********      *********     *********    *********" << endl;
        cout << "#" << setw(3) << yeniSayi << setw(6) << "     #";

        basamakGecici = gecici->basamaklar;

        while (basamakGecici != nullptr)
        {
            cout << "    " << basamakGecici->basamak << setw(14);
            basamakGecici = basamakGecici->sonraki;
        }

        cout << endl;
        cout << "########### *********      *********     *********    *********" << endl;

        cout << endl;
        cout << "-------------------------------------------------------------------" << endl;
        cout << endl;
        cout << endl;

        gecici = gecici->sonraki;
    }
}

void Sayi::tekBasamaklariBasaAl()
{
    Basamak *gecici = ilk;

    while (gecici != nullptr)
    {
        using namespace std;

        BasamakDugum *tekBasamaklar = nullptr;
        BasamakDugum *ciftBasamaklar = nullptr;

        while (gecici->basamaklar != nullptr)
        {
            BasamakDugum *basamak = gecici->basamaklar;
            gecici->basamaklar = gecici->basamaklar->sonraki;

            if (basamak->basamak % 2 == 1)
            {
                basamak->sonraki = tekBasamaklar;
                tekBasamaklar = basamak;
            }
            else
            {
                basamak->sonraki = ciftBasamaklar;
                ciftBasamaklar = basamak;
            }
        }

        // Tek basamakları başa
        gecici->basamaklar = tekBasamaklar;

        // Cift basamakları sona
        if (gecici->basamaklar == nullptr)
        {
            gecici->basamaklar = ciftBasamaklar;
        }
        else
        {
            BasamakDugum *sonraki = gecici->basamaklar;
            while (sonraki->sonraki != nullptr)
                sonraki = sonraki->sonraki;
            sonraki->sonraki = ciftBasamaklar;
        }

        int yeniSayi = 0;
        BasamakDugum *duzenlenmisGecici = gecici->basamaklar;
        while (duzenlenmisGecici != nullptr)
        {
            yeniSayi = yeniSayi * 10 + duzenlenmisGecici->basamak;
            duzenlenmisGecici = duzenlenmisGecici->sonraki;
        }

        cout << "########### *********      *********     *********    *********" << endl;
        cout << "#" << &gecici->basamaklar << " #";

        BasamakDugum *duzenlenmisGecici2 = gecici->basamaklar;
        while (duzenlenmisGecici2 != nullptr)
        {
            cout << "  " << duzenlenmisGecici2 << setw(4) << "  ";
            duzenlenmisGecici2 = duzenlenmisGecici2->sonraki;
        }
        cout << endl;

        cout << "#---------# *********      *********     *********    *********" << endl;
        cout << "#" << setw(3) << yeniSayi << setw(6) << "     #";

        duzenlenmisGecici2 = gecici->basamaklar;
        while (duzenlenmisGecici2 != nullptr)
        {
            cout << "  " << duzenlenmisGecici2->basamak << setw(14);
            duzenlenmisGecici2 = duzenlenmisGecici2->sonraki;
        }

        cout << endl;
        cout << "########### *********      *********     *********    *********" << endl;

        cout << endl;
        cout << "-------------------------------------------------------------------" << endl;
        cout << endl;
        cout << endl;

        if (gecici->sonraki == nullptr)
            break;

        gecici = gecici->sonraki;
    }
}

void Sayi::cikar()
{
    if (ilk == nullptr)
        return;

    if (ilk->sonraki == nullptr)
    {
        delete ilk;
        ilk = nullptr;
    }
    else
    {
        Basamak *gecici = ilk;

        while (gecici->sonraki->sonraki != nullptr)
        {
            gecici = gecici->sonraki;
        }

        delete gecici->sonraki;
        gecici->sonraki = nullptr;
    }
}

void Sayi::basamaklariTersCevir()
{
    using namespace std;
    Basamak *gecici = ilk;

    while (gecici != nullptr)
    {
        cout << "########### *********      *********     *********       *********" << endl;
        cout << "#"
             << &gecici->basamaklar
             << " #";

        BasamakDugum *onceki = nullptr;
        BasamakDugum *geciciBasamaklar = gecici->basamaklar;

        BasamakDugum *temp = nullptr;

        while (geciciBasamaklar != nullptr)
        {
            temp = geciciBasamaklar->sonraki;
            geciciBasamaklar->sonraki = onceki;
            onceki = geciciBasamaklar;
            geciciBasamaklar = temp;
        }

        int yeniSayi = 0;
        BasamakDugum *duzenlenmisOnceki = onceki;

        while (duzenlenmisOnceki != nullptr)
        {
            yeniSayi = yeniSayi * 10 + duzenlenmisOnceki->basamak;
            duzenlenmisOnceki = duzenlenmisOnceki->sonraki;
        }

        // Ters çevrilen basamaklar
        BasamakDugum *baslangicOnceki = onceki;

        while (onceki != nullptr)
        {
            cout << "  " << onceki << setw(5) << "  ";
            onceki = onceki->sonraki;
        }

        cout << endl;
        cout << "#---------# *********      *********     *********       *********" << endl;
        cout << "#" << setw(3) << yeniSayi << setw(6) << "   #";

        onceki = baslangicOnceki;
        while (onceki != nullptr)
        {
            cout << "    " << onceki->basamak << setw(14);
            onceki = onceki->sonraki;
        }
        cout << endl;
        cout << "########### *********      *********     *********       *********" << endl;

        cout << endl;
        cout << "-------------------------------------------------------------------" << endl;
        cout << endl;
        cout << endl;
        gecici = gecici->sonraki;
    }
}

void Sayi::dosyadanOkuVeEkle(const char *dosyaAdi)
{
    using namespace std;
    ifstream dosya(dosyaAdi);

    if (!dosya.is_open())
    {
        cerr << "Dosya acilamadi: " << dosyaAdi << endl;
        return;
    }

    string satir;
    getline(dosya, satir);

    istringstream iss(satir);

    int sayi;
    while (iss >> sayi)
    {
        ekle(sayi);
    }

    dosya.close();
}
