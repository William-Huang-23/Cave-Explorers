using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMainMenuMove : MonoBehaviour
{
    private RectTransform rt;
    private Animator anim;
    [SerializeField]
    private float speed = 1f;
    void Start()
    {
        rt = GetComponent<RectTransform>();
    }

    void Update()
    {
        rt.transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
    }

}
