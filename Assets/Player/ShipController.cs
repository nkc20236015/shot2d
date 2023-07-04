using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipController : MonoBehaviour
{
    Rigidbody2D rd2d;
    Vector3 dir = Vector3.zero;
    public float timer;
    public float speed;

    public GameObject BulletPre1R;
    public GameObject BulletPre1L;

    AudioSource audioSource;

    const int MAX_SE = 1;
    AudioClip[]SeClip = new AudioClip[MAX_SE];
    int SeNumber = 0;

    public GameObject HIt;
    //�ق��̃X�N���v�g����X�s�[�h��ς����
    public float Speed
    {
        set
        {
            speed = value;
            speed = Mathf.Clamp(speed, 1, 20);
        }
        get { return speed; }
    }
    private void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
        timer     = 0;  // ���ԏ�����
        speed     = 10; // �����X�s�[�h

        //SE�t�@�C�������p�X�t�ŕۑ�
        string[] SeName =
        {
            "Audio/SE/laser1",
        };
        //SE���ق��񂷂�
        for(int i = 0; i< MAX_SE; i++)
        {
            SeClip[i] = Resources.Load<AudioClip>(SeName[i]);
        }
        //hack���[�h���I�t�ɂ���
        GetComponent<MaterialController>().enabled = false;
    }
    void Update()
    {
        //�e�̐���
        timer += Time.deltaTime;
        //R
        if (timer >= 0.5f && Input.GetKey(KeyCode.Z))
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = SeClip[SeNumber];
            audioSource.Play();

            timer = 0;
            // �e�̐����ʒu�̓v���[���[�Ɠ����ꏊ
            Vector3 p = transform.position;
            p.x += 0.2f;
            Quaternion rot = Quaternion.Euler(0,0,90);
            // �ʒu�Ɖ�]�����Z�b�g���Đ���
            //R
            Instantiate(BulletPre1R, p, rot);
            //L
            p.x +=-0.4f;
            Instantiate(BulletPre1L, p, rot);


        }
        //�v���C���[�͉��ړ������ł��Ȃ�
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        transform.position += dir.normalized * speed * Time.deltaTime;

        //�ړ�����
       Vector2 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -8.75f, 8.75f);
        pos.y = Mathf.Clamp(pos.y, -4.83f, 4.83f);
        transform.position = pos;


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var hit = collision.gameObject;
        var health = hit.GetComponent<Health>();

        if(collision.tag == "enemyshot")
        {
            Instantiate(HIt,this.transform.position,Quaternion.identity);

            Destroy(collision.gameObject);

            //health.TakeDamage(20);
            SceneManager.LoadScene("TitleScene");
        }
    }
}
 