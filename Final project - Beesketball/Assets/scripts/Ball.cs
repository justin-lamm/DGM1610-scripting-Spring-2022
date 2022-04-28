using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;

    

    

    private Enemy enemy;

    public int damage;

    public AudioClip bounce;
    private AudioSource source;

    
    void Start()
    {
        
        

        enemy = GameObject.Find("Qbee").GetComponent<Enemy>();

        source = GetComponent<AudioSource>();
    }

    

    void OnTriggerEnter2D(Collider2D other)
    {   
        source.PlayOneShot(bounce, 1.0f);
        if(other.CompareTag("Qbee"))
        {
            
            enemy.TakeDamage(damage);
        }
    }

    
}