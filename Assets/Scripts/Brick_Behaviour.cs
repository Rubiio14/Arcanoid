using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick_Behaviour : MonoBehaviour
{
    public int life = 1;
   
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ball"))
        {
            life -= 1;
        }
    }
}
