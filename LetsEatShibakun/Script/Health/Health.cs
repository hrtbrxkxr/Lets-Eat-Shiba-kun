using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth{ get; private set;}
    private Animator anim;
    private bool dead;
    [SerializeField] private AudioClip hurtSound;
    [SerializeField] private AudioClip deadSound;

    
    private void Awake() {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(float _damage) {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0, startingHealth);

        if (currentHealth > 0) {
            //player hurt
            anim.SetTrigger("hurt");
            SoundManager.instance.PlaySound(hurtSound);
        }
        else {
            if(!dead) 
            {
            //player dead
            anim.SetTrigger("die");
            
            GetComponent<PlayerMovement>().enabled = false;
            dead = true;
            SoundManager.instance.PlaySound(deadSound);
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);;
            }        
        }
    }

    

}
