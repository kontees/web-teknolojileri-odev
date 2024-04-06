/**
 * @file main.cpp
 * @description işlemleri yapan döngüler
 * @course 2. öğretim C grubu
 * @assignment 2. ödev
 * @date 17.12.2023
 * @author şevval duygu örklemez
 */

#include <iostream>
#include <fstream>
#include <sstream>
#include "stack.hpp"
#include "AVLTree.hpp"
#include <iomanip>

using namespace std;

void AVLyazdir(AVLTree **avltrees, int lineCount)
{
    for (int i = 0; i < lineCount; i++)
    {
        if (avltrees[i] != 0)
            cout << avltrees[i]->Harf;
    }
}
void postorder(AVLNode *node)
{
    if (node != 0)
    {
        postorder(node->sol);
        postorder(node->sol);
        cout << node->deger << "  ";
    }
}

int main()
{
    ifstream dosya("Veri.txt");
    if (!dosya.is_open())
    {
        cout << "Dosya acilamadi." << endl;
        return 1;
    }
    string satir = "";
    int lineCount = 0;
    while (getline(dosya, satir))
    {
        lineCount++;
    }
    int index = 0;
    dosya.close();
    dosya.open("Veri.txt");
    AVLTree **avlTrees = new AVLTree *[lineCount];
    while (getline(dosya, satir))
    {
        AVLTree *currentAVL = new AVLTree();
        Stack *yaprakYigin = new Stack();
        currentAVL->stack = yaprakYigin;
        istringstream ss(satir);
        int deger = 0;
        while (ss >> deger)
        {
            currentAVL->root = currentAVL->AVLNodeEkle(currentAVL->root, deger);
        }
        currentAVL->AvlHarfiBul(currentAVL->root);
        currentAVL->AVLPostorderYapraklariYiginaEkle(currentAVL->root, yaprakYigin);
        currentAVL->Harf = currentAVL->avlDugumToplam % (90 - 65 + 1) + 65;
        avlTrees[index] = currentAVL;
        index++;
        currentAVL->AVLNO = index;
    }
    system("PAUSE");
    dosya.close();

    while (lineCount > 1)
    {
        int smallIndex = -1;
        int bigIndex = -1;
        int smallestNumber = 21470000;
        int biggestNumber = -21470000;

        for (int i = 0; i < index; i++)
        {
            if (avlTrees[i] != 0)
            {
                if (avlTrees[i]->stack->top() < smallestNumber)
                {
                    smallestNumber = avlTrees[i]->stack->top();
                    smallIndex = i;
                }
            }
        }
        avlTrees[smallIndex]->stack->pop();
        if (avlTrees[smallIndex]->stack->empty())
        {
            delete avlTrees[smallIndex];
            avlTrees[smallIndex] = 0;
            lineCount--;
            // system("CLS");
            for (int i = 0; i < index; i++)
            {
                if (avlTrees[i] != 0)
                {
                    avlTrees[i]->stack->renewStack(avlTrees[i]);
                }
            }
            AVLyazdir(avlTrees, index);
            system("CLS");
            continue;
        }
        for (int i = 0; i < index; i++)
        {
            if (avlTrees[i] != 0)
            {
                if (avlTrees[i]->stack->top() > biggestNumber)
                {
                    biggestNumber = avlTrees[i]->stack->top();
                    bigIndex = i;
                }
            }
        }
        avlTrees[bigIndex]->stack->pop();
        if (avlTrees[bigIndex]->stack->empty())
        {
            delete avlTrees[bigIndex];
            avlTrees[bigIndex] = 0;
            lineCount--;
            for (int i = 0; i < index; i++)
            {
                if (avlTrees[i] != 0)
                {
                    avlTrees[i]->renewStack(avlTrees[i]);
                }
            }
            AVLyazdir(avlTrees, index);
            system("CLS");
        }
    }
    cout << endl;
    for (int i = 0; i < index; i++)
    {
        if (avlTrees[i] != 0)
        {

            cout << "----------------------------------" << endl;
            cout << "----------------------------------" << endl;
            cout << "|"
                 << "                                "
                 << "|" << endl;
            cout << "|"
                 << " Son karakter:" << avlTrees[i]->Harf << "                 |" << endl;
            cout << "|"
                 << " AVL No:" << avlTrees[i]->AVLNO << "                     |" << endl;
            cout << "|"
                 << "                                "
                 << "|" << endl;
            cout << "----------------------------------" << endl;
            cout << "----------------------------------" << endl;

            cout << avlTrees[i]->Harf << "  " << avlTrees[i]->AVLNO;
        }
    }

    delete[] avlTrees;
    return 0;
}