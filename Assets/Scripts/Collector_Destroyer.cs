using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector_Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "BG" || collision.tag == "Platform" || collision.tag== "Bird" || collision.tag == "Banana" || collision.tag == "Bananas")
        {
            collision.gameObject.SetActive(false);
        }
    }


}//class
