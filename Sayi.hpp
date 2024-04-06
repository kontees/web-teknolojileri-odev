/**
 * @file1= Sayi.hpp
 * @description= sayi.cpp dosyasının hpp dosyası
 * @course= 2. öğretim c grubu
 * @assignment=1. ödev
 * @date1= 17.11.2023
 * @author1= Şevval Duygu Örklemez
 */

#ifndef Sayi_hpp
#define Sayi_hpp
#include "Basamak.hpp"
class Sayi
{
public:
    Sayi();
    ~Sayi();
    void ekle(int veri);
    void dosyadanOkuVeEkle(const char *dosyaAdi);
    void yazdir();
    void cikar();
    void enBuyuguSil();
    void temizle();
    void basamaklariTersCevir();
    void tekBasamaklariBasaAl();

    Basamak *ilk;
};

#endif