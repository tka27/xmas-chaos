using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click : MonoBehaviour
{
    public Text ClickTotalText;
    float TotalClicks;
    public static bool MouseDown = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (MouseDown)
            {
                AddClicks();
            }
        }
       
    }

    public void AddClicks()
    {
        TotalClicks++;
        ClickTotalText.text = TotalClicks.ToString("0");
    }

}
