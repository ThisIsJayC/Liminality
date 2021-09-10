using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    Vector3 hpScale;
    // Start is called before the first frame update
    void Start()
    {
        hpScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        //hpScale.x = OnEnemyHit.hpAmount;
        transform.localScale = hpScale;
    }
}
