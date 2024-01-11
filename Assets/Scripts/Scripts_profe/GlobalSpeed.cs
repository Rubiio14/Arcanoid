using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalSpeed : MonoBehaviour
{
    public static GlobalSpeed instance;
    public int speed = 1;
	private void Awake()
    {
        
        if (GlobalSpeed.instance == null!)
        {
            GlobalSpeed.instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
}
