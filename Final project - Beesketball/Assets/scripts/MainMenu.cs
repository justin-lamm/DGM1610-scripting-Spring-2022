using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;


public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;

    public AudioClip marker7;
    private AudioSource source;

    

    

    public void StartGame()
    {
        SceneManager. LoadScene(sceneToLoad);
        
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game");

        source.PlayOneShot(marker7, 1.0f);
        
    }
}
