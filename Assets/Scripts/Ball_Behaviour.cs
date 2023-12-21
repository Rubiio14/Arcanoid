using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Behaviour : MonoBehaviour
{
    [SerializeField]
    float ball_speed = 3f;
    [SerializeField]
    Vector3 direction;
    [SerializeField]
    Score scoreboard;


    void Start()
    {
        direction = Vector3.down;
    }

    void Update()
    {
        transform.position += direction * Time.deltaTime * ball_speed;
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
            Destroy(col.gameObject);
        }
        if (col.gameObject.CompareTag("Green_Score"))
        {
            //Franja_verde
            Choque();
            scoreboard.Green_hit();
            Destroy(col.gameObject);
        }
        if (col.gameObject.CompareTag("Orange_Score"))
        {
            //Franja_naranja
            Choque();
            scoreboard.Orange_hit();
            Destroy(col.gameObject);
        }
        if (col.gameObject.CompareTag("Pink_Score"))
        {
            //Franja_rosa
            Choque();
            scoreboard.Pink_hit();
            Destroy(col.gameObject);
        }
        if (col.gameObject.CompareTag("Red_Score"))
        {
            //Franja_Roja
            Choque();
            scoreboard.Red_hit();
            Destroy(col.gameObject);
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
            //Reseteo
            scoreboard.ResetScore();
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
