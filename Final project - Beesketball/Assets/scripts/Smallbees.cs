using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smallbees : MonoBehaviour
{
    

    [Header("Smallbees Attack")]

    public int damage;
    public float attackRange; 
    public float attackRate;
    private float lastAttackTime;
    public PlayerController player;

    


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastAttackTime >= attackRate && Vector2.Distance(transform.position, player.transform.position) < attackRange)
        {
            Attack();
        }
    }

 
    void Attack()
    {
        lastAttackTime = Time.time;
        player.TakeDamage(damage);
    }
  
}