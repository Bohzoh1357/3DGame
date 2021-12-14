using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MushTrigger : MonoBehaviour
{
    private int mushCount = 5;
    GameObject mushes = null;
    GameObject canvs = null;
    GameObject textHold = null;

    public static bool mushroomsFound;
    // Start is called before the first frame update
    void Start()
    {
        mushroomsFound = false;
        mushCount = 5;
        mushes = GameObject.Find("Mushrooms");
        canvs = GameObject.Find("UserInterface");
        textHold = canvs.transform.GetChild(1).gameObject;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mushCount = mushes.transform.childCount;

        TMP_Text text = textHold.GetComponent<TMP_Text>();
        text.text = "Mushrooms Left: " + mushCount;
        if (mushCount < 1)
        {
            mushroomsFound = true;

            Debug.Log("Mushes found!");
        }
    }
}
