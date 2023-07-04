using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float MoveSpeed;
    public GameObject Bullet;
    public GameObject Explosion;
    public float shotInterval;
    private float TimeCount;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector3.down * MoveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        TimeCount += Time.deltaTime;

        if (TimeCount > shotInterval)
        {
            Vector3 p = transform.position;
            Quaternion rot = Quaternion.Euler(0,0,0);
            Instantiate(Bullet,p,rot);
            TimeCount = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerATK")
        {
            Instantiate(Explosion,this.transform.position,Quaternion.identity);

            Destroy(collision.gameObject);

            Destroy(this.gameObject);
        }
    }
}
