﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaterpillarLife : MonoBehaviour {
    
    private Animator animationLab1;              //per labitintoPrimoLivello

    public int startingHealth = 100;            // The amount of health the enemy starts the game with.
    public int currentHealth;                   // The current health the enemy has.
    public Slider caterpillarHealthSlider;
        
    public GameObject singleParts;
    public Transform explosionPosition;
    public GameObject caterpillar;
    CapsuleCollider capsuleCollider;            // Reference to the capsule collider.
    bool isDead=false;                                // Whether the enemy is dead.
    // bool isSinking;                             // Whether the enemy has started sinking through the floor.
    public Image damageImage;                                   // Reference to an image to flash on the screen on being hurt.
    public float flashSpeed = 2f;                               // The speed the damageImage will fade at.
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.
    bool damaged;

    private GameObject livelloCompletato;
    public GameObject rabbit;

    static int idleState = Animator.StringToHash("Base Layer.Default");
    static int locoState = Animator.StringToHash("Base Layer.levelFinished");
    private Vector3 posRabbit;
    private Quaternion orientamentoRabbit;
    public GameObject GuiEnemy;

    void Awake()
    {
        //// Setting up the references.
        //anim = GetComponent<Animator>();
        //enemyAudio = GetComponent<AudioSource>();
        //hitParticles = GetComponentInChildren<ParticleSystem>();
        capsuleCollider = caterpillar. GetComponent<CapsuleCollider>();

        // Setting the current health when the enemy first spawns.
        currentHealth = startingHealth;

        livelloCompletato = GameObject.Find("livelloCompletato");
        animationLab1 = livelloCompletato.GetComponent<Animator>();
        //posRabbit = livelloCompletato.transform.position;
        //orientamentoRabbit=livelloCompletato.transform.rotation;
        //rabbit.transform.SetPositionAndRotation(posRabbit, orientamentoRabbit);
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
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("proiettile"))
        {
            TakeDamage(10);
        }
        if (other.CompareTag("proiettile2"))
        {
            TakeDamage(3);
        }
        if (other.CompareTag("proiettile3"))
        {
            TakeDamage(5);
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
        caterpillarHealthSlider.value = currentHealth;
       
        // If the current health is less than or equal to zero...
        if (currentHealth <= 0)
        {
            // ... the enemy is dead.
            Death();
            animationLab1.SetBool("isFinished", true);
        }
    }


    void Death()
    {
        // The enemy is dead.
        isDead = true;             
        Destroy(caterpillar);
        singleParts.SetActive(true);
        GuiEnemy.SetActive(false);
        //rabbit.SetActive(true);
    }
    
}
