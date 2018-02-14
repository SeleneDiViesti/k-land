using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class reginaLife : MonoBehaviour
{

    public int startingHealth = 100;            // The amount of health the enemy starts the game with.
    public int currentHealth;                   // The current health the enemy has.
    public Slider reginaHealthSlider;
    public GameObject guiRegina;
    public GameObject regina;
    CapsuleCollider capsuleCollider;            // Reference to the capsule collider.
    bool isDead = false;                                // Whether the enemy is dead.
    // bool isSinking;                             // Whether the enemy has started sinking through the floor.
    public Image damageImage;                                   // Reference to an image to flash on the screen on being hurt.
    public float flashSpeed = 2f;                               // The speed the damageImage will fade at.
    public Color flashColour = new Color(0f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.
    bool damaged;

    public GameObject damageContainer;
    
    public GameObject colliderTv;
    public GameObject fine3;
    public AudioSource song6;
    public AudioSource song7;

    void Awake()
    {
        // Setting the current health when the enemy first spawns.
        currentHealth = startingHealth;
        song6.GetComponent<AudioSource>();
        song7.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (damaged)
        {
            // ... set the colour of the damageImage to the flash colour.
            damageContainer.SetActive(true);
            damageImage.color = flashColour;
        }
        // Otherwise...
        else
        {
            // ... transition the colour back to clear.
            damageImage.color = Color.Lerp(damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
            damageContainer.SetActive(false); ;
        }
        damaged = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("heartBacchetta"))
        {
            TakeDamage(3);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("heartBacchetta2"))
        {
            TakeDamage(5);
            Destroy(other.gameObject);
        }
    }


    public void TakeDamage(int amount)
    {
        // If the enemy is dead...
        if (isDead)
            // ... no need to take damage so exit the function.
            return;

        //// Play the hurt sound effect.
        //enemyAudio.Play();

        // Reduce the current health by the amount of damage sustained.
        damaged = true;
        currentHealth -= amount;
        reginaHealthSlider.value = currentHealth;

        // If the current health is less than or equal to zero...
        if (currentHealth <= 0)
        {
            // ... the enemy is dead.
            Death();
        }
    }


    void Death()
    {
        // The enemy is dead.
        isDead = true;
        Destroy(regina);
        guiRegina.SetActive(false);
        fine3.SetActive(true);
        colliderTv.SetActive(true);
        song6.Stop();
        song7.Play();
    }

}
