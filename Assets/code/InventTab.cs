using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventTab : MonoBehaviour
{
    private bool open = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            open = !open;

            if (open)
            {
                Debug.Log("open");
            }
            else
            {
                Debug.Log("close");

            }
        }
    }
}