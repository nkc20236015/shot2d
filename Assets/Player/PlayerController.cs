using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 dir = Vector2.zero;//�ړ�������ۑ�����ϐ�
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 5;
        //�ړ��������Z�b�g
        dir.y = Input.GetAxisRaw("Vertical");
        dir.x = Input.GetAxis("Horizontal");

        transform.position += dir.normalized * speed * Time.deltaTime;//1�t���[�����ƂɌv�Z

        //��ʓ��ړ�����
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
