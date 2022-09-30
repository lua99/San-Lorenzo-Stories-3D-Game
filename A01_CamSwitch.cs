using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A01_CamSwitch : MonoBehaviour
{
    public GameObject firstCam;
    public GameObject secondCam;
    public GameObject credLeadDes;
    public GameObject thirdCam;


    void Start()
    {
        StartCoroutine(CamSwitcher());
    }

    IEnumerator CamSwitcher()
    {
        yield return new WaitForSeconds(3);
        credLeadDes.SetActive(true);
        yield return new WaitForSeconds(6);
        secondCam.SetActive(true);
        firstCam.SetActive(false);
        yield return new WaitForSeconds(5);
        thirdCam.SetActive(true);
        secondCam.SetActive(false);

    }
}