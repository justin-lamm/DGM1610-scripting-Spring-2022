using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("Player Health")]
    public int curHP;

    public int maxHP;

    public Healthbar healthBar; 


    [Header ("Player Movement")]


    public float moveSpeed = 5f;

    private Rigidbody2D rb;

    private Vector2 movement;

    private Vector2 direction;

    [Header ("Player Combat")]
    public int damage;
    public float attackRange;
    public float attackRate;
    private float lastAttackTime;
    
    public LayerMask enemyLayer;

    [Header("Inventory")]

    public int key;
    public int coins;
    public int gems;

    public AudioClip marker;
    public AudioClip marker2;
    public AudioClip marker3;
    private AudioSource source;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        curHP = maxHP;
        healthBar.SetHealth(maxHP);

        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        if(Input.GetKeyDown(KeyCode.E))
        {
            if(Time.time - lastAttackTime >= attackRate)
                Attack();
            
        }
    }
      

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);

        UpdateDirection();
    }

        void UpdateDirection()
    {
        Vector2 vel = new Vector2(movement.x,movement.y); 
        if(vel.magnitude != 0)
        {
            direction = vel;
        }

        rb.velocity = vel * moveSpeed;

    }

    void Attack ()
    {
        lastAttackTime = Time.time;


        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;
        healthBar.SetHealth(curHP);

        source.PlayOneShot(marker, 1.0f);
        
        if (curHP <= 0)
        {
            Die();
        }
    }
    
    void Die()
    {
        Debug.Log("You just got BEEed BOIII!");


        source.PlayOneShot(marker3, 1.0f);
        source.PlayOneShot(marker2, 1.0f);
    }
}