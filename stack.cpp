/**
* @file stack.cpp
* @description main içersinde stack ile ilgili fonksiyonlar
* @course 2. öğretim C grubu
* @assignment 2. ödev
* @date 17.12.2023
* @author şevval duygu örklemez
*/





#include <iostream>
#include <fstream>
#include <sstream>
#include <set>
#include "stack.hpp"
#include "AVLTree.hpp"

Stack::Stack()
{
    kapasite = 200;
    veriler = new int[kapasite];
    topIndex = -1;
    maxTopIndex = topIndex;
}

Stack::~Stack()
{
    delete[] veriler;
}

void Stack::renewStack(AVLTree *avlTree)
{
    /*// 1. Mevcut veri dizisini sil
    delete[] veriler;

    // 2. Başlangıç kapasitesine dön
    kapasite = 5;

    // 3. Yeni bir veri dizisi oluştur
    veriler = new int[kapasite];

    // 4. Yığıtın boyutunu sıfırla
    topIndex = -1;
    maxTopIndex = topIndex;

    // 5. Yeni bir stack oluşturarak yaprakları ekleyin
    // Stack *yeniStack = rebuildStack(avlTree);

    // 6. Yeni stack'i ve eski stack'i takas yapın
    std::swap(*this, *yeniStack);

    // 7. Eski stack'i silin
    delete yeniStack;*/
}
void Stack::clear()
{
    topIndex = -1;
    maxTopIndex = topIndex;
    // Dizi bellekten silinmese de, tekrar kullanılabilir.
    // Eğer tüm belleği serbest bırakmak istiyorsanız,
    // delete[] veriler; satırını da ekleyebilirsiniz.
}

void Stack::push(int value)
{
    topIndex++;
    if (topIndex == kapasite)
        expand();
    veriler[topIndex] = value;
    maxTopIndex = topIndex;
}

void Stack::rebuildStack(AVLTree *avlTree)
{
    // Yeni bir stack oluştur
    delete[] avlTree->stack->veriler;
    // Yaprakları postorder olarak ekleyin
    avlTree->postorderTraversalForStack(avlTree->root, avlTree->stack);
}

void Stack::pop()
{
    topIndex--;
}

int Stack::top()
{
    if (!empty())
    {
        return veriler[topIndex];
    }
    return 0; // veya başka bir değer dönebilirsiniz
}

bool Stack::empty()
{
    return topIndex == -1;
}

void Stack::expand()
{
    int *newDatas = new int[kapasite + 5];
    for (int i = 0; i <= topIndex; i++)
    {
        newDatas[i] = veriler[i];
    }
    delete[] veriler;
    veriler = newDatas;
    kapasite += 5; // Kapasiteyi artır
}
