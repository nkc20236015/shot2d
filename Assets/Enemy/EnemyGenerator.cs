using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy;
    public float Interval;
    private float TimeCount;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        TimeCount += Time.deltaTime;

        if(TimeCount > Interval)
        {
            TimeCount = 0;
            float x = Random.Range(-8f,8f);
            Vector3 position = new Vector3(x,8f,0);

            Instantiate(Enemy,position,Quaternion.identity);
        }
        
    }
}
