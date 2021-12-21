using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    private static BGM BGMinstance;
    void Awake() 
    {
        DontDestroyOnLoad(this);

        if (BGMinstance == null)
        {
            BGMinstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
