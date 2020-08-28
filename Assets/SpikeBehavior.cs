using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBehavior : MonoBehaviour
{


    private Collision2D player = null;
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player" )
        {
            player = collision;
            collision.gameObject.GetComponent<PlayerHealthSystem>().TakeDamage(80);

            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;

            StartCoroutine(EnableBox(0.1F));
        }




    }


    IEnumerator EnableBox(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        player.gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
}
