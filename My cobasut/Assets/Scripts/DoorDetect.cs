using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDetect : MonoBehaviour
{
    public Animator anim;
    public Transform door;
    public Transform player;
    public float Pdistan;
    void Update()
    {
        float dist = Vector3.Distance(player.position,door.position);

        if (dist <= Pdistan)
        {
            anim.SetBool("near", true);
        }

        else
        {
            anim.SetBool("near", false);
        }
    }
}
