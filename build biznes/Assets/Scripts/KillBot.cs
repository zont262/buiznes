using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBot : MonoBehaviour
{
    public GameObject[] botss;
    public int botsss;
    public GameObject start;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "bot")
        {
            
            col.gameObject.SetActive(false);
            botss[botsss] = col.gameObject;
            botsss++;
            StartCoroutine(On());
        }
    }

    IEnumerator On()
    {
        yield return new WaitForSeconds(10);
        botss[botsss - 1].SetActive(true);
        botss[botsss - 1].transform.position = new Vector3(start.transform.position.x, start.transform.position.y, start.transform.position.z);
        
        botsss--;
    }
}
