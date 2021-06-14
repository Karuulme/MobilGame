using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster_yedek : MonoBehaviour
{
    public GameObject[] GameObject;
    public float zaman = 1;
    float[] Konumlar = new float[] { -0.7f,0, 0.7f,0.35f, -0.35f };
    public int MonsterHP = 50;
    int sayac = 0;
    int sayac2 = 0;
    
   




    void Start()
    {
       
        Zaman();



    }
    public void Hiz()
    {

       /* zaman = -0.1f;
        Zaman();*/

    }
    void Zaman()
    {
      
        InvokeRepeating("Fonksiyon", 1, zaman);
        


    }

    public void MonsterHPAdd()
    {
        MonsterHP += 5;



    }


    public void MonsterRestart(GameObject gameObject)
    {
        
        sayac2++;
        int KonumRandom = Random.Range(0, Konumlar.Length);
        gameObject.transform.position = new Vector2(Konumlar[KonumRandom], 6);
       
        gameObject.name = MonsterHP.ToString();

     
       
        

    }



    void Fonksiyon()
    {
       
        if (sayac<20)
        {
            int KonumRandom = Random.Range(0, Konumlar.Length);
            int MonsterRandom = Random.Range(0, GameObject.Length);
            GameObject temp = (GameObject)Instantiate(GameObject[0], new Vector2(Konumlar[KonumRandom], 6), Quaternion.identity);
            temp.name = MonsterHP.ToString();
           
            sayac++;

          
        }
        




    }





}
