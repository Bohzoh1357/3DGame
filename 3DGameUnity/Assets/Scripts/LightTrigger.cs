using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTrigger : MonoBehaviour
{

    public GameObject light1;
    public GameObject light2;

    public static bool openDoor;

    private void Awake()
    {
        openDoor = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Triggered!");
        if (other.CompareTag("Player"))
        {
            light1.SetActive(true);
            light2.SetActive(true);
            // play scary sound effect too?
            openDoor = true;
        }
    }
}
