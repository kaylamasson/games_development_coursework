using System;
using JetBrains.Annotations;
using UnityEngine;

public class MushroomSequence : MonoBehaviour
{
    private bool sequenceComplete; 

    public GameObject rocketPart;

    // bool[] mushroomSequence = new bool[5];

    //string[] answerSequence = new string[5]{"green", "red", "green", "blue", "red"};
 
    private int mushroomCounter = 1; 

    void Start()
    {
        sequenceComplete = false;

        rocketPart.SetActive(false); 

        // for (int i=0; i<mushroomSequence.Length; i++)
        // {
        //     mushroomSequence[i] = false;
        // }
    }

    void Update()
    {
        Debug.Log(mushroomCounter); 

        if (mushroomCounter > 5)
        {
            SequenceComplete(); 
        }
    }


    void OnControllerColliderHit(ControllerColliderHit collision)
    {
        
        // if ((collision.gameObject.tag == "Mushroom") && (collision.gameObject.name.Contains("green")))
        // {
        //     mushroomSequence[0] = true; 
        //     Debug.Log("GREEN");
        // } 

        // if ((collision.gameObject.tag == "Mushroom") && (collision.gameObject.name.Contains("red")))
        // {
        //     mushroomSequence[1] = true; 
        //     Debug.Log("RED"); 
        // }
                
        // if ((collision.gameObject.tag == "Mushroom") && (collision.gameObject.name.Contains("blue")))
        // {
        //     mushroomSequence[2] = true; 
        //     Debug.Log("BLUE"); 

        //     CheckIfComplete();
        // }

        if (collision.gameObject.tag == "Mushroom")
        {
            if (collision.gameObject.name.Contains(mushroomCounter.ToString()))
            {
                // mushroomSequence[mushroomCounter] = true; 

                //Debug.Log("correct " + mushroomCounter); 

                mushroomCounter ++; 

            }
            // else
            // {
            //     mushroomCounter = 1; 

            //     Debug.Log("Not quite..."); 
            // }
        }    
            
    }

    
      
    

    // void CheckIfComplete()
    // {
    //     if (sequenceComplete == false)
    //     {
    //         for (int i=0; i<mushroomSequence.Length; i++)
    //         {
    //             if (mushroomSequence[i] == false)
    //             {
    //                 break; 
    //             }


    //             sequenceComplete = true;

    //             SequenceComplete();
    //         }
    //     }
        
    // }

    void SequenceComplete()
    {
        Debug.Log("Oh! Looks like that did something...");

        rocketPart.SetActive(true); 



        //reveal missing piece 
        
    }
}
