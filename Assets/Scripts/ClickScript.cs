using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
public class ClickScript : MonoBehaviour {
 
   
    public Image clickMeter;
    public float curMeter, maxMeter;
    public float incMeter;
    public float decMeter;
    public float meterReduceTimer;
    public float timeBetweenClicks;


    void Update () {
        ImageChange();
        MaxMinValue();
        Clicking();
        ReduceMeter();
    }
 
    public void Clicking()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
                curMeter += incMeter;
                meterReduceTimer = 0;
            
        }
    }
 
    void ReduceMeter()
    {
        meterReduceTimer += 1;
        if(meterReduceTimer > timeBetweenClicks)
        {
            curMeter -= decMeter;
        }
    }
 
    void ImageChange()
    {
        clickMeter.fillAmount = curMeter / maxMeter;
    }
 
    void MaxMinValue()
    {
 
        if(curMeter < 0)
        {
            curMeter = 0;
        }else if(curMeter > maxMeter)
        {
            curMeter = maxMeter;
        }
    }
}
 