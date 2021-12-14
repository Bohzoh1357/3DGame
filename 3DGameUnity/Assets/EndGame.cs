using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public float secondsElapsed = 0f;

    private void FixedUpdate()
    {
        if(secondsElapsed > 15f)
        {
            Application.Quit();
        }
        else
        {
            secondsElapsed += Time.deltaTime;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
