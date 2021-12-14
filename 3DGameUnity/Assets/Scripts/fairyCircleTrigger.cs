using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fairyCircleTrigger : MonoBehaviour
{
    public GameObject Spotlight;
    public GameObject Fireflies;
    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    public GameObject light5;
    public GameObject light6;
    public GameObject light7;
    public GameObject exit;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered!");
        if (other.CompareTag("Player"))
        {
            Spotlight.SetActive(true);
            Fireflies.SetActive(true);
            // play scary sound effect too?
            light1.SetActive(true);
            light2.SetActive(true);
            light3.SetActive(true);
            light4.SetActive(true);
            light5.SetActive(true);
            light6.SetActive(true);
            light7.SetActive(true);
            exit.SetActive(true);

        }
    }
}
