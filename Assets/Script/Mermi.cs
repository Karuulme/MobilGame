using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mermi : MonoBehaviour
{
    public GameObject Mermiler;
    public Konum konum;
    public float radius;
    public LayerMask Monster;
    public Transform target;
    public GameObject[] MermilerinKonumu;
    public PlayerCreat Players;
    int sayac = 0;
   
    public BulletsEfect Efek;
    public HedefeDonme Hedef;

    void Start()
    {


        InvokeRepeating("Fonksiyon", 3, 0.5f);
        //  Players=FindObjectOfType<PlayerCreat>().GetComponent<PlayerCreat>();
        Efek = FindObjectOfType<BulletsEfect>().GetComponent<BulletsEfect>();
        Hedef = FindObjectOfType<HedefeDonme>().GetComponent<HedefeDonme>();
    }


    void Fonksiyon()
    {




        Collider2D[] CollidersInCircle = Physics2D.OverlapCircleAll(transform.position, radius, Monster);

        if (CollidersInCircle.Length > 0)
        {
            
            if (sayac == 0)
            {


                
                GetComponent<HedefeDonme>().target = GetClosestEnemy(CollidersInCircle);
                Hedef.Hedef();
                GameObject mermi = Instantiate(Mermiler, new Vector2(MermilerinKonumu[0].transform.position.x, MermilerinKonumu[0].transform.position.y), Quaternion.identity);
                mermi.GetComponent<NewBehaviourScript2>().target = GetClosestEnemy(CollidersInCircle);
                Efek.EfekRun(0);
                mermi.GetComponent<BulletsTarget>().target = GetClosestEnemy(CollidersInCircle);

              //  Destroy(Instantiate(Efect, new Vector2(MermilerinKonumu[0].transform.position.x, MermilerinKonumu[0].transform.position.y), Quaternion.identity).gameObject,0.5f);
             
                sayac++;
            }
            else
            {



              
                GetComponent<HedefeDonme>().target = GetClosestEnemy(CollidersInCircle);
                Hedef.Hedef();
                GameObject mermi2 = Instantiate(Mermiler, new Vector2(MermilerinKonumu[1].transform.position.x, MermilerinKonumu[1].transform.position.y), Quaternion.identity);
                mermi2.GetComponent<NewBehaviourScript2>().target = GetClosestEnemy(CollidersInCircle);
                Efek.EfekRun(1);
                mermi2.GetComponent<BulletsTarget>().target = GetClosestEnemy(CollidersInCircle);
               // Destroy(Instantiate(Efect, new Vector2(MermilerinKonumu[1].transform.position.x, MermilerinKonumu[1].transform.position.y), Quaternion.identity).gameObject,0.5f);

                sayac = 0;
            }
                    

                    





        }

    }
    Transform GetClosestEnemy(Collider2D[] enemies)
    {
        Transform[] enemytransforms = new Transform[enemies.Length];

        for (int i = 0; i < enemies.Length; i++)
        {

            enemytransforms[i] = enemies[i].transform;

        }

        Transform tMin = null;
        float minDist = Mathf.Infinity;
        Vector3 currentPos = transform.position;
        foreach (Transform t in enemytransforms)
        {
            float dist = Vector3.Distance(t.position, currentPos);
            if (dist < minDist)
            {
                tMin = t;
                minDist = dist;
            }
        }
        return tMin;
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radius);


    }


}
