using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

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
    public Color flashColour = new Color(0f, 0f, 0f, 0.1f);     // The colour the damageImage is set to, to flash.
    bool damaged;

    private GameObject livelloCompletato;
    public GameObject rabbit;
    public GameObject music;
    public GameObject damageContainer;

    public GameObject Tv;
    public GameObject unitychain;
    public GameObject colliderTv1;
    private Vector3 mposition;
    private Quaternion mrotation;
    private Animator tv1;

    public AudioSource song2;
    public AudioSource song3;
    static int idleState = Animator.StringToHash("Base Layer.Default");
    static int locoState = Animator.StringToHash("Base Layer.levelFinished");
    
    public GameObject GuiEnemy;
    private Animator percorsoRabbit;
    private Animator percorsoMusic;

    public AudioSource CaterpillarHurts;
    public AudioSource CaterpillarDeath;

    void Awake()
    {
        
        capsuleCollider = caterpillar. GetComponent<CapsuleCollider>();
        tv1=Tv.GetComponent<Animator>();
        // Setting the current health when the enemy first spawns.
        currentHealth = startingHealth;

        livelloCompletato = GameObject.Find("livelloCompletato");
        animationLab1 = livelloCompletato.GetComponent<Animator>();
        percorsoRabbit = rabbit.GetComponent<Animator>();
        percorsoMusic = music.GetComponent<Animator>();
        song3.GetComponent<AudioSource>();
        song2.GetComponent<AudioSource>();
        
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
        if (other.CompareTag("proiettile"))
        {
            TakeDamage(15);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("proiettile2"))
        {
            TakeDamage(5);
            //TakeDamage(100);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("proiettile3"))
        {
            TakeDamage(10);
            //TakeDamage(100);
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
        CaterpillarHurts.Play();

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
            percorsoRabbit.Play("percorso_2");
            percorsoMusic.Play("percorso_2");
        }
    }


    void Death()
    {
        // The enemy is dead.
        isDead = true;             
        Destroy(caterpillar);
        singleParts.SetActive(true);
        GuiEnemy.SetActive(false);
        
        song2.Stop();
        song3.Play();
        mposition = colliderTv1.transform.position;
        mrotation = colliderTv1.transform.rotation;
        StartCoroutine(DelayedCoroutine());
        
        unitychain.transform.SetPositionAndRotation(mposition, mrotation);
        tv1.Play("tv_animation");
        CaterpillarDeath.Play();

}

    private IEnumerator DelayedCoroutine()
    {
        yield return new WaitForSecondsRealtime(5f); 
    }





}
