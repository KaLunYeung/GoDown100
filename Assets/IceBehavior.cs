using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBehavior : MonoBehaviour
{
    int xdirection;
    void Start() 
    
    {
        xdirection = Random.Range(0, 2);
    }
    void OnCollisionStay2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {

            Transform transform = collision.gameObject.GetComponent<Transform>();
            if (xdirection == 0)
                transform.position = new Vector3(transform.position.x + 0.01f, transform.position.y, transform.position.z);
            else
                transform.position = new Vector3(transform.position.x - 0.01f, transform.position.y, transform.position.z);
        }

    }
}
