using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    //Instancia para vidas
    public static PlayerBehaviour instance;

    [SerializeField]
    float playerSpeed = 3f;
    //Pantalla Derrota
    public int lifes = 3;
    [SerializeField]
    TextMeshProUGUI LifesScoreboard;
    [SerializeField]
    GameObject Pantalla_derrota;
    
 

    private void Awake()
    {
        if (PlayerBehaviour.instance == null!)
        {
            PlayerBehaviour.instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed * GlobalSpeed.instance.speed, 0.0f, 0.0f);
 
        
    }

    void Derrota()
    {
        if (lifes == 0)
        {
            GlobalSpeed.instance.speed = 0;
            Pantalla_derrota.SetActive(true);
            Debug.Log("Derrota");
        }
    }

    public void RemoveLife()
    {
        lifes--;
        LifesScoreboard.text = "Vidas : " + lifes.ToString("0");
        Derrota();
    }

    public void Reinicio()
    {
        SceneManager.LoadScene(0);
    }

  
}
