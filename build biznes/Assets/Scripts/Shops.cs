using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shops : MonoBehaviour
{

    
    public int MyBalance;
    public Text BalanceText;
    void Start()
    {
        MyBalance = 300;
    }

    // Update is called once per frame
    void Update()
    {
        if(MyBalance <= 0)
        {
            MyBalance = 0;
        }
        BalanceText.text = " " + MyBalance;
    }
}
