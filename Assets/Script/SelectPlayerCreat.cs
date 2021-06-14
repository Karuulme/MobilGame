using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPlayerCreat : MonoBehaviour
{

    
    public PlayerCreat PlayerCreat;
    public PlayerLevelIcone PlayerLevelIcone;
    public int SelectPlayerIndex;

    private void Start()    
    {

        PlayerCreat = FindObjectOfType<PlayerCreat>().GetComponent<PlayerCreat>();
        PlayerLevelIcone = FindObjectOfType<PlayerLevelIcone>().GetComponent<PlayerLevelIcone>();


    }

    public void PlayerSelectCreat()
    {
      
     
        if (SelectPlayerIndex == 0)
        {

            
            if (PlayerLevelIcone.Players[PlayerLevelIcone.sayac].layer == 10)   
            {
                PlayerCreat.PlayerAdd(PlayerLevelIcone.Players[PlayerLevelIcone.sayac].tag);
            }

        }
        else if (SelectPlayerIndex == 1)
        {
          

            if (PlayerLevelIcone.Players[PlayerLevelIcone.sayac+1].layer == 10)
            {
                PlayerCreat.PlayerAdd(PlayerLevelIcone.Players[PlayerLevelIcone.sayac +1].tag);

            }
        }
        else if (SelectPlayerIndex == 2)
        {
            if (PlayerLevelIcone.Players[PlayerLevelIcone.sayac+2].layer == 10)
            {
                PlayerCreat.PlayerAdd(PlayerLevelIcone.Players[PlayerLevelIcone.sayac +2 ].tag);
            }

        }




        
        

    }
}
