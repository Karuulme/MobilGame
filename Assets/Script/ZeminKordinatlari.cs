using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminKordinatlari : MonoBehaviour
{
  
    public GameObject[] Zeminler;
    public GameObject Nokta;
    public ZeminKontrol Zemin;
    int sayac = 0;
    void Start()
    {
        Zemin = FindObjectOfType<ZeminKontrol>().GetComponent<ZeminKontrol>();
        foreach (var i in Zeminler)
        {

            transform.position = new Vector2(i.transform.position.x, i.transform.position.y);
            Zemin.ZeminX[sayac]=this.transform.position.x;
           Zemin.ZeminY[sayac] = this.transform.position.y;
            sayac++;
          
        }


    }

   
}
