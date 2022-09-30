using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalHints : MonoBehaviour
{
    public GameObject hintText;
    public static int hintNumber;


   

    
    void Update()
    {
        if (hintNumber == 1)
        {
            hintNumber = 0;
            hintText.GetComponent<Text>().text = "Mission start point can be found by searching for the red points on your map";
            hintText.GetComponent<Animator>().Play ("HintFade");
        }
    }
}
