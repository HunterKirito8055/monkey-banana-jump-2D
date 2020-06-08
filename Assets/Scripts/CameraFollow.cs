using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class CameraFollow : MonoBehaviour
{
    private Transform target;
   
    Vector3 currentVelocity;

    bool followplayer;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void FixedUpdate()
    {
        Follow();
    }
    void Follow()
    {
        if (target.position.y >= transform.position.y)
        {
 
            followplayer = true;
        }
        if(target.position.y < (transform.position.y - -1f))
        { followplayer = false; }

        if (followplayer)
        {
            Vector3 tem = Vector3.SmoothDamp(transform.position, target.position, ref currentVelocity, 0.1f);
            transform.position = new Vector3(transform.position.x, tem.y,-10);
        }

    }


}//class
