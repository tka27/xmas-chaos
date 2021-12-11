using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsBar : MonoBehaviour
{
    private Slider slider;
    private float targetProgress = 0;
    public float fillSpeed = 0.5f;
    void Start()
    {
        IncrementProgress(1f);
    }
    void Update()
    {
        if (slider.value < targetProgress)
            slider.value += fillSpeed * Time.deltaTime;
    }

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }
}
