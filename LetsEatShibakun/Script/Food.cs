using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : CollectObject
{
   [SerializeField] int foodValue = 1;
   [SerializeField] private AudioClip collectSound;

   protected override void Collected()
   {
       //Save value
       GameManager.MyInstance.AddFood(foodValue);
       SoundManager.instance.PlaySound(collectSound);
       gameObject.SetActive(false);
       
    
   }
}
