using System;
using JetBrains.Annotations;
using UnityEngine;

public class MushroomSequence : MonoBehaviour
{
    bool sequenceComplete; 
    bool[] mushroomSequence = new bool[3];

 

    void Start()
    {
        sequenceComplete = false;

        for (int i=0; i<mushroomSequence.Length; i++)
        {
            mushroomSequence[i] = false;
        }
    }


    void OnControllerColliderHit(ControllerColliderHit collision)
    {
        Debug.Log("collision detected");
        
        if ((collision.gameObject.tag == "Mushroom") && (collision.gameObject.name.Contains("green")))
        {
            mushroomSequence[0] = true; 
            Debug.Log("GREEN");
        } 

        if ((collision.gameObject.tag == "Mushroom") && (collision.gameObject.name.Contains("red")))
        {
            mushroomSequence[1] = true; 
            Debug.Log("RED"); 
        }
                
        if ((collision.gameObject.tag == "Mushroom") && (collision.gameObject.name.Contains("blue")))
        {
            mushroomSequence[2] = true; 
            Debug.Log("BLUE"); 

            CheckIfComplete();
        }

            
    }

      
    

    void CheckIfComplete()
    {
        if (sequenceComplete == false)
        {
            for (int i=0; i<mushroomSequence.Length; i++)
            {
                if (mushroomSequence[i] == false)
                {
                    break; 
                }


                sequenceComplete = true;

                SequenceComplete();
            }
        }
        
    }

    void SequenceComplete()
    {
        Debug.Log("Oh! Looks like that did something...");
        //reveal missing piece 
        
    }
}
