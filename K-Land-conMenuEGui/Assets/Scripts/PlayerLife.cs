using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public int vitaMax = 100;                            // The amount of health the player starts the game with.
    public float currentHealth;                                   // The current health the player has.
    public Slider LifeSlider;                                 // Reference to the UI's health bar.

    public GameObject haiPerso;
    public Image damageImage;                                   // Reference to an image to flash on the screen on being hurt.
    public float flashSpeed = 2f;                               // The speed the damageImage will fade at.
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.
    bool isDead;                                                // Whether the player is dead.
    bool damaged;

    void Awake()
    {
        GameObject LS = GameObject.Find("LifeSlider");
        LifeSlider = LS.GetComponent<Slider>();       
        currentHealth = vitaMax;
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

    void Update()
    {
        if (damaged)
        {
            // ... set the colour of the damageImage to the flash colour.
            damageImage.color = flashColour;
        }
        // Otherwise...
        else
        {
            // ... transition the colour back to clear.
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
        if (currentHealth > vitaMax)
        {
            currentHealth = vitaMax;
        }

    }

    public void TakeDamage(int amount)
    {
        damaged = true;

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
        haiPerso.SetActive(true);
        Time.timeScale = 0f;
        // Tell the animator that the player is dead.
        // anim.SetTrigger("Die");

        // Set the audiosource to play the death clip and play it (this will stop the hurt sound from playing).
        //playerAudio.clip = deathClip;
        //playerAudio.Play();

        // Turn off the movement and shooting scripts.
        // playerMovement.enabled = false;
        // playerShooting.enabled = false;
    }
    public void EsciDalGioco()
    {
        Application.Quit();
    }


    public void CaricaMenuPrincipale()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("startMenu");
    }


   
}


   
	
