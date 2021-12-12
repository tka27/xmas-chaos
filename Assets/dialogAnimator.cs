using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogAnimator : MonoBehaviour
{
    public Animator startAnim;
    public DialogManager dm;

    public void OnTriggerEnter2D(Collider2D other)
    {
        startAnim.SetBool("startOpen", true);
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        startAnim.SetBool("startOpen", true);
        dm.EndDialog();
    }
}

