using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAddInv : MonoBehaviour
{
    public GameObject Player;
    public GameObject Inventar;

    public int MyNumbers;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (MyNumbers == 1)
            {


                Inventar.GetComponent<Inventar>().GumInv = 10;
                Inventar.GetComponent<Inventar>().GumssPlus();
            }
        }
    }
}
