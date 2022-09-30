using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A02_MoveChar : MonoBehaviour
{
    public AudioSource leftFoot;
    public AudioSource rightFoot;
    public bool steppingLeft = true;
    public GameObject maincChar;
    public int stepsTaken;

    void Start()
    {
        StartCoroutine(WalkSequence());
    }

    
    void Update()
    {
        maincChar.transform.Translate(0, 0, 0.014f * Time.timeScale);
    }

    IEnumerator WalkSequence()
    {
        yield return new WaitForSeconds(0.5f);
        while (stepsTaken  < 15)
        {
            yield return new WaitForSeconds(0.5f);
            if(steppingLeft == true)
            {
                leftFoot.Play();
                steppingLeft = false;
            }
            else
            {
                rightFoot.Play();
                steppingLeft = true;
            }
            stepsTaken += 1;
        }
        maincChar.SetActive(false);
    }
}
