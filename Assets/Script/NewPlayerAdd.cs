using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerAdd : MonoBehaviour
{
    public GameObject[] Players;
    public ZeminKontrol BilgiSet;
    public PlayerCreat PlayerAdd;

    private void Start()
    {
       BilgiSet = FindObjectOfType<ZeminKontrol>().GetComponent<ZeminKontrol>();
        PlayerAdd = FindObjectOfType<PlayerCreat>().GetComponent<PlayerCreat>();

    }
    public void NewPlay(string HedefTag,string KendiName)
    {
       
        string[] NewPlayerAbout = new string[6];

        for (int i=0;i<6;i++)
        {
            if (BilgiSet.Player[i,3]== KendiName)
            {            
                

                Destroy(GameObject.Find(BilgiSet.Player[i, 3]));
                for (int j = 0; j < 6; j++)
                {
                    if (BilgiSet.ZeminTaglari[j] == BilgiSet.Player[i, 0])
                    {


                        BilgiSet.Dogruluk[j] = false;

                    }


                }
                BilgiSet.Player[i, 0] = null;
                BilgiSet.Player[i, 1] = null;
                BilgiSet.Player[i, 2] = null;
                BilgiSet.Player[i, 3] = null;
                BilgiSet.Player[i, 4] = null;


                



            }
            if (BilgiSet.Player[i, 0] == HedefTag)
            {
                NewPlayerAbout[0] = BilgiSet.Player[i, 0];
                NewPlayerAbout[1] = BilgiSet.Player[i, 1];
                NewPlayerAbout[2] = BilgiSet.Player[i, 2];
                NewPlayerAbout[3] = BilgiSet.Player[i, 3];
                NewPlayerAbout[4] = BilgiSet.Player[i, 4];
                NewPlayerAbout[5] = i.ToString();
                Destroy(GameObject.Find(BilgiSet.Player[i, 3]));
                for (int j = 0;j < 6; j++)
                {
                    if (BilgiSet.ZeminTaglari[j] == BilgiSet.Player[i, 0])
                    {


                        BilgiSet.Dogruluk[j] = false;

                    }


                }
                BilgiSet.Player[i, 0] = null;
                BilgiSet.Player[i, 1] = null;
                BilgiSet.Player[i, 2] = null;
                BilgiSet.Player[i, 3] = null;
                BilgiSet.Player[i, 4] = null;

            



                



            }

        }

        
        int SiraNumarasi = 0;
        for (int i = 0; i < 6; i++)
        {
            if (BilgiSet.Player[i, 0] == HedefTag)
                break;
            SiraNumarasi++;
        }

        
        PlayerAdd.NewPlayerAdd(NewPlayerAbout);




      /*  for (int j = 0; j < 8; j++)
        {




            Debug.Log(BilgiSet.Dogruluk[j]+"--"+j);

            


        }
      */














    }







}
