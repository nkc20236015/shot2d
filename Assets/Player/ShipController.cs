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
    //ほかのスクリプトからスピードを変えれる
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
        timer     = 0;  // 時間初期化
        speed     = 10; // 初期スピード

        //SEファイル名をパス付で保存
        string[] SeName =
        {
            "Audio/SE/laser1",
        };
        //SEをほぞんする
        for(int i = 0; i< MAX_SE; i++)
        {
            SeClip[i] = Resources.Load<AudioClip>(SeName[i]);
        }
        //hackモードをオフにする
        GetComponent<MaterialController>().enabled = false;
    }
    void Update()
    {
        //弾の生成
        timer += Time.deltaTime;
        //R
        if (timer >= 0.5f && Input.GetKey(KeyCode.Z))
        {
            audioSource = GetComponent<AudioSource>();
            audioSource.clip = SeClip[SeNumber];
            audioSource.Play();

            timer = 0;
            // 弾の生成位置はプレーヤーと同じ場所
            Vector3 p = transform.position;
            p.x += 0.2f;
            Quaternion rot = Quaternion.Euler(0,0,90);
            // 位置と回転情報をセットして生成
            //R
            Instantiate(BulletPre1R, p, rot);
            //L
            p.x +=-0.4f;
            Instantiate(BulletPre1L, p, rot);


        }
        //プレイヤーは横移動しかできない
        dir.x = Input.GetAxisRaw("Horizontal");
        dir.y = Input.GetAxisRaw("Vertical");
        transform.position += dir.normalized * speed * Time.deltaTime;

        //移動制限
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
 