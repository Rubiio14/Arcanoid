using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Behaviour : MonoBehaviour
{
    [SerializeField]
    KeyCode buttonRight, buttonLeft;
    [SerializeField]
    Vector3 direction;
    [SerializeField]
    private float Player_Speed;
    public bool stop = false;

    void Update()
    {
        //Movimiento del juagdor
        if (stop == false)
        {
            if (Input.GetKey(buttonRight))
            {
                direction = Vector3.right;
                transform.position += direction * Time.deltaTime * Player_Speed;
            }
            else if(Input.GetKey(buttonLeft))
            {
                direction = Vector3.left;
                transform.position += direction * Time.deltaTime * Player_Speed;
            }
        }
        
       
    }
}
