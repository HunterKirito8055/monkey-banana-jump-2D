using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.TerrainAPI;
using UnityEngine;

public class BGSpawner : MonoBehaviour
{
    GameObject[] bgs;
    float height;
    float highest_Y_pos;

    private void Awake()
    {
        bgs = GameObject.FindGameObjectsWithTag("BG");
    }

    private void Start()
    {
        height = bgs[0].GetComponent<BoxCollider2D>().bounds.size.y;
       // print(height);

        highest_Y_pos = bgs[0].transform.position.y; //getting highest pos Y as in the top Backgrounds position.y
        //so after this gameobject gets into that top position, we need to produce more backgrounds in top continuioysly

       for(int i =0; i<bgs.Length; i++)
        {
            if(bgs[i].transform.position.y >highest_Y_pos)
            {
                highest_Y_pos = bgs[i].transform.position.y;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BG")
        {
            //we collided with highest Y bg OK./??
            if (collision.transform.position.y >= highest_Y_pos)
            {
                Vector3 temp = collision.transform.position;

                for (int i = 0; i < bgs.Length; i++)
                {
                    //if bg at i Index is not active in hierarchy
                    if(!bgs[i].gameObject.activeInHierarchy)
                    {
                        temp.y += height;
                        bgs[i].gameObject.transform.position = temp;
                        bgs[i].SetActive(true);
                    }
                }
            }
        }
    }//ontriggerenter





}//class


