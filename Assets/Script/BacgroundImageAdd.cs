using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacgroundImageAdd : MonoBehaviour
{
    public GameObject[] Monsters;
    public float[] Konumlar = new float[] {-2,-1.5f,-0.5f,2, 1.5f, 0.5f };
    void Start()
    {
        InvokeRepeating("Fonksiyon", 1,1.5f);

    }

    // Update is called once per frame



    void Fonksiyon()
    {
        int MonsterRandom = Random.Range(0, Monsters.Length);
        int KonumRandom = Random.Range(0, Konumlar.Length);
        GameObject temp = (GameObject)Instantiate(Monsters[MonsterRandom], new Vector2(Konumlar[KonumRandom], 6), Quaternion.identity);
     


    }
   
}
