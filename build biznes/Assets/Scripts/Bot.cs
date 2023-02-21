using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bot : MonoBehaviour
{
    public GameObject start;
    public GameObject end;
    public GameObject Exit;
    // дорога ботов
    public GameObject Starts;
    public GameObject Shops;
    public GameObject Doors;
    public GameObject Exits;
    public int Road;
    // дорога ботов
    public float step;
    public float progress;
    public Animator anim;
    public int rand;
    public GameObject GetMoney;
    public GameObject GetMoneyVizual;
    public bool isExit;
    public bool AnimRun;
    public GameObject Gums;
    void Start()
    {
       
        isExit = false;
        AnimRun = true;
        anim.SetBool("grust", false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Road == 1)
        {
            
            transform.rotation = Quaternion.Euler(transform.rotation.x, 0, transform.rotation.z);
            transform.position = Vector3.Lerp(transform.position, Doors.transform.position, progress);
            progress += step;
            if (AnimRun == true)
            {
                anim.SetBool("run", true);
            }

        }
        else if(Road == 2)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, 30, transform.rotation.z);
            
            transform.position = Vector3.Lerp(transform.position, Shops.transform.position, progress);
            progress += step;
            if (AnimRun == true)
            {
                anim.SetBool("run", true);
            }

        }

        else if (Road == 3)
        {
            transform.rotation = Quaternion.LookRotation(Exits.transform.position);
            transform.position = Vector3.Lerp(transform.position, Exits.transform.position, progress);
            progress += step;

            if (AnimRun == true)
            {
                anim.SetBool("run", true);
            }

        }

        else if (Road == 4)
        {
            //transform.rotation = Quaternion.LookRotation(Starts.transform.position);
            transform.position = Vector3.Lerp(transform.position, Starts.transform.position, progress);
            progress += step;
            if (AnimRun == true)
            {
                anim.SetBool("run", true);
            }

        }

    }

    

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Product1")
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, -30, transform.rotation.z);
            rand = Random.Range(0, 100);
            StartCoroutine(randomBuy());
            AnimRun = false;
            anim.SetBool("run", false);
            StartCoroutine(RunShop());
        }

        if (col.gameObject.tag == "Exit")
        {
            AnimRun = false;
            anim.SetBool("run", false);
            

        }

        if (col.gameObject.tag == "Start")
        {
            StartCoroutine(StartBots());

        }

        if (col.gameObject.tag == "DoorBot")
        {
            StartCoroutine(DoorBots());

        }

        if (col.gameObject.tag == "ExitsStarts")
        {
            StartCoroutine(ExitsStarts());

        }
    }

    IEnumerator randomBuy()
    {
        yield return new WaitForSeconds(5);
        if(rand > 20 && Gums.GetComponent<GumsVizual>().GumsOstatok > 0)
        {
            Gums.GetComponent<GumsVizual>().GumsOstatok -= 1;
            Gums.GetComponent<GumsVizual>().GumssDeleta();
            GetMoney.gameObject.GetComponent<GetMyMoney>().money += 10;
            GetMoneyVizual.gameObject.GetComponent<MoneyVizual>().ActiveMoney();
            anim.SetBool("run", false);
            anim.SetBool("rad", true);
        }
        else
        {
            anim.SetBool("grust", true);
        }
        progress = 0;
        yield return new WaitForSeconds(1);
        anim.SetBool("rad", false);
        anim.SetBool("grust", false);
    }

    IEnumerator RunShop()
    {
        yield return new WaitForSeconds(7);
        progress = 0;
        Road = 3;
        AnimRun = true;

    }

    IEnumerator StartBots()
    {
        yield return new WaitForSeconds(5);
        progress = 0;
        Road = 1;


    }

    IEnumerator DoorBots()
    {
        yield return new WaitForSeconds(1);
        progress = 0;
        Road = 2;


    }

    IEnumerator ExitsStarts()
    {
        yield return new WaitForSeconds(5);
        progress = 0;
        Road = 4;


    }
}
