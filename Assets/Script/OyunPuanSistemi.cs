using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OyunPuanSistemi : MonoBehaviour
{

    public Text TextPara;
    public Text TextLevel;
    public Text TextGold;
    public int Gold;
    public Button PlayerLevelImage;
    public int Para = 128000000;
    public int Level=1;
    public int levelLitmi = 10000;
    public bool ParaKontrolu=false;
    public int[] PlayerFiyat = new int[] {100,1000,10000,10000,10000,10000,10000,10000,10000,10000,10000,10000,10000,10000,10000,10000,10000,10000,10000,10000 };
    public float KayanYildizSuresi =0;
    public GameObject[] star;
    public float[,] StarKonumlari = new float[,] { { -7, 2 },{ 7, 2 } };
    public int Sayac=0;
    public Monster_yedek MonsterHiz;
    public PlayerLevelIcone PlayerLevelIconuCreat;






    public void Start()
    {
        Debug.Log("Merhaba Dünya");
            
        PlayerLevelIconuCreat = FindObjectOfType<PlayerLevelIcone>().GetComponent<PlayerLevelIcone>();
        MonsterHiz = FindObjectOfType<Monster_yedek>().GetComponent<Monster_yedek>();
        InvokeRepeating("Star",1, 1);

        //  Star = FindObjectOfType<KayanYildiz>().GetComponent<KayanYildiz>();
        TextGold.text = Gold.ToString();
        TextLevel.text = Level.ToString();
        if (Para > 1000)
        {
            float Deger = Para / 1000;
            TextPara.text = Deger.ToString() + "K";
        }
        else
        {
            TextPara.text = Para.ToString();



        }

        









    }
    public void ParaAdd(int a)
    {

        Para += a;
        if (Para>1000)
        {
            float Deger = Para / 1000;
            TextPara.text = Deger.ToString()+"K";
        }
        else
        {
            TextPara.text = Para.ToString();



        }

      
     

    }


    public void _Gold()
    {

        TextGold.text = Gold.ToString();

    }
    public void LevelUp()
    {

        Level++;
        TextLevel.text = Level.ToString();
        if (Level%20==0 && MonsterHiz.zaman>0.2)
        {
            
            MonsterHiz.zaman-=0.1f;

        }
        
            PlayerLevelIconuCreat.PlayerCreatLevel();



        
       

    }
    public void ParaKontrol(int i)
    {
        

        if (Para>= PlayerFiyat[i])
        {

            ParaDelete(PlayerFiyat[i]);
            PlayerFiyat[i] += 200;
            ParaKontrolu = true;

           

        }



    }
    public void ParaDelete(int Fiyat)
    {


        Para -=Fiyat;
        TextPara.text=Para.ToString();

    }

    /*

    StartCoroutine(CoroutineTest());
    IEnumerator CoroutineTest()
    {
        TextHata.text = "Yeterli Para yok";
        yield return new WaitForSeconds(2f * Time.deltaTime);
        TextHata.text = " ";
    }
    */

    private void Star()
    {

        Sayac++;

        if (Sayac %120== 0)
        {

       
            int StarRasgele = Random.Range(0,2);
           


           // Instantiate(star[StarRasgele], new Vector2(StarKonumlari[StarRasgele,0], StarKonumlari[StarRasgele, 1]), Quaternion.identity);

           

        }
    }

}
