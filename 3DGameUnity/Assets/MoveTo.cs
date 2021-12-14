using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

public class MoveTo : MonoBehaviour
{
    public bool inRange = false;
    public bool wasFound = false;

    public GameObject player;

    private float time = 0f;

    GameObject canvs = null;
    GameObject txtpro = null;
    //TMP_Text textThing = null;
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //text
            inRange = true;
            this.gameObject.GetComponent<NavMeshAgent>().speed = 4.5f;
            wasFound = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inRange = false;
            this.gameObject.GetComponent<NavMeshAgent>().speed = 3.5f;
        }
    }

    private void FixedUpdate()
    {
        time += Time.deltaTime;
        if (inRange)
        {
            this.transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
            this.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
            if(time > 0.5f)
            {
                this.GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
                time = 0f;
            }
        } else
        {
            this.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
            this.transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
            if (wasFound)
            {
                if (time > 2f)
                {
                    this.GetComponent<NavMeshAgent>().SetDestination(player.transform.position);
                    time = 0f;
                }
            }
        }
    }

}
