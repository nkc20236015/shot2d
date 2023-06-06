using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 dir = Vector2.zero;//移動方向を保存する変数
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5;
        //移動方向をセット
        dir.y = Input.GetAxisRaw("Vertical");
        dir.x = Input.GetAxis("Horizontal");

        transform.position += dir.normalized * speed * Time.deltaTime;//1フレームごとに計算

        //画面内移動制限
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x,-9f,9f);
        pos.y = Mathf.Clamp(pos.y,-5f,5f);
        transform.position = pos;
        //if(y == 0)
        //{
        //    Anim.Play("Player");
        //}
        //else if(y == 1)
        //{
        //    Anim.Play("PlayerL"):
        //}
        //else if(y == -1)
        //{
        //    Anim.Play("PlayerR");
        //}
    }
}
