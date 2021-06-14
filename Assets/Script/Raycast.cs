using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public float meters=5;
    
    void Start()
    {
        
    }

    /*
    // Update is called once per frame
    void Update()
    {

        RaycastHit2D hit2D = Physics2D.Raycast(transform.position, transform.right, meters);
        Debug.DrawRay(transform.position,transform.right* meters, Color.red);

        if (hit2D.collider!=this.gameObject)
        {
            if (hit2D.collider.tag == "Player2")
            {
                Debug.Log(hit2D.collider.transform.position.x);


            }

            if (hit2D.collider == null)
            {

                Debug.Log("yok");

            }
          /* if(
            {
                Debug.Log(hit2D.collider.transform.position.x);

                Debug.Log("var");
            }

             }
    */

}
