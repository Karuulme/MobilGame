using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKonumDuzenleyici : MonoBehaviour
{
    public ZeminKontrol BilgiSet;
    public bool Konum = false;
    public bool ZeminUstunde = false;
    public string ZeminTag;
    public string ThisTag;
    public string ThisName;
    public bool ZeminUstundemi = false;
    public bool DogruHedef = false;
    public bool DogruHedef2 = false;
    public NewPlayerAdd NewPlayerAd;


    public void Start()
    {
        BilgiSet = FindObjectOfType<ZeminKontrol>().GetComponent<ZeminKontrol>();
        NewPlayerAd = FindObjectOfType<NewPlayerAdd>().GetComponent<NewPlayerAdd>();
    }

    public void OnMouseUp()
    {
        ZeminUstunde = true;
        DogruHedef = true;


    }
    void OnCollisionStay2D(Collision2D obj)
    {
    
        for (int i = 0; i < 6; i++)
        {
            

            if (BilgiSet.ZeminTaglari[i] == obj.gameObject.tag)
            {

                ThisTag = gameObject.tag;
                ThisName = gameObject.name;
                ZeminTag = obj.gameObject.tag;
                ZeminUstundemi = true;


            }


        }





    }


    private void Update()
    {


        if (ZeminUstunde == true)
        {
            ZeminUstunde = false;

            int tagsirasi = 0;
            if (ZeminUstundemi == true)
            {
                ZeminUstundemi = false;

                for (int i = 0; i < 6; i++)
                {
                    if (BilgiSet.ZeminTaglari[i] == ZeminTag)
                    {
                        tagsirasi = i;

                    }
                }


                bool NewPlayer = false;
                for (int i = 0; i < 6; i++)
                    if (BilgiSet.Player[i, 3] == gameObject.name && BilgiSet.Player[i, 0] != ZeminTag && BilgiSet.Dogruluk[tagsirasi] == true)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (BilgiSet.Player[j, 0] == ZeminTag && BilgiSet.Player[j, 4] == gameObject.tag)
                            {


                                NewPlayer = true;



                            }
                        }







                    }

                if (NewPlayer == true)
                {
                    NewPlayer = false;

                    NewPlayerAd.NewPlay(ZeminTag, gameObject.name);

                }
                else
                {


                    if (BilgiSet.Dogruluk[tagsirasi] == false)
                    {
                        Run();


                    }
                    else
                    {



                        KonumGit();







                    }


                }
            }

            else
            {
                KonumGit();

            }
        }
        if (Konum == true)
        {
            
            Konum = false;
            for (var i = 0; i < 6; i++)
            {
                
                if (BilgiSet.Player[i, 3] == ThisName)
                {

                    transform.position = new Vector2(Convert.ToSingle(BilgiSet.Player[i, 1]), Convert.ToSingle(BilgiSet.Player[i, 2]));
                }
            }
        }
    }
    public void KonumGit()
    {
        Konum = true;
       
    }
    public void Run()
    {



        int sayac = 0;
        for (int i = 0; i < 6; i++)
        {
            if (BilgiSet.ZeminTaglari[i] == ZeminTag)
            {

                break;
            }
            sayac++;
        }

        for (int i = 0; i < 6; i++)
        {


            if (BilgiSet.Player[i, 3] == gameObject.name)
            {
                for (int j = 0; j < 6; j++)
                {

                    if (BilgiSet.ZeminTaglari[j] == BilgiSet.Player[i, 0])
                    {

                        BilgiSet.Dogruluk[j] = false;
                        BilgiSet.Player[i, 1] = BilgiSet.ZeminX[sayac].ToString();
                        BilgiSet.Player[i, 2] = BilgiSet.ZeminY[sayac].ToString();
                        BilgiSet.Player[i, 0] = ZeminTag;
                        BilgiSet.Dogruluk[sayac] = true;

                        KonumGit();



                    }


                }







            }



        }






    }

}
