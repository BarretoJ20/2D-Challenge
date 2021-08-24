using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject[] bullets;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Instantiate(bullets[0], transform.position, Quaternion.identity);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(bullets[1], transform.position, Quaternion.identity);

        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(bullets[2], transform.position, Quaternion.identity);
            

        }
    }

    
   
}
