using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControtller : MonoBehaviour
{
    AudioSource audioSource;
    const int Max_BGM = 1;//BGM�̂���
    AudioClip[] bgmClip = new AudioClip[Max_BGM];//�I�[�f�B�I�N���b�v�ۑ�
    int bgmNumber = 0;//BGM�Ǘ��ԍ�

    void Start()
    {
        //BGM�t�@�C�������p�X�t�ŕۑ�
        string[] bgmname = {
            //"Audio/BGM/iwashiro_May_Be_A_Battle",//bgnm[1]
            "Audio/BGM/iwashiro_g_daisan_keitai",
            };

        //�I�[�f�B�I�N���b�v���Ăэ���
        for(int i = 0; i < Max_BGM; i++)
        {
            bgmClip[i] = Resources.Load<AudioClip>(bgmname[i]);
        }

        //BGM���Đ�
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = bgmClip[bgmNumber];
        audioSource.Play();
    }

}
