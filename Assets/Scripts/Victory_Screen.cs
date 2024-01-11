using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory_Screen : MonoBehaviour
{
    [SerializeField]
    GameObject victoria;
    [SerializeField]
    Ball_Behaviour ball;
    [SerializeField]
    Player_Behaviour player;
    
    void Update()
    {
        if (transform.childCount == 0)
        {
            victoria.SetActive(true);
            player.stop = true;
            ball.stop = true;
        }
    }
    
}