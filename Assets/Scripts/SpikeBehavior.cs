using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBehavior : MonoBehaviour
{

    public AudioSource DamageAudioSource;
    private Collision2D player = null;
    void Start()
    {
        DamageAudioSource = GameObject.FindGameObjectWithTag("TakeDamageAudio").GetComponent<AudioSource>(); ;
    }



    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player" )
        {
            DamageAudioSource.Play();
            player = collision;
            collision.gameObject.GetComponent<PlayerHealthSystem>().TakeDamage(80);

            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;

            StartCoroutine(EnableBox(0.2F));
        }




    }


    IEnumerator EnableBox(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        player.gameObject.GetComponent<BoxCollider2D>().enabled = true;
    }
}
