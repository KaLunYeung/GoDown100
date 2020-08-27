using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaBehavior : MonoBehaviour
{
    float TakeDamageRate = 1f;
    float lastTakenDamage = 0.0f;


    void OnCollisionStay2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player" && (Time.timeSinceLevelLoad > TakeDamageRate + lastTakenDamage) ) {

            collision.gameObject.GetComponent<PlayerHealthSystem>().TakeDamage(20);

            lastTakenDamage = Time.timeSinceLevelLoad;
            
        }
        



    }
}
