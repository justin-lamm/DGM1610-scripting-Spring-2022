using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Enemy Health")]
    public int curHP;
    public int maxHP;

    

    
    public PlayerController player;

    [Header("Loot Drop")]
    public GameObject lootDrop;

    


    
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    
    

    public void TakeDamage(int damage)
    {
        curHP -= damage;

        if(curHP <= 0)
        {
            Die();
            LootDrop();

            
        }

    }
    
    void Die()
    {
        Destroy(gameObject);

        

    }

    void LootDrop()
    {
        Instantiate(lootDrop, transform.position, Quaternion.identity);
    }
}