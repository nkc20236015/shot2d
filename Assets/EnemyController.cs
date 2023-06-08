using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Vector3 dir = Vector3.zero;//�ړ�������ۑ�����ϐ�
    float speed = 5;

    void Start()
    {
        //����4�b
        Destroy(gameObject,4f);
    }

    
    void Update()
    {
        //�ړ�����������
        dir = Vector3.left;

        //���ݒn�Ɉړ��ʂ����Z
        transform.position += dir.normalized * speed * Time.deltaTime;
    }

    private  void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Enemy OnTriggerEnter2D");  ������̂��m�F


        //����������P�O�b���炷
        GameDirector.lastTime -= 10f;
        //�ق��̃Q�[���I�u�W�F�N�g�Ɠ�����Ə�����
        Destroy(gameObject);
    }
}
