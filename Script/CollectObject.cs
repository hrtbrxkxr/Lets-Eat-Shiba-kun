using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    //[SerializeField] private AudioClip collectSound;

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Player"){
            //SoundManager.instance.PlaySound(collectSound);
            Collected();
            //gameObject.SetActive(false);
        }
    }

    protected virtual void Collected()
    {
        //overide
    }

}
