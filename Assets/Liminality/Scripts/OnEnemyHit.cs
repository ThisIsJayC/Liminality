using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnEnemyHit : MonoBehaviour
{
    public float hpAmountEnemy = 5;
  
    [SerializeField]
    GameObject Enemy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.Equals (Enemy))
        {
            //GameObject Enemy = GameObject.Find("Enemy");
            //PlayerControl PlayerControl = Enemy.GetComponent<PlayerControl>();
            hpAmountEnemy -= 1;
        }
    }

}
