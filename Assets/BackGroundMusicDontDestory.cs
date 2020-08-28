using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusicDontDestory : MonoBehaviour
{

    static BackGroundMusicDontDestory instance = null;


    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


}
