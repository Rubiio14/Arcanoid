using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Behaviour : MonoBehaviour
{
    
    [SerializeField]
    Brick_Behaviour brick_live;
    public int lifes = 3;
    [SerializeField]
    float ball_speed = 3f;
    [SerializeField]
    Vector3 direction;
    [SerializeField]
    Score scoreboard;
    public bool stop = false;

    void Start()
    {
        direction = Vector3.down;
    }

    void Update()
    {
        if (stop == false)
        {
            transform.position += direction * Time.deltaTime * ball_speed;
        }
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.CompareTag("Player"))
        {
            //Choque del jugador
            direction = Vector3.up;
            direction.x = Random.Range(-1f, 1f);
            transform.position += direction * Time.deltaTime * ball_speed;
        }
        if (col.gameObject.CompareTag("Blue_Score"))
        {
            //Franja_azul
            Choque();
            scoreboard.Blue_hit();
            if (brick_live.life == 0)
            {
                Destroy(col.gameObject);
            }
            
        }
        if (col.gameObject.CompareTag("Green_Score"))
        {
            //Franja_verde
            Choque();
            scoreboard.Green_hit();
            if (brick_live.life == 0)
            {
                Destroy(col.gameObject);
            }

        }
        if (col.gameObject.CompareTag("Orange_Score"))
        {
            //Franja_naranja
            Choque();
            scoreboard.Orange_hit();
            if (brick_live.life == 0)
            {
                Destroy(col.gameObject);
            }
        }
        if (col.gameObject.CompareTag("Pink_Score"))
        {
            //Franja_rosa
            Choque();
            scoreboard.Pink_hit();
            if (brick_live.life == 0)
            {
                Destroy(col.gameObject);
            }
        }
        if (col.gameObject.CompareTag("Red_Score"))
        {
            //Franja_Roja
            Choque();
            scoreboard.Red_hit();
            if (brick_live.life == 0)
            {
                Destroy(col.gameObject);
            }
        }
        if (col.gameObject.CompareTag("Lateral_Border"))
        {
            //Choque Borde Lateral
            direction.x = - direction.x;
            direction.y = Random.Range(-1f, 1f);
            transform.position += direction * Time.deltaTime * ball_speed;
        }
        if (col.gameObject.CompareTag("Top_Border"))
        {
            //Choque Borde Superior
            direction.y = -direction.y;
            direction.x = Random.Range(-1f, 1f);
            transform.position += direction * Time.deltaTime * ball_speed;
        }
        if (col.gameObject.CompareTag("Bot_Border"))
        {
            //Reseta vidas
            lifes -= 1;
            scoreboard.UpdateScoreText();
            //scoreboard.ResetScore();
            ball_speed = 3f;
            transform.position = new Vector3(0,-1,0);
        }
    }
    void Choque()
    {
        //Mueve la bola cada vez que choca contra un objeto
        ball_speed += 0.5f;
        direction.y = - direction.y;
        direction.x = Random.Range(-1f, 1f);
        transform.position += direction * Time.deltaTime * ball_speed;
        
    }
}
