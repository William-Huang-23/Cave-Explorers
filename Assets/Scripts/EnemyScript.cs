using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    private int hp = 30;
    public delegate void Dying();
    public static event Dying OnDie;

    public delegate void DealDamage(int value);
    public static event DealDamage OnDealDamage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            damage(Random.Range(1, 6));
        }
    }

    void damage(int value)
    {
        hp -= value;
        OnDealDamage(value);
        if(hp <= 0)
        {
            hp = 0;
            if(OnDie != null)
            {
                OnDie();
            }
        }
    }
}
