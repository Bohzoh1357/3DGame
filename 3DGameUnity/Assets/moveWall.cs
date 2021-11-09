using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWall : MonoBehaviour
{
    public bool wallUnmoved;

    private void Awake()
    {
        wallUnmoved = true;
    }

    private void FixedUpdate()
    {
        if (LightTrigger.openDoor && wallUnmoved)
        {
            gameObject.transform.position += new Vector3(.5f * Time.deltaTime, 0f, 0f);
        }
        if(gameObject.transform.position.x >= 16f)
        {
            wallUnmoved = false;
        }
    }
}
