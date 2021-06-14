using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSelectSubmit : MonoBehaviour
{
    public SelectPlayerCreat SelectButton;

    private void Start()
    {
        SelectButton = FindObjectOfType<SelectPlayerCreat>().GetComponent<SelectPlayerCreat>();
    }
    public void SelectButtonName()
    {
        
        if (this.gameObject.name=="1.Ucak")
        {

            SelectButton.SelectPlayerIndex = 0;
            SelectButton.PlayerSelectCreat();
           
        }
        if (this.gameObject.name == "2.Ucak")
        {
           
            SelectButton.SelectPlayerIndex = 1;
            SelectButton.PlayerSelectCreat();

        }
        if (this.gameObject.name == "3.Ucak")
        {
           

            SelectButton.SelectPlayerIndex = 2;
            SelectButton.PlayerSelectCreat();
        }


    }

}
