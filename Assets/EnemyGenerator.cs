using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab; //敵のぷれふぁぶを保存する変数
    float delta;                   //経過時間計算用
    float span;                    //敵を出す間隔(秒)
    // Start is called before the first frame update
    void Start()
    {
        delta = 0;
        span = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //経過時間を加算
        delta += Time.deltaTime;

        /*if (delta > 0.5f)*///敵の出現のスパン  1fだったら　１秒で出る　3fだったら　３秒で出る　0.5fだったら０．５秒で出る
        //↓spanに置き換える
        if(delta > span)
        {
            //敵を生成する
            GameObject go = Instantiate(EnemyPrefab); //クローンを作るInstantiat
            float py = Random.Range(-6f,7f);
            go.transform.position = new Vector3(10,py,0);

            //時間経過を初期化　（どんどん上がっていくため
            delta = 0;

            //敵を出す感覚を徐々に短くする
            span -= (span > 0.5f)? 0.01f : 0f;
        }


    }
}
