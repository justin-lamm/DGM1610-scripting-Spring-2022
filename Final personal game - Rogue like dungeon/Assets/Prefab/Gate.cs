using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
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
            Debug.Log("Now you can run further away from them!");
            Destroy(gameObject);
        }
        else
        {
            Debug.Log("The gate is locked by the bees.");
        }
    }

  
}