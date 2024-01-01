using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroMove : MonoBehaviour
{
    Rigidbody2D body;


    private float speed = 1f;

    public Transform kaki_kiri;
    public Transform kaki_kanan;
    public LayerMask groundLayer;
    public Animator anim;

    public bool isGrounded = false;

    //Animation
    //[SerializeField]
    //private Animator animator;
    //SpriteRenderer sprite;
    

    void Start()
    {

        body = this.GetComponent<Rigidbody2D>();
        //sprite = this.GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        checkJump();
        move();

    }

    void checkJump()
    {
        if (Physics2D.OverlapPoint(kaki_kanan.position, groundLayer) || Physics2D.OverlapPoint(kaki_kiri.position, groundLayer))
        {
            isGrounded = true;
            anim.SetBool("isGrounded", true);
        }
        else
        {
            isGrounded = false;
            anim.SetBool("isGrounded", false);
        }
    }

    void move()
    {
        body.velocity = new Vector2(speed, body.velocity.y);
    }
}