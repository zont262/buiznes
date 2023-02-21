using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField]  private GameObject cristall1;
    [SerializeField]  private GameObject cristall2;
    [SerializeField]  private GameObject cristall3;
    [SerializeField] private GameObject cristall4;
    void Start()
    {
        StartCoroutine(Sizee());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Sizee()
    {
        yield return new WaitForSeconds(5);
        cristall1.gameObject.SetActive(true);
        cristall2.gameObject.SetActive(false);
        cristall3.gameObject.SetActive(false);
        cristall4.gameObject.SetActive(false);
        yield return new WaitForSeconds(5);
        cristall1.gameObject.SetActive(false);
        cristall2.gameObject.SetActive(true);
        cristall3.gameObject.SetActive(false);
        cristall4.gameObject.SetActive(false);
        yield return new WaitForSeconds(5);
        cristall1.gameObject.SetActive(false);
        cristall2.gameObject.SetActive(false);
        cristall3.gameObject.SetActive(true);
        cristall4.gameObject.SetActive(false);
        yield return new WaitForSeconds(5);
        cristall1.gameObject.SetActive(false);
        cristall2.gameObject.SetActive(false);
        cristall3.gameObject.SetActive(false);
        cristall4.gameObject.SetActive(true);
    }
}
