using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameDirector : MonoBehaviour
{
    public Text kyoriLabel;//������\������UI-TExt�I�u�W�F�N�g
    int kyori;//������ۑ�����ϐ�

    public Image timeGauge;//�^�C���Q�[�W��\������UI�I�u�W�F�N�g   public������ƃA�^�b�`�ł���
    float lastTime;   //�c�莞�Ԃ�ۑ�����ϐ�
    void Start()
    {
        kyori = 0;

        lastTime = 100.0f;//�c�莞��100�b
    }

    // Update is called once per frame
    void Update()
    {
        //�i�񂾋�����\��
        kyori++;
        kyoriLabel.text = kyori.ToString("D6")+"km";

        //�c�莞�Ԃ����炷����
        lastTime -= Time.deltaTime;
        timeGauge.fillAmount = lastTime/100f;//fillAmount���P������/100������

        //�c�莞�Ԃ��O�ɂȂ����烊���[�h
        if(lastTime < 0)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
