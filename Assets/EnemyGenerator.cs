using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab; //�G�̂Ղ�ӂ��Ԃ�ۑ�����ϐ�
    float delta;                   //�o�ߎ��Ԍv�Z�p
    float span;                    //�G���o���Ԋu(�b)
    // Start is called before the first frame update
    void Start()
    {
        delta = 0;
        span = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //�o�ߎ��Ԃ����Z
        delta += Time.deltaTime;

        /*if (delta > 0.5f)*///�G�̏o���̃X�p��  1f��������@�P�b�ŏo��@3f��������@�R�b�ŏo��@0.5f��������O�D�T�b�ŏo��
        //��span�ɒu��������
        if(delta > span)
        {
            //�G�𐶐�����
            GameObject go = Instantiate(EnemyPrefab); //�N���[�������Instantiat
            float py = Random.Range(-6f,7f);
            go.transform.position = new Vector3(10,py,0);

            //���Ԍo�߂��������@�i�ǂ�ǂ�オ���Ă�������
            delta = 0;

            //�G���o�����o�����X�ɒZ������
            span -= (span > 0.5f)? 0.01f : 0f;
        }


    }
}
