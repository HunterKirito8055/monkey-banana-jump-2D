using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public static PlatformSpawner instance;
   
     

    [SerializeField]
    GameObject Left_platform, Right_platform; //2 prefabs we created

    public Transform Platform_parent;

   public  int spawn_count = 8; //no. of platform we gonna give

    float y_offset = 2.6f; //idstance between platforms 
    float suppose_y;
    float left_min = -2.8f, left_max = -4.4f, right_min = 2.8f, right_max = 4.4f;



    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    private void Start()
    {
        suppose_y = transform.position.y;
        StartSpawning();
    }
    
    public void StartSpawning()
    {
        Vector2 temp = Vector2.zero; ;
        GameObject newspawnPoint; ; ; ; ;
        ;
        for (int i = 0; i < spawn_count; i++)
        {
            temp.y = suppose_y;// starting Y shold be same as in Gameobject under maincamera

            
            if (i % 2 == 0) //we are making equal num of spawnpoints on left side and right side
            {
                temp.x = Random.Range(left_min, left_max);
                newspawnPoint = Instantiate(Left_platform, temp, Quaternion.identity);
            }
            else
            {
                temp.x = Random.Range(right_min, right_max);
                newspawnPoint = Instantiate(Right_platform, temp, Quaternion.identity);
            }
            suppose_y += y_offset;
            newspawnPoint.transform.parent = Platform_parent;
        }
    }


}//class
