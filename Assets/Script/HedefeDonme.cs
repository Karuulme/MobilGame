using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HedefeDonme : MonoBehaviour
{
   
  
         public Transform target;
         private Vector3 targetPos;
         private Vector3 thisPos;
         private float angle;
    void Start()
    {
        
    }
    public void Hedef()
    {
        if (target != null)
        {
            Vector3 diff = target.position - transform.position;
            diff.Normalize();

            float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rot_z);

            targetPos = target.position;
            thisPos = transform.position;
            targetPos.x = targetPos.x - thisPos.x;
            targetPos.y = targetPos.y - thisPos.y;
            angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
        }



    }
    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {

           

        }







    }
}
