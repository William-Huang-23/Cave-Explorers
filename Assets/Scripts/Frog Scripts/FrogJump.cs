using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FrogJump : MonoBehaviour
{
    private GameManager gm;

    [SerializeField]
    private Animator anim;
    [SerializeField]
    private Rigidbody2D bd;
    [SerializeField]
    private float speed;
    [SerializeField]
    private bool facingRight;
    private int timer = 0;

    void Start()
    {
        gm = GameManager.instance;
        anim.SetBool("isJumping", false);
        facingRight = false;
    }

 
    void Update()
    {
        //if(turning)
        //{
        //    transform.localScale = new Vector2(-1, 1);
        //}
        //else
        //{
        //    transform.localScale = new Vector2(1, 1);
        //}

        //if (speed == 0f)
        //{
        //    timer++;
        //}
        //else if(speed != 0f)
        //{
        //    anim.SetBool("isJumping", true);
        //}

        //if(timer >= 75)
        //{
        //    speed = 0.5f;
        //    jumper();
        //    timer = 0;
        //}
        //else if(timer < 75)
        //{
        //    Invoke("OnTriggerEnter2D", 1f);
        //}

        timer++;
        if(timer >= 75)
        {
            anim.SetBool("isJumping", true);
            jumper();

            //test
            if (!facingRight)
            {
                facingRight = true;
                transform.localScale = new Vector2(-1, 1);
                speed *= -1;
            }
            else
            {
                facingRight = false;
                transform.localScale = new Vector2(1, 1);
                speed *= -1;
            }
            //test

            timer = 0;
        }
        if(timer == 15)
        {
            anim.SetBool("isJumping", false);
        }
    }

    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    if(col.gameObject.CompareTag("Turn"))
    //    {
    //        if(turning)
    //        {
    //            turning = false;
    //            speed *= -1;
    //        }
    //        else
    //        {
    //            turning = true;
    //            speed *= -1;
    //        }
            
    //    }
    //}

    void jumper()
    {
        bd.velocity += 3.5f * Vector2.up;
        bd.velocity = new Vector2(speed, bd.velocity.y);
    }

    
}
