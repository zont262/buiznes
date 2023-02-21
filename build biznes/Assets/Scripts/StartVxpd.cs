using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartVxpd : MonoBehaviour
{
    public GameObject Starts;
    public GameObject[] Bots;
    void Start()
    {
        StartCoroutine(StartBots());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StartBots()
    {
        yield return new WaitForSeconds(10);
        Bots[0].SetActive(true);
        yield return new WaitForSeconds(10);
        Bots[1].SetActive(true);
        yield return new WaitForSeconds(10);
        Bots[2].SetActive(true);
        yield return new WaitForSeconds(10);
        Bots[3].SetActive(true);
    }
}
