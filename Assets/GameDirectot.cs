using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirectot : MonoBehaviour
{
    ShipController playerCon; 
    // Start is called before the first frame update
    void Start()
    {
        playerCon = GameObject.Find("Player").GetComponent<ShipController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerCon)
        {

        }
    }
}
