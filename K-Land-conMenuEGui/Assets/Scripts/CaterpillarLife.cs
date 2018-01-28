﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaterpillarLife : MonoBehaviour {

    public int startingHealth = 100;            // The amount of health the enemy starts the game with.
    public int currentHealth;                   // The current health the enemy has.
    public float sinkSpeed = 2.5f;              // The speed at which the enemy sinks through the floor when dead.

    //ParticleSystem hitParticles;                // Reference to the particle system that plays when the enemy is damaged.
    public GameObject caterpillar;
    CapsuleCollider capsuleCollider;            // Reference to the capsule collider.
    bool isDead=false;                                // Whether the enemy is dead.
    bool isSinking;                             // Whether the enemy has started sinking through the floor.
    
    void Awake()
    {
        //// Setting up the references.
        //anim = GetComponent<Animator>();
        //enemyAudio = GetComponent<AudioSource>();
        //hitParticles = GetComponentInChildren<ParticleSystem>();
        capsuleCollider = caterpillar. GetComponent<CapsuleCollider>();

        // Setting the current health when the enemy first spawns.
        currentHealth = startingHealth;
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
        currentHealth -= amount;

        //// Set the position of the particle system to where the hit was sustained.
        //hitParticles.transform.position = hitPoint;

        //// And play the particles.
        //hitParticles.Play();

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

        

       // Destroy(caterpillar, 2f);

        
    }
    
}