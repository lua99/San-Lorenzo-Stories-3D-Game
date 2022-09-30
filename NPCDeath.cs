using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCDeath : MonoBehaviour
{

    public int npcHealth = 20;
    public bool npcDead = false;
    public GameObject npcObjecct;
    public GameObject interactionTrigger;
    public GameObject helpMe;

    void HurtNPC(int shotDamage)
    {
        npcHealth -= shotDamage;
    }

    
    void Update()
    {
        this.gameObject.transform.position = npcObjecct.transform.position;
        if(npcHealth <= 0 && npcDead == false)
        {
            npcDead = true;
            StartCoroutine(EndNPC());
        }
    }

    IEnumerator EndNPC()
    {
        GlobalWanted.wantedLevel += 1;
        GlobalWanted.activateStar = true;
        npcObjecct.GetComponent<NPCAI>().enabled = false;
        npcObjecct.GetComponent<NavMeshAgent>().enabled = false;
        npcObjecct.GetComponent<BoxCollider>().enabled = false;
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        interactionTrigger.SetActive (false);
        yield return new WaitForSeconds(0.1f);
        npcObjecct.GetComponent<Animator>().Play("Dying");
        helpMe.SetActive(false);
        yield return new WaitForSeconds(3);
        npcObjecct.GetComponent<Animator>().enabled = false;

    }
}
