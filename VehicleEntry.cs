using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.UI;

public class VehicleEntry : MonoBehaviour
{
    public GameObject vehicleCam;
    public GameObject thePlayer;
    public GameObject liveVehicle;
    public bool canEnter = false;
    public GameObject exitTrig;
    public GameObject interactUI;
    public GameObject interactText;

     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canEnter = true;
            interactText.GetComponent<Text>().text ="Enter vehicle";
            interactUI.SetActive(true);
        }
    }


     void OnTriggerExit(Collider other)
    {
        canEnter = false;
        interactText.GetComponent<Text>().text = "";
        interactUI.SetActive(false);
    }
   
    void Update()
    {
        if (canEnter == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.gameObject.GetComponent<BoxCollider>().enabled = false;
                vehicleCam.SetActive(true);
                thePlayer.SetActive(false);
                liveVehicle.GetComponent<CarController>().enabled = true;
                liveVehicle.GetComponent<CarUserControl>().enabled = true;
                liveVehicle.GetComponent<CarAudio>().enabled = true;
                canEnter = false;
                thePlayer.transform.parent = this.gameObject.transform;
                interactText.GetComponent<Text>().text = "";
                interactUI.SetActive(false);
                StartCoroutine(ExitTrigger());

            }
        }
    }

    IEnumerator ExitTrigger()
    {
        yield return new WaitForSeconds(0.5f);
        exitTrig.SetActive(true);
    }
}
