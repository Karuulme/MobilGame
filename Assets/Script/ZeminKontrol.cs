using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminKontrol : MonoBehaviour
{
    public int sayac = 0;
    public bool[] Dogruluk = new bool[] { false, false, false, false, false, false };
    public string[] ZeminTaglari = new string[] {"Zem1","Zem2","Zem3","Zem4","Zem5","Zem6"};
    public float[] ZeminX = new float[6] ;
    public float[] ZeminY = new float[6] ;
    public string[,] Player = new string[6,5];

    //         Zemin,X,Y,Name,Tag


    public void PlayerAdd(string PlayerName, int Sira, string PlayerTag)
    {

        Player[Sira,0] = ZeminTaglari[Sira];
        Player[Sira,1] = ZeminX[Sira].ToString();
        Player[Sira,2] = ZeminY[Sira].ToString();
        Player[Sira,3] = PlayerName;
        Player[Sira,4] = PlayerTag;

    }
   



}
