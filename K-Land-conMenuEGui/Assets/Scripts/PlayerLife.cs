using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public int vitaMax = 100;                            // The amount of health the player starts the game with.
    public int currentHealth;                                   // The current health the player has.
    public Slider LifeSlider;                                 // Reference to the UI's health bar.

    bool isDead;                                                // Whether the player is dead.
    
    void Awake()
    {
        currentHealth = vitaMax;
        GameObject LS = GameObject.Find("LifeSlider");
        LifeSlider = LS.GetComponent<Slider>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("smokeCaterpillar"))
        {
            Debug.Log("collisionWithCaterpillar");
            TakeDamage(10);
        }
        else if(other.CompareTag("smoke"))
        {
            TakeDamage(5);
        }
    }

    public void TakeDamage(int amount)
    {
        // Reduce the current health by the damage amount.
        currentHealth -= amount;

        // Set the health bar's value to the current health.
        LifeSlider.value = currentHealth;

        // Play the hurt sound effect.
       // playerAudio.Play();

        // If the player has lost all it's health and the death flag hasn't been set yet...
        if (currentHealth <= 0 && !isDead)
        {
            // ... it should die.
            Death();
        }
    }


    void Death()
    {   //TODO
        // Set the death flag so this function won't be called again.
        isDead = true;

         // Tell the animator that the player is dead.
       // anim.SetTrigger("Die");

        // Set the audiosource to play the death clip and play it (this will stop the hurt sound from playing).
        //playerAudio.clip = deathClip;
        //playerAudio.Play();

        // Turn off the movement and shooting scripts.
       // playerMovement.enabled = false;
       // playerShooting.enabled = false;
    }

    void Update()
    {
        if (currentHealth > vitaMax)
        {
            currentHealth = vitaMax;
        }

    }
}


   
	
