using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // public int numEwoks = 0;
    public int numPencils = 0;
    public int numWindows = 0;
    public int numTables = 0;
    public int numBottles = 0;


    public int ducksInPond = 0;
    public int bulletsFired = 0;
    public int applesEaten = 0;
    public int dollarsSpent = 0;
    public int milesRun = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        /*
        for(int i = 99; i > numEwoks; i--)
        {
            Debug.Log("There are " + i + " Ewoks on a log!");
        }

         for(int i = 99; i > numPencils; i--)
        {
            Debug.Log("There are " + i + " Pencils in my bag!");
        }
        
        for(int i = 99; i > numWindows; i--)
        {
            Debug.Log("There are " + i + " Windows on the wall!");
        }

        for(int i = 99; i > numTables; i--)
        {
            Debug.Log("There are " + i + " Tables in the room!");
        }

       

        for(int i = 99; i > numBottles; i--)
        {
            Debug.Log("There are " + i + " Bottles on the tables!");
        }











        */

        while(ducksInPond < 99)
        {
            Debug.Log(ducksInPond);
            Debug.Log("All of the dukcs have flown south for the winter");
            ducksInPond ++;
        }

        while(bulletsFired < 25)
        {
            Debug.Log(bulletsFired);
            Debug.Log("The clip is empty");
            bulletsFired ++;
        }

        while(applesEaten < 5)
        {
            Debug.Log(applesEaten);
            Debug.Log("All the apples are eaten");
            applesEaten ++;
        }

        while(dollarsSpent < 100)
        {
            Debug.Log(dollarsSpent);
            Debug.Log("You've gone broke");
            dollarsSpent ++;
        }

        while(milesRun < 99)
        {
            Debug.Log(milesRun);
            Debug.Log("You can't run anymore");
            milesRun ++;
        }
    }

    