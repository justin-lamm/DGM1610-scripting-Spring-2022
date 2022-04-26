using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;

    

    

    private Enemy enemy;

    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        
        

        enemy = GameObject.Find("Qbee").GetComponent<Enemy>();
    }

    

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Qbee"))
        {
            
            enemy.TakeDamage(damage);
        }
    }

    
}