using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minimapScript : MonoBehaviour
{
    public Transform player;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPosition = player.position;
        newPosition.y = player.position.y + 4f;
        transform.position = newPosition;

    }
}
