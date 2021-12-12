using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTopDown : MonoBehaviour
{
    public float speed;
    private float FastSpeed = 11;
    private float RealSpeed;
    public Animator animator;
    private Vector2 direction;
    private Rigidbody2D rb;
    public VectorValue pos;

    void Start()
    {
        transform.position = pos.initialValue;
        rb = GetComponent<Rigidbody2D>();
        RealSpeed = speed;
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", direction.x);
        animator.SetFloat("Vertical", direction.y);
        animator.SetFloat("Speed", direction.sqrMagnitude);
    }
    private void FixedUpdate()
    {
        Run();
        rb.MovePosition(rb.position + direction * RealSpeed * Time.fixedDeltaTime);
    }
    void Run()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("run", true);
            RealSpeed = FastSpeed;
        }
        else
        {
            animator.SetBool("run", false);
            RealSpeed = speed;
        }
    }    
}
