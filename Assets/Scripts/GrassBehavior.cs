﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrassBehavior : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
            collision.gameObject.GetComponent<PlayerHealthSystem>().Heal(20);
        



    }
}
