using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAlongThePlayer : MonoBehaviour
{
    public GameObject player;
    
    void Update()
    {
        this.transform.position = player.transform.TransformPoint(0,4, 1);
    }
}
