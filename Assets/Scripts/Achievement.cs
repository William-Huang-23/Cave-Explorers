using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Achievement : MonoBehaviour
{
    public int counterEnemy = 0;
    public int counterDamage = 0;
    void onEnable()
    {
        EnemyScript.OnDie += addEnemyCounter;
        EnemyScript.OnDealDamage += addCounterDamage;
    }

    void onDisable()
    {
        EnemyScript.OnDie -= addEnemyCounter;
        EnemyScript.OnDealDamage -= addCounterDamage;
    }

    void addEnemyCounter()
    {
        counterEnemy++;
    }

    void addCounterDamage(int value)
    {
        counterDamage += value;
    }
}
