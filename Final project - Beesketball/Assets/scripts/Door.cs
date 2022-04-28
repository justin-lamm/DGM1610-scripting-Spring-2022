using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    
    private PlayerController playerController;

    
    
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && playerController.key == 1) 
        {
            Debug.Log("You Open the Door!");
            Destroy(gameObject);

            
        }
        else
        {
            Debug.Log("Door is locked. You need a key");

           
        }
    }

  
}