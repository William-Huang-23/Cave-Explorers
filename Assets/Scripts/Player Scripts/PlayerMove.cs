using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D body;

    private GameManager gm;

    //Movement
    [SerializeField]
    private float speed;
    bool isRunning = false;

    [SerializeField]
    private float jumpVelocity;
    bool isGrounded = false;

    public Transform kaki_kiri;
    public Transform kaki_kanan;
    public LayerMask groundLayer;

    public LayerMask enemyLayer;

    //Audio
    [SerializeField]
    private AudioSource collectgem;
    [SerializeField]
    private AudioSource collectcherry;

    //Animation
    [SerializeField]
    private Animator animator;
    SpriteRenderer sprite;

    bool wasGrounded;
       
    void Start()
    {
        gm = GameManager.instance;
        body = this.GetComponent<Rigidbody2D>();
        sprite = this.GetComponent<SpriteRenderer>();
        gm.reset();
    }
    

    void Update()
    {
        checkJump();

        //Movement
        move();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            animator.SetBool("isJumping", true);
            jump();
        }
        
    }

    void checkJump()
    {
        if (Physics2D.OverlapPoint(kaki_kanan.position, groundLayer) || Physics2D.OverlapPoint(kaki_kiri.position, groundLayer))
        {
            isGrounded = true;
            animator.SetBool("isJumping", false);
        }
        else
        {
            isGrounded = false;          
        }
    }
    void move()
    {
        Vector3 scale = sprite.transform.localScale;

        if (Input.GetKey(KeyCode.D))
        {
            speed = 1f;
            scale.x = 1;
            sprite.transform.localScale = scale;
        }

        if (Input.GetKey(KeyCode.A))
        {
            speed = -1f;
            scale.x = -1;
            sprite.transform.localScale = scale;
        }

        if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            speed = 0f;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A))
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        body.velocity = new Vector2(speed, body.velocity.y);
    }

    void jump()
    {
        body.velocity += jumpVelocity * Vector2.up;
        isGrounded = false;   
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Gem")
        {
            collectgem.Play();
        }

        if(collision.gameObject.tag == "Cherry")
        {
            collectcherry.Play();
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            gm.addScore(100);
            Destroy(col.gameObject);
            jump();
        }

        if (col.gameObject.tag == "Moving Platform")
        {
            transform.position = new Vector3(col.transform.position.x, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Moving Platform")
        {
            transform.position = new Vector3(col.transform.position.x, transform.position.y, transform.position.z);
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Moving Platform")
        {
            transform.position = transform.position;
        }
    }

    public void savePlayer()
    {
        SaveLoad.SavePlayer(this);
    }

    public void loadPlayer()
    {
        PlayerPosition pos = SaveLoad.LoadPlayer();

        Vector3 position;
        position.x = pos.position[0];
        position.y = pos.position[1];
        position.z = pos.position[2];
        transform.position = position;
    }
}
