using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    
    public Transform target;
    public float speed=5;

    void Update()
    {
        
        if (target!=null)
        {
      

        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else
        {

            Destroy(gameObject);

        }
     

        
    }
    
}

