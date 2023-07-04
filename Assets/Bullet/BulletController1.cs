using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController1 : MonoBehaviour
{
    float speed = 20.0f;
    void Start()
    {
        Destroy(gameObject,2f);   
    }

    void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;   
    }
}
