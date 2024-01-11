using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickComponent : MonoBehaviour
{
    //Animacion bloque
    [SerializeField]
    float animationTime = 0.5f;
    [SerializeField]
    LeanTweenType animationCurve;

    public float probability = 0;
    public int points = 10;
    public int hitsToDie = 1;

    public void RecieveHit()
    {
        hitsToDie--;
        if(hitsToDie == 0)
        {
            if(Random.Range(0f, 1f) < probability)
            {
                PointsManager.instance.AddPoints(Random.Range(50, 100));
            }
            PointsManager.instance.AddPoints(points);
            LeanTween.scale(gameObject, Vector3.zero,animationTime).setEase(animationCurve).setOnComplete(() => 
            {
                Destroy(gameObject);
            });
            //Destroy(gameObject);    
        }
    }
}
