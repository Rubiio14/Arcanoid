using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loser_Screen : MonoBehaviour
{
    [SerializeField]
    GameObject derrota;
    [SerializeField]
    Ball_Behaviour ball;
    [SerializeField]
    Player_Behaviour player;
    [SerializeField]
    Score score;
    
    void Update()
    {
        if (ball.lifes == 0)
        {
            derrota.SetActive(true);
            player.stop = true;
            ball.stop = true;
        }
    }
}
