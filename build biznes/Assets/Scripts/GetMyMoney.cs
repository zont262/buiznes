using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMyMoney : MonoBehaviour
{
    public int money; // баланс банкомата, такую сумму мы даем игроку 
    public GameObject moneyGm; // пустышка со скриптом на деньги
    public GameObject GetMoneyVizual; // пустышка со скриптом на деньги визуал
    public GameObject gums; // пустышка банкомат ему мы говорим сколько жвачек включить

    public GameObject Inventar; // пустыщка инвентаря

    public int ggg;
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
            moneyGm.GetComponent<Shops>().MyBalance += money; // дать на балданс свои деньги
            money = 0; // сделать  мне баланс 0
            
            GetMoneyVizual.gameObject.GetComponent<MoneyVizual>().DestroyMoney(); // удалить визуальные деньги

            if(Inventar.GetComponent<Inventar>().GumInv > 0)
            {
                var g = 11 - gums.GetComponent<GumsVizual>().GumsOstatok;
                ggg = Inventar.GetComponent<Inventar>().GumInv - g;
                if (ggg >= 0)
                {
                    print("if");
                    Inventar.GetComponent<Inventar>().GumInv -= g;
                    Inventar.GetComponent<Inventar>().GumssMinus();
                    gums.GetComponent<GumsVizual>().GumsAdd(11);
                    
                }
                else
                {

                    print("else");
                    Inventar.GetComponent<Inventar>().GumInv -= ggg;
                    Inventar.GetComponent<Inventar>().GumssMinus();
                    gums.GetComponent<GumsVizual>().GumsAdd(ggg);
                
                }
            }
        }


    }

    
}
