using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransportPlayer : MonoBehaviour
{
    public GameObject teleportTarget;
    //public GameObject thePlayer;
    // When a player walks into this box, instantly transports them to the same place in a floorboard in a different area!

    private void OnTriggerEnter(Collider other)
    {

        CharacterController charControll = other.GetComponent<CharacterController>();
        Debug.Log("TRIGGER!");
        //if (other.tag.Equals("Player"))
        //{
        Debug.Log(other.transform.position);
        Vector3 relativePos = gameObject.transform.position - other.transform.position;
        other.GetComponent<CapsuleCollider>().enabled = false;
        Debug.Log(relativePos);
        charControll.Move(teleportTarget.transform.position - relativePos);
        Debug.Log(other.transform.position);
        other.GetComponent<CapsuleCollider>().enabled = true;
        // send to OTHER box's location.
        //}
    }
}
