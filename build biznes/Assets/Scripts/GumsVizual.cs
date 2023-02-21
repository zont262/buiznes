using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GumsVizual : MonoBehaviour
{
    public GameObject[] Gumss;
    public int GumsInt;
    public int GumsOstatok;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void GumssDeleta()
    {
        if (GumsInt >= 0)
        {


            Gumss[GumsInt].SetActive(false);
            GumsInt--;
        }
    }

    public void GumsAdd(int a)
    {
        
            GumsInt = a - 2;
        
        
        GumsOstatok = a;

        for (int i = 0; i < a; i += 1)
        {
            Gumss[i].SetActive(true);
        }
    }

    
}
