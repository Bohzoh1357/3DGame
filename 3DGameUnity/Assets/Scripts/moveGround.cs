using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveGround : MonoBehaviour
{

    public bool groundUnmoved;

    // Start is called before the first frame update
    void Start()
    {
        groundUnmoved = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(MushTrigger.mushroomsFound && groundUnmoved)
        {
            gameObject.transform.position += new Vector3(.5f * Time.deltaTime, 0f, 0f);
        }
        if (gameObject.transform.position.x >= 40f)
        {
            groundUnmoved = false;
        }
    }
}
