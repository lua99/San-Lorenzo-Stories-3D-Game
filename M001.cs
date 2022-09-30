using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M001 : MonoBehaviour
{
    public GameObject missionStartPoint;
    public GameObject ourPhone;
    public GameObject sentMessage;
    public AudioSource phoneFX;
    public GameObject aladaB;


     void OnTriggerEnter(Collider other)
    {
        StartCoroutine(MissionBegin());
    }


    IEnumerator MissionBegin()
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        ourPhone.SetActive(true);
        phoneFX.Play();
        aladaB.SetActive(true);
        yield return new WaitForSeconds(3);
        sentMessage.SetActive(true);
        yield return new WaitForSeconds(2);
        ourPhone.SetActive(false);
        missionStartPoint.SetActive(false);

    }
}
