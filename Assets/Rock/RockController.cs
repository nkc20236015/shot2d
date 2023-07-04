using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RockController : MonoBehaviour
{
    float speed = 2f;

    void Start()
    {
        Destroy(gameObject,10f);
    }

    void Update()
    {
        transform.Rotate(0,0,0.1f);
        transform.position += transform.up * speed * Time.deltaTime;
    }
}
