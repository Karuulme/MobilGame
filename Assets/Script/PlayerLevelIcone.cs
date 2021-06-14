using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLevelIcone : MonoBehaviour
{

    public GameObject[] Players;
   
    public Transform[] Konumlar;
    public OyunPuanSistemi Level;
    public Text[] PlayerName;
    public int sayac =0;
  


    private void Start()
    {

        Level = FindObjectOfType<OyunPuanSistemi>().GetComponent<OyunPuanSistemi>();


       
        PlayerCreatLevelSystem(0);

    }


    public void PlayerCreatLevel()
    {

        if (Level.Level >=1 && Level.Level <= 3)
        {
           
            PlayerCreatLevelSystem(0);

            sayac=0;
        }
        if (Level.Level > 3 && Level.Level <=8)
        {
            PlayerCreatLevelSystem(1);
            sayac = 1;
        }
        if (Level.Level > 8 && Level.Level <=10)
        {
            PlayerCreatLevelSystem(2);
            sayac = 2;
        }
        if (Level.Level > 10 && Level.Level <= 12)
        {
            PlayerCreatLevelSystem(3);
            sayac = 3;
        }
        if (Level.Level > 12 && Level.Level <= 14)
        {
            PlayerCreatLevelSystem(4);
            sayac = 4;
        }
        if (Level.Level > 14 && Level.Level <= 16)
        {
            PlayerCreatLevelSystem(5);
            sayac = 5;
        }
        if (Level.Level > 16 && Level.Level <= 18)
        {

            PlayerCreatLevelSystem(6);
            sayac = 6;
        }
        if (Level.Level > 18 && Level.Level <= 20)
        {
            PlayerCreatLevelSystem(7);
            sayac = 7;

        }
    }
    public void PlayerCreatLevelSystem(int i)
    {

        if (i!=0)
        {  //1   (0-1-2)
            for (int j = i-1; j <= i+1; j++)
            {

                Players[j].transform.SetParent(null);
                Players[j].transform.position = new Vector2(20, 5);


            }


        }
            





       
            int sayac2 = 0;
            for (int j = i; j <= i + 2; j++)
            {
               

                Players[j].transform.SetParent(Konumlar[sayac2].transform);
                Players[j].transform.localPosition = new Vector2(0, 0);
             
             PlayerName[sayac2].text = Players[j].name;
            
                sayac2++;

            }
       
      
        
    }










    public void Layer(int i)
    {
        foreach (Transform child in Players[i].GetComponentsInChildren<Transform>(true))
        {
            child.gameObject.layer = LayerMask.NameToLayer("Aktif");   
        }
       

    }




}
