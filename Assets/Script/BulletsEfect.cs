using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsEfect : MonoBehaviour
{

    public ParticleSystem[] Efek;



    public void EfekRun(int i)
    {
        Efek[i].Play();



    }





}
