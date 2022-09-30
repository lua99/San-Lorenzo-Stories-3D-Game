using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCAI : MonoBehaviour
{
    public GameObject destinationPoint;
    NavMeshAgent theAgent;
    public static bool fleeMode = false;
    public GameObject fleeDest;
    public AudioSource helpMeFx;
    public bool isFleeing = false;

    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>(); 
    }

    
    void Update()
    {
        if (fleeMode == false)
        {
            theAgent.SetDestination(destinationPoint.transform.position);
        }
        else
        {
            theAgent.SetDestination(fleeDest.transform.position);
            if (isFleeing == false)
            {
                isFleeing = true;
                StartCoroutine(FleeingNPC());
            }
        }
       
    }

    IEnumerator FleeingNPC()
    {
        helpMeFx.Play();
        yield return new WaitForSeconds(13);
        fleeMode = false;
        isFleeing = false;
        this.gameObject.GetComponent<Animator>().Play("Walking");
        this.gameObject.GetComponent<NavMeshAgent>().speed = 2;

    }
}
