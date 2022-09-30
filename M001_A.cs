using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M001_A : MonoBehaviour
{
    public GameObject aladaCam;
    public GameObject thePlayer;
    public GameObject fadeIn;
    public GameObject fadeOut;
    public GameObject subText;
    public AudioSource aladaLine;



     void OnTriggerEnter(Collider other)
    {
        StartCoroutine(aladaMeet());
    }


    IEnumerator aladaMeet()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled=false;
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        aladaCam.SetActive(true);
        thePlayer.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        fadeIn.SetActive(true);
        fadeOut.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        fadeIn.SetActive(false);
        subText.SetActive(true);
        aladaLine.Play();
        yield return new WaitForSeconds(5);
        subText.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        aladaCam.SetActive(false);
        thePlayer.SetActive(true);
        
        fadeIn.SetActive(true);
        fadeOut.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        fadeIn.SetActive(false);

    }
}
