using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AA_Opening : MonoBehaviour
{
    public GameObject fadeIn;
    public GameObject theText;
    public GameObject initialCamera;
    public GameObject fadeOut;
    public GameObject thePlayer;
    public GameObject killerFake;
    public GameObject cashCount;
    public GameObject ammoCount;
    public GameObject hintBox;
    
    void Start()
    {
        StartCoroutine(OpenBegin());
    }

      
    IEnumerator OpenBegin()
    {
        yield return new WaitForSeconds(1);
        theText.SetActive(true);
        yield return new WaitForSeconds(7);
        fadeIn.GetComponent<Animator>().enabled = true;
        initialCamera.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(3);
        fadeOut.SetActive(true);
        fadeIn.SetActive(false);
        yield return new WaitForSeconds(2.5f);
        killerFake.SetActive(false);
        thePlayer.SetActive(true);
        fadeIn.SetActive(true);
        initialCamera.SetActive(false);
        fadeOut.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        fadeIn.SetActive(true);
        cashCount.SetActive(true);
        ammoCount.SetActive(true);
        hintBox.SetActive(true);
        fadeIn.GetComponent<Animator>().Play("FadeinAnim");
        yield return new WaitForSeconds(4);
        fadeIn.SetActive(false);
        GlobalHints.hintNumber = 1;



    }
}
