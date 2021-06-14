using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClonClear : MonoBehaviour
{



    void OnTriggerEnter2D(Collider2D obj)
    {

        if (obj.gameObject.tag == "Monster")
        {

            Destroy(obj.gameObject);



        }

        if (obj.gameObject.tag == "TAS")
        {

            Destroy(obj.gameObject);



        }







    }
}
