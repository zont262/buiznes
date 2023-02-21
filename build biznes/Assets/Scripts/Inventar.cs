using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventar : MonoBehaviour
{
    public GameObject[] gums;
    public GameObject GumInvGm;
    public int GumInv;
    public int Slot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GumInv < 0)
        {
            GumInv = 0;
        }

        if (GumInv <= 0)
        {
            for (int i = 0; i <= 9; i += 1)
            {

                
                gums[i].SetActive(false);
                
            }
        }

        if (Slot < 0)
        {
            Slot = 0;
        }

        if (GumInv > 10)
        {
            GumInv = 0;
        }

        if (Slot > 10)
        {
            Slot = 0;
        }
    }

    public void GumssPlus()
    {
        
        
        for (int i = 0; i < GumInv; i += 1)
        {
            gums[i].SetActive(true);
            Slot = i;
        }
    }

    public void GumssMinus()
    {
        print("gr");

        for (int i = Slot; i >= GumInv; i -= 1)
        {

            print("gr1");
            gums[i].SetActive(false);
            Slot = i;
        }
    }
}
