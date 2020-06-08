using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaOnPlatformSpawns : MonoBehaviour
{
    [SerializeField]
     GameObject Banana, Bananass;

    [SerializeField]
    Transform spawn_pos;

   

    private void Start()
    {
        GameObject newBanana = null; 
        if(Random.Range(0,10)>4)
        {
            newBanana= Instantiate(Banana, spawn_pos.position, Quaternion.identity);
        }
        else
        {
          newBanana =  Instantiate(Bananass, spawn_pos.position, Quaternion.identity);
        }

        newBanana.transform.parent = transform;
    }











}//class
