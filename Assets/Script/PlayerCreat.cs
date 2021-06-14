using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerCreat : MonoBehaviour
{
    public ZeminKontrol BilgiSet;
    public GameObject[] GameObject;
    public bool BosZemin=false;
    public int sayac = 0;
    public int PlayerSay = 0;
    public OyunPuanSistemi PuanSistemi;
    public int NewPlayerQueue = 0;
    public string PlayerLevel;
    public PlayerLevelIcone levelIconu;




    private void Start()
    {
        PlayerLevel = GameObject[0].tag;

        levelIconu = FindObjectOfType<PlayerLevelIcone>().GetComponent<PlayerLevelIcone>();
        BilgiSet = FindObjectOfType<ZeminKontrol>().GetComponent<ZeminKontrol>();
        PuanSistemi = FindObjectOfType<OyunPuanSistemi>().GetComponent<OyunPuanSistemi>();
    }
    public void PlayerAdd(string Tag)
    {
       

        foreach (var i in BilgiSet.Dogruluk)
        {
          
            if (i==false)
            {

                BosZemin = true;

                break;
            }   
            sayac++;

        }
        
        if (BosZemin==true)
        {
            foreach (var i in GameObject)
            {
                if (Tag==i.tag)
                {

                    break;
                }
                NewPlayerQueue++;

            }
           
            
            PuanSistemi.ParaKontrol(NewPlayerQueue);
            if (PuanSistemi.ParaKontrolu == true)
            {
                PuanSistemi.ParaKontrolu = false;
                
                


                GameObject temp = (GameObject)Instantiate(GameObject[NewPlayerQueue], new Vector3(BilgiSet.ZeminX[sayac], BilgiSet.ZeminY[sayac],10), Quaternion.identity);
                temp.name = "Player" + (PlayerSay);

             
              


                BilgiSet.PlayerAdd("Player" + PlayerSay, sayac, GameObject[NewPlayerQueue].tag);

                PlayerSay++;
                BilgiSet.Dogruluk[sayac] = true;
                BosZemin = false;

                NewPlayerQueue = 0;

            }
           
        }
        sayac = 0;
    }








    public void NewPlayerAdd(string[] NewPlayerAbout)
    {
    


        for (int i=0;i<GameObject.Length;i++)
        {
           
            if (GameObject[i].tag==NewPlayerAbout[4])
          
            {
              


                GameObject temp = (GameObject)Instantiate(GameObject[i+1], new Vector3(Convert.ToSingle(NewPlayerAbout[1]), Convert.ToSingle(NewPlayerAbout[2]),10), Quaternion.identity);
                temp.name = GameObject[i].tag + " " + (PlayerSay);

                BilgiSet.Player[Convert.ToInt32(NewPlayerAbout[5]), 0] = NewPlayerAbout[0];
                BilgiSet.Player[Convert.ToInt32(NewPlayerAbout[5]), 1] = NewPlayerAbout[1];
                BilgiSet.Player[Convert.ToInt32(NewPlayerAbout[5]), 2] = NewPlayerAbout[2];
                BilgiSet.Player[Convert.ToInt32(NewPlayerAbout[5]), 3] = GameObject[i].tag+" "+ PlayerSay;
                BilgiSet.Player[Convert.ToInt32(NewPlayerAbout[5]), 4] = GameObject[i+1].tag;

                
                if (PlayerLevel==GameObject[i ].tag)
                {
                    PlayerLevel=GameObject[i + 1].tag;
                    PuanSistemi.LevelUp();

                    if (PuanSistemi.Level==2)
                    {
                        levelIconu.Layer(1);
                    }
                    if (PuanSistemi.Level == 3)
                    {
                        levelIconu.Layer(2);
                    }


                    if (PuanSistemi.Level > 3 && PuanSistemi.Level <= 8)
                    {
                        levelIconu.Layer(3);
                    }
                    if (PuanSistemi.Level > 8 && PuanSistemi.Level <= 10)
                    {
                        levelIconu.Layer(4);
                    }
                    if (PuanSistemi.Level > 10 && PuanSistemi.Level <= 12)
                    {
                        levelIconu.Layer(5);
                    }
                    if (PuanSistemi.Level > 12 && PuanSistemi.Level <= 14)
                    {
                        levelIconu.Layer(6);
                    }
                    if (PuanSistemi.Level > 14 && PuanSistemi.Level <= 16)
                    {
                        levelIconu.Layer(7);
                    }
                    if (PuanSistemi.Level > 16 && PuanSistemi.Level <= 18)
                    {

                        levelIconu.Layer(8);
                    }
                    if (PuanSistemi.Level > 18 && PuanSistemi.Level <= 20)
                    {
                        levelIconu.Layer(9);

                    }

                }
               




                PlayerSay++;
                BilgiSet.Dogruluk[Convert.ToInt32(NewPlayerAbout[5])] = true;
                BosZemin = false;   


          
            



            }




        }
     









    }

}








