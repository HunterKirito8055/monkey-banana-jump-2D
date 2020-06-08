using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float movespeed = 2.5f;

    private Rigidbody2D body;
    public int ExtraPush = 15;
    public int NormalPush = 10;
    // private bool touch = true; 


    int count = 0;
    bool Dead;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Move();
    }
    void Move()
    {
        if (!Dead)
        {
                if (Input.GetAxisRaw("Horizontal") > 0)
                {
                    body.velocity = new Vector2(movespeed, body.velocity.y);
                }

                else if (Input.GetAxisRaw("Horizontal") < 0)
                {
                    body.velocity = new Vector2(-movespeed, body.velocity.y);
                }
        }
    }


    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bananas")
        {
            //if(touch)
            // {
            // touch = false;
            body.velocity = new Vector2(body.velocity.x, ExtraPush);
            col.gameObject.SetActive(false);

            // return;// exit from onTriggerEnter as it is touched once.
            // }
            count++;
            //soundmanager
        }
        if (col.tag == "Banana")
        {
            body.velocity = new Vector2(body.velocity.x, NormalPush);
            col.gameObject.SetActive(false);
            // return;
            count++;
            //soundmanager
        }

                                               //if(col.tag == "BG")
                                               // {
                                               //     if(col.isActiveAndEnabled)
                                               //     {
                                               //         if(col.tag.)
               
        PlatformSpawner.instance.StartSpawning();
        
                                                        //    }
                                                        //}
        

    }
}//class

    