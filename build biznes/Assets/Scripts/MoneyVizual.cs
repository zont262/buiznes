using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyVizual : MonoBehaviour
{
    public GameObject[] MiniMoney;
    public GameObject[] BigMoney;
    public int ActiveIntMin;
    public int ActiveIntBig;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveMoney()
    {
        
        if (ActiveIntMin <= 9)
        {
            MiniMoney[ActiveIntMin].SetActive(true);
            ActiveIntMin++;
        }
        else
        {
            if (ActiveIntBig <= 9)
            {
                BigMoney[ActiveIntBig].SetActive(true);
                ActiveIntBig++;
                ActiveIntMin = 0;
                for (int i = 0; i < 10; i += 1)
                {
                    MiniMoney[i].SetActive(false);
                }
            }
            else
            {

            }
        }
    }

    public void DestroyMoney()
    {
        
        ActiveIntMin = 0;
        ActiveIntBig = 0;
        for (int i = 0; i < 10; i += 1)
        {
           MiniMoney[i].SetActive(false);
        }
        for (int i = 0; i < 10; i += 1)
        {
            BigMoney[i].SetActive(false);
        }


    }
}
