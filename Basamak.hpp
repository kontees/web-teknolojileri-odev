/**
 * @file1= Basamak.hpp
 * @description= basamak.cpp dosyasının hpp dosyası
 * @course= 2. öğretim c grubu
 * @assignment=1. ödev
 * @date1= Kodu oluşturduğunuz Tarih
 * @author1= Şevval Duygu Örklemez
 */

#ifndef Basamak_hpp
#define Basamak_hpp

class BasamakDugum
{
public:
    int basamak;
    BasamakDugum *sonraki;
    int sayi;

    BasamakDugum(int basamak) : basamak(basamak), sonraki(nullptr) {}
};

class Basamak
{
public:
    int sayi;
    BasamakDugum *basamaklar;
    Basamak *sonraki;
    Basamak *basamakListesiSonraki;

    Basamak(int sayi);
    ~Basamak();
};

#endif
