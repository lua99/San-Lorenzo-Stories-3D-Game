using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class A03_VoiceSubs : MonoBehaviour
{

    public GameObject subText;
    public AudioSource voiceLine01;
    public AudioSource voiceLine02;
    public AudioSource loudBang;
    public GameObject fullBlack;
    public GameObject deathObject;
    //public GameObject theSack;
    public GameObject theCop;
    public GameObject theChar;
    public GameObject theGun;
    public GameObject fourthCam;
    public GameObject fadeOut;
    
    void Start()
    {
        StartCoroutine(IntroSubs());
    }

    
    IEnumerator IntroSubs()
    {
        yield return new WaitForSeconds(8);
        subText.GetComponent<Text>().text = "Its not a good idea to look at Tommy Shelby wrong way";
        voiceLine01.Play();
        subText.SetActive(true);
        yield return new WaitForSeconds(5);
        subText.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        subText.GetComponent<Text>().text = "I am simple man and i dont get upset to easy but when i do";
        

        voiceLine02.Play();
        yield return new WaitForSeconds(4.5f);
        subText.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        loudBang.Play();
        fullBlack.SetActive(true);
        deathObject.SetActive(true);
        theChar.SetActive(false);
        theCop.SetActive(false);
        theGun.SetActive(false);
        //theSack.SetActive(false);
        yield return new WaitForSeconds(4);
        fullBlack.SetActive(false);
        fourthCam.SetActive(true);
        yield return new WaitForSeconds(2);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(2);






    }
}
