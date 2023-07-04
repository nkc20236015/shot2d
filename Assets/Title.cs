using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
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
            "Audio/BGM/iwashiro_kakumeigun",
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
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}