using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeObjectDamge : MonoBehaviour
{

    [SerializeField] private float damage;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(damage);
            
        }
        // if (collision.tag == "FallDetector")
        // {
        //     collision.GetComponent<Health>().TakeDamage(damage);
        // }
        
    }
}
