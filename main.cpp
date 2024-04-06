/**
 * @file1= main.cpp
 * @description= kullanıcının menüden fonksiyonları seçtiği cpp dosyam
 * @course= 2. öğretim c grubu
 * @assignment=1. ödev
 * @date1= 17.11.2023
 * @author1= Şevval Duygu Örklemez
 */

#include <iostream>
#include <iomanip>
#include "Sayi.hpp"
#include "Basamak.hpp"
using namespace std;

int main()
{
    Sayi liste;

    liste.dosyadanOkuVeEkle("sayilar.txt");

    liste.yazdir();

    int secim;

    do
    {
        std::cout << "---------------------MENU------------------------------------------" << std::endl;
        std::cout << "\t 1-) Tek basamaklari basa al" << std::endl;
        std::cout << "\t 2-) En buyuk sayiyi listeden cikar" << std::endl;
        std::cout << "\t 3-) Sayilarin basamaklarini tersten yaz" << std::endl;
        std::cout << "\t 4-) Cikis" << std::endl;
        std::cout << "\t Lutfen seciminizi yapin" << std::endl;
        std::cout << "------------------------------------------------------------------" << std::endl;
        std::cin >> secim;

        switch (secim)
        {
        case 1:
            liste.tekBasamaklariBasaAl();
            break;

        case 2:
            liste.enBuyuguSil();
            break;

        case 3:
            liste.basamaklariTersCevir();
            break;

        case 4:
            std::cout << "Programdan cikiliyor..." << std::endl;
            break;

        default:
            std::cout << "Gecersiz bir secim yaptiniz. Lutfen tekrar deneyin." << std::endl;
            break;
        }

    } while (secim != 4);

    return 0;
}
