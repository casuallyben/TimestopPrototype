using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManaging : MonoBehaviour
{
    public float myDelta;
    public float myFixedDelta;
    public float myTimeScale = 1;

    public static TimeManaging instance;

    public static TimeManaging GetInstance()
    {
        return instance;
    }


    void Awake()
    {
        instance = this;
    }

   
    void FixedUpdate()
    {
        myFixedDelta = Time.fixedDeltaTime * myTimeScale;
    }

    void update()
    {
        myDelta = Time.deltaTime * myTimeScale;
    }
}
