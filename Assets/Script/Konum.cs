using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Konum : MonoBehaviour
   
{
   
      public float KonumX=0;
      public float KonumY=0;
      public int a = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {

        KonumX = transform.position.x;
        KonumY = transform.position.y;
      //  Debug.Log(KonumX);
    }
}
