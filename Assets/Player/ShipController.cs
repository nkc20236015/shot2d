using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    Vector3 dir = Vector3.zero;
    float speed = 10f;

    void Start()
    {
        
    }

    void Update()
    {
        //�v���C���[�͉��ړ������ł��Ȃ�
        dir.x = Input.GetAxisRaw("Horizontal");
        transform.position += dir.normalized * speed * Time.deltaTime;

        //�ړ�����
       Vector2 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -2.2f, 2.2f);
        transform.position = pos;
    }
}
 