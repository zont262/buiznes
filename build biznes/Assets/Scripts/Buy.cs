using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Buy : MonoBehaviour
{
    public int MyPrice;
    public int MyPrice2;
    public GameObject Shopss;
    private int otnat;
    public int fakeBalance;
    public TextMesh PriceText;
    public GameObject biznes;
    public GameObject Delate;
    public GameObject BotGm;
    public int _balanse;
    public GameObject NewByiznes;
    void Start()
    {
        MyPrice2 = MyPrice;
        PriceText.text = "" + MyPrice;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyMy()
    {
        MyPrice2 = MyPrice;
        fakeBalance = Shopss.gameObject.GetComponent<Shops>().MyBalance;
        MyPrice2 = MyPrice;

        fakeBalance -= MyPrice2;
        if (fakeBalance >= 0)
        {
           
            Shopss.gameObject.GetComponent<Shops>().MyBalance -= MyPrice;
            fakeBalance = Shopss.gameObject.GetComponent<Shops>().MyBalance;
            MyPrice = 0;
            MyPrice2 = MyPrice;
            biznes.SetActive(true);
            Delate.SetActive(false);
            BotGm.SetActive(true);
            NewByiznes.SetActive(true);
        }
        else
        {
           MyPrice -= Shopss.gameObject.GetComponent<Shops>().MyBalance;
            MyPrice2 = MyPrice;
            Shopss.gameObject.GetComponent<Shops>().MyBalance = 0;
            fakeBalance = Shopss.gameObject.GetComponent<Shops>().MyBalance;
            PriceText.text = "" + MyPrice;
        }
    }

    IEnumerator Buys()
    {
        
        yield return new WaitForSeconds(0.3f);
        MyPrice -= Shopss.gameObject.GetComponent<Shops>().MyBalance / 2;
        //MyPrice2 = MyPrice;
        Shopss.gameObject.GetComponent<Shops>().MyBalance -= MyPrice;
        //fakeBalance = Shopss.gameObject.GetComponent<Shops>().MyBalance;
        PriceText.text = "" + MyPrice;
        BuyMy();
    }

    public void StartCor()
    {
        BuyMy();
    }
}
