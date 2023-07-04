using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControtller : MonoBehaviour
{
    AudioSource audioSource;
    const int Max_BGM = 1;//BGMのかず
    AudioClip[] bgmClip = new AudioClip[Max_BGM];//オーディオクリップ保存
    int bgmNumber = 0;//BGM管理番号

    void Start()
    {
        //BGMファイル名をパス付で保存
        string[] bgmname = {
            //"Audio/BGM/iwashiro_May_Be_A_Battle",//bgnm[1]
            "Audio/BGM/iwashiro_g_daisan_keitai",
            };

        //オーディオクリップを呼び込む
        for(int i = 0; i < Max_BGM; i++)
        {
            bgmClip[i] = Resources.Load<AudioClip>(bgmname[i]);
        }

        //BGMを再生
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = bgmClip[bgmNumber];
        audioSource.Play();
    }

}
