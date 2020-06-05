using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputThingy : MonoBehaviour
{

    TimeManaging tm;

    float targetScale;
    float lerpSpeed = 2;

    
    void Start()
    {
        tm = TimeManaging.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if(mouseX != 0 || mouseY != 0)
        {
            targetScale = 0.5f;
            lerpSpeed = 10;
        }
        else
        {
            if (Input.anyKey)
            {
                targetScale = 1;
                lerpSpeed = 10;
            }
            else
            {
                targetScale = 0;
                lerpSpeed = 4;
            }
        }

        tm.myTimeScale = Mathf.Lerp(tm.myTimeScale, targetScale, Time.deltaTime * lerpSpeed);
    }

}
