using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryComprobate : MonoBehaviour
{
    [SerializeField]
    GameObject Pantalla_victoria;

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0 && Pantalla_victoria.activeSelf == false)
        {
            Pantalla_victoria.SetActive(true);
            Debug.Log("Victoria");           
            GlobalSpeed.instance.speed = 0;
        }
    }
    public void Reinicio()
    {
        SceneManager.LoadScene(0);
    }
}
