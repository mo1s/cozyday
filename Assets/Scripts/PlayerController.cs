using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    private Rigidbody2D rb;
    private Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.y = Input.GetAxisRaw("Vertical");
        if(direction.y == -1)
        {
            anim.SetBool("PlayerGuyWalkForward", true);
        }
        else
        {
            anim.SetBool("PlayerGuyWalkForward", false);
        }
        if(direction.y == 1)
        {
            anim.SetBool("PlayerGuyWalkBack", true);
        }
        else
        {
            anim.SetBool("PlayerGuyWalkBack", false);
        }
        if(direction.x == -1)
        {
            anim.SetBool("PlayerGuyWalkLeft", true);
        }
        else
        {
            anim.SetBool("PlayerGuyWalkLeft", false);
        }
        if(direction.x == 1)
        {
            anim.SetBool("PlayerGuyWalkRight", true);
        }
        else
        {
            anim.SetBool("PlayerGuyWalkRight", false);
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}
