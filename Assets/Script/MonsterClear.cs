
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterClear : MonoBehaviour
{
    public OyunPuanSistemi OyunPuanSistemi;
    public Monster_yedek MonsterHP;
   



    public int HP;
    internal object rgb;
     void Eksen_y()
    {
        transform.position += new Vector3(0, -0.0075f, 0);

    }
    private void Start()
    {
        InvokeRepeating("Eksen_y", 1, 0.01f);
        OyunPuanSistemi = FindObjectOfType<OyunPuanSistemi>().GetComponent<OyunPuanSistemi>();
        MonsterHP = FindObjectOfType<Monster_yedek>().GetComponent<Monster_yedek>();
        
        HP = MonsterHP.MonsterHP;

    }
    void OnTriggerEnter2D(Collider2D obj)
    {
       
        
        if (obj.gameObject.tag == "Mermi1")
        {

        
            HP -= 20;
           
            Destroy(obj.gameObject);

        }
        if (obj.gameObject.tag == "Mermi2")
        {
            Destroy(obj.gameObject);

            HP -= 50;

        }
       
        if (obj.gameObject.tag == "Mermi3")
        {

            Destroy(obj.gameObject);
            HP -= 120;

        }
        if (obj.gameObject.tag == "Blok")
        {


            MonsterHP.MonsterRestart(gameObject);
        }

        if (HP<=0)
        {

            int Gold = Random.Range(0,20);
            int Gold2 = Random.Range(0,20);
            if (Gold==Gold2)
            {
                OyunPuanSistemi.Gold += 1;
                OyunPuanSistemi._Gold();
            }
           
            

            MonsterHP.MonsterHPAdd();
            HP = MonsterHP.MonsterHP;
            OyunPuanSistemi.ParaAdd(100);
            MonsterHP.MonsterRestart(gameObject);

        }
        
     

    }
   
}
