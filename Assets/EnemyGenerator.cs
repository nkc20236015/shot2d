using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject EnemyPrefab; //“G‚Ì‚Õ‚ê‚Ó‚Ÿ‚Ô‚ð•Û‘¶‚·‚é•Ï”
    float delta;                   //Œo‰ßŽžŠÔŒvŽZ—p
    float span;                    //“G‚ðo‚·ŠÔŠu(•b)
    // Start is called before the first frame update
    void Start()
    {
        delta = 0;
        span = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //Œo‰ßŽžŠÔ‚ð‰ÁŽZ
        delta += Time.deltaTime;

        /*if (delta > 0.5f)*///“G‚ÌoŒ»‚ÌƒXƒpƒ“  1f‚¾‚Á‚½‚ç@‚P•b‚Åo‚é@3f‚¾‚Á‚½‚ç@‚R•b‚Åo‚é@0.5f‚¾‚Á‚½‚ç‚OD‚T•b‚Åo‚é
        //«span‚É’u‚«Š·‚¦‚é
        if(delta > span)
        {
            //“G‚ð¶¬‚·‚é
            GameObject go = Instantiate(EnemyPrefab); //ƒNƒ[ƒ“‚ðì‚éInstantiat
            float py = Random.Range(-6f,7f);
            go.transform.position = new Vector3(10,py,0);

            //ŽžŠÔŒo‰ß‚ð‰Šú‰»@i‚Ç‚ñ‚Ç‚ñã‚ª‚Á‚Ä‚¢‚­‚½‚ß
            delta = 0;

            //“G‚ðo‚·Š´Šo‚ð™X‚É’Z‚­‚·‚é
            span -= (span > 0.5f)? 0.01f : 0f;
        }


    }
}
