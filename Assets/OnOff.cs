using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOff : MonoBehaviour
{
	private Canvas canvas;

	void Start()
	{
		canvas = GetComponent<Canvas>(); 
		canvas.enabled = false; 
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Tab))
		{
			canvas.enabled = !canvas.enabled;
		}
	}
}
