using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TikusMove : MonoBehaviour
{
    Rigidbody2D body;

    //Movement
    [SerializeField]
    private float speed;
    
    //GameObject
    private SpriteRenderer spriteTikus;

    public LayerMask groundLayer;
    public LayerMask enemyLayer;
    public Transform hidung;

    void Start()
    {
        spriteTikus = gameObject.GetComponent<SpriteRenderer>();

        body = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Physics2D.OverlapPoint(hidung.position, groundLayer) || Physics2D.OverlapPoint(hidung.position, enemyLayer))
        {
            flip();
        }
    }

    void Update()
    {
        move();
    }

    void move()
    {
        body.velocity = new Vector2(speed, body.velocity.y);
    }

    void flip()
    {
        Vector3 scale = spriteTikus.transform.localScale;
        scale.x = scale.x * -1;
        spriteTikus.transform.localScale = scale;
        speed *= -1;
    }

    void die()
    {
        Destroy(this.gameObject);
    }
}
