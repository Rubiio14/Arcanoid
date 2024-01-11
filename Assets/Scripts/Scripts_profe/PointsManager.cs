using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PointsManager : MonoBehaviour
{

    public static PointsManager instance;

    public int score = 0;
    [SerializeField]
    TextMeshProUGUI textScore;
    
    private void Awake()
    {
        if (PointsManager.instance == null)
        {
            PointsManager.instance = this;
        }
        else
        {
            Destroy(this);
        }       
    }
    private void Start()
    {
        textScore.text = "0000";

    }
    public void AddPoints(int points)
    {
        score += points;
        textScore.text = score.ToString("0000");
    
    }

}
