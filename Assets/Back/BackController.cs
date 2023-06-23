using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackController : MonoBehaviour
{
   
    void Update()
    {
        transform.Translate(0,-0.09f,0);
        if(transform.position.y < -20.3f)
        {
            transform.position = new Vector3(0,20.6f,0);
        }
    }
}
