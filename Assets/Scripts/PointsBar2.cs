using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsBar2 : MonoBehaviour
{
    private Image pointsBar;
    public float pointsAmount = 100;
    public float secondEmptyPoints = 60f;
    void Start()
    {
        pointsBar.fillAmount = pointsAmount / 100;
    }
    void Update()
    {
        if(pointsAmount > 0)
        {
            pointsAmount = 100 / secondEmptyPoints * Time.deltaTime;
            pointsBar.fillAmount = pointsAmount / 100;
        }
    }
}
