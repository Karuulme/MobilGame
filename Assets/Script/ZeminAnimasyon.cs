using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminAnimasyon : MonoBehaviour
{

    int sayac = 0;
    public float R=0.005f;
    void Start()
    {
        //InvokeRepeating("Fonksiyon", 1, R);
     
    }

    // Update is called once per frame
    void Update()
    {

        
     }

    void Fonksiyon()
    {

        /*
        transform.rotation = Quaternion.Euler(0, 0,sayac);
        sayac++;
        if(sayac==360)
        {
            sayac = 0;



        }
        */
    }
}
