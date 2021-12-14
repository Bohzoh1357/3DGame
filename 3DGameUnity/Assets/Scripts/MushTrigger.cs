using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushTrigger : MonoBehaviour
{
    private int mushCount = 5;
    GameObject mushes = null;

    public static bool mushroomsFound;
    // Start is called before the first frame update
    void Start()
    {
        mushroomsFound = false;
        mushCount = 5;
        mushes = GameObject.Find("Mushrooms");

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mushCount = mushes.transform.childCount;
        if(mushCount < 1)
        {
            mushroomsFound = true;

            Debug.Log("Mushes found!");
        }
    }
}
