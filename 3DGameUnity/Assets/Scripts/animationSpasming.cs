using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationSpasming : MonoBehaviour
{
    public Animator animator;
    private bool going;

    private void Awake()
    {
        going = false;
    }
    private void FixedUpdate()
    {
        if (LightTrigger.openDoor && !going)
        {
            going = true;
            animator.SetTrigger("LightTriggered");
        }
    }
}
