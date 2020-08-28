using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaBehavior : MonoBehaviour
{
    
    public AudioSource DamageAudioSource;
    private bool triggered = false;


    void Start() 
    {
        DamageAudioSource = GameObject.FindGameObjectWithTag("TakeDamageAudio").GetComponent<AudioSource>(); ;
    }


    void OnCollisionStay2D(Collision2D collision)
    {

        

        
        if (collision.gameObject.tag == "Player" && !triggered)

        {
            
                
                StartCoroutine(TakeDamage(collision));
           

        }




    }

    IEnumerator TakeDamage(Collision2D collision)
    {
        DamageAudioSource.Play();
        
        
        collision.gameObject.GetComponent<PlayerHealthSystem>().TakeDamage(20);
        triggered = true;

        yield return new WaitForSeconds(1f);
        triggered = false;


    }
}
