using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringBehavior : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Transform transform = collision.gameObject.GetComponent<Transform>();
            
            transform.position = new Vector3(transform.position.x , transform.position.y + 1f, transform.position.z);
            //collision.gameObject.GetComponent<PlayerMovement>().jump = true;

        }

    }
    
}
