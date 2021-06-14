using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ates : MonoBehaviour
{

   


    void OnTriggerEnter2D(Collider2D obj)
    {
       
        if (obj.gameObject.tag == "Monster")
        {
            Debug.Log("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            Destroy(gameObject);
           


        } 
    
    
    
    
    
    
    }







        
}
