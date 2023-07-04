using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float MoveSpeed;
    public float LifeTime;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector3.down * MoveSpeed;
        Destroy(this.gameObject ,LifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
