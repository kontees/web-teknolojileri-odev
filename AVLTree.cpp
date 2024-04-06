/**
* @file AvlTree.cpp
* @description AVL ağacı ile ilgili gerekli fonksiyonlar
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

AVLNode::AVLNode(int veri) : deger(veri), sol(nullptr), sag(nullptr), yukseklik(1) {}

using namespace std;

AVLTree::AVLTree() : root(nullptr), stack(nullptr)
{
    avlDugumToplam = 0;
    AVLNO = 0;
    Harf = 0;
}

AVLTree::AVLTree(Stack *yaprakYigin) : root(nullptr), stack(yaprakYigin)
{
    avlDugumToplam = 0;
    AVLNO = 0;
    Harf = 0;
}

int AVLTree::YukseklikAl(AVLNode *dugum)
{
    if (dugum == nullptr)
        return 0;
    return dugum->yukseklik;
}

int AVLTree::getRootData()
{
    if (root)
    {
        return root->deger;
    }
    else
    {
        return 0; // Varsa root değerini döndür, yoksa 0 döndür
    }
}

void AVLTree::postorderTraversalForStack(AVLNode *node, Stack *stack)
{
    if (node == nullptr)
        return;

    postorderTraversalForStack(node->sol, stack);
    postorderTraversalForStack(node->sag, stack);

    if (node->sol == nullptr && node->sag == nullptr)
    {
        stack->push(node->deger);
    }
    // Diğer durumlar için gerekirse eklemeler yapılabilir.
}
// AVLTree.cpp

int AVLTree::DengesiAl(AVLNode *dugum)
{
    if (dugum == nullptr)
        return 0;
    return YukseklikAl(dugum->sol) - YukseklikAl(dugum->sag);
}

AVLNode *AVLTree::SagaDondur(AVLNode *y)
{
    AVLNode *x = y->sol;
    AVLNode *T2 = x->sag;

    x->sag = y;
    y->sol = T2;

    y->yukseklik = max(YukseklikAl(y->sol), YukseklikAl(y->sag)) + 1;
    x->yukseklik = max(YukseklikAl(x->sol), YukseklikAl(x->sag)) + 1;

    return x;
}

AVLNode *AVLTree::SolaDondur(AVLNode *x)
{
    AVLNode *y = x->sag;
    AVLNode *T2 = y->sol;

    y->sol = x;
    x->sag = T2;

    x->yukseklik = max(YukseklikAl(x->sol), YukseklikAl(x->sag)) + 1;
    y->yukseklik = max(YukseklikAl(y->sol), YukseklikAl(y->sag)) + 1;

    return y;
}

AVLNode *AVLTree::AVLNodeEkle(AVLNode *dugum, int veri)
{
    if (dugum == nullptr)
        return new AVLNode(veri);

    if (veri < dugum->deger)
    {
        dugum->sol = AVLNodeEkle(dugum->sol, veri);
    }
    else if (veri > dugum->deger)
    {
        dugum->sag = AVLNodeEkle(dugum->sag, veri);
    }
    else
    {
        return dugum; // Aynı değerden varsa ekleme
    }

    dugum->yukseklik = 1 + max(YukseklikAl(dugum->sol), YukseklikAl(dugum->sag));

    int denge = DengesiAl(dugum);

    // Sol ağır durumları
    if (denge > 1)
    {
        if (veri < dugum->sol->deger)
        {
            return SagaDondur(dugum);
        }
        else if (veri > dugum->sol->deger)
        {
            dugum->sol = SolaDondur(dugum->sol);
            return SagaDondur(dugum);
        }
    }

    // Sağ ağır durumları
    if (denge < -1)
    {
        if (veri > dugum->sag->deger)
        {
            return SolaDondur(dugum);
        }
        else if (veri < dugum->sag->deger)
        {
            dugum->sag = SagaDondur(dugum->sag);
            return SolaDondur(dugum);
        }
    }

    return dugum;
}

void AVLTree::AVLPostorderYapraklariYiginaEkle(AVLNode *dugum, Stack *yigin)
{
    if (dugum != 0)
    {
        AVLPostorderYapraklariYiginaEkle(dugum->sol, yigin);
        AVLPostorderYapraklariYiginaEkle(dugum->sag, yigin);
        if (dugum->sol == 0 && dugum->sag == 0)
        {
            yigin->push(dugum->deger);
        }
    }
}
int AVLTree::AVLToplamDugumDeger(AVLNode *dugum)
{
    if (dugum == nullptr)
        return 0;

    return dugum->deger + AVLToplamDugumDeger(dugum->sol) + AVLToplamDugumDeger(dugum->sag);
}
void AVLTree::AvlHarfiBul(AVLNode *dugum)
{
    if (dugum != 0)
    {
        AvlHarfiBul(dugum->sol);
        AvlHarfiBul(dugum->sag);

        if ((dugum->sol != 0 || dugum->sag != 0))
        {
            avlDugumToplam = avlDugumToplam + dugum->deger;
        }
    }
}

// AVL ağacını yok eden fonksiyon
void AVLTree::AVLYokEt(AVLNode *root)
{
    if (root == 0)
    {
        return;
    }

    AVLYokEt(root->sol);
    AVLYokEt(root->sag);
    delete root;
}
AVLTree::~AVLTree()
{
    AVLYokEt(root);
    delete stack; // Belleği serbest bırakın
}
void AVLTree::renewStack(AVLTree *avltree)
{
    delete stack;
    stack = new Stack();
    AVLPostorderYapraklariYiginaEkle(avltree->root, stack);
}