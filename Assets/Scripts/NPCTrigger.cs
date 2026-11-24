using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class NPCTrigger : MonoBehaviour
{

    public InputActionReference talk;

    private bool trigger = false;
  
    public GameObject dialogue; 

    private bool dialogueDisplayed = false;

    public GameObject talkPanel; 


    void Start()
    {

        talkPanel.SetActive(false);

        dialogue.SetActive(false);
        

    }


    void OnEnable()
    {
        talk.action.performed += TalkPressed;
    }

    void OnDisable()
    {
        talk.action.performed -= TalkPressed;
    }

    void TalkPressed(InputAction.CallbackContext obj)
    {

        if (trigger)
        {
            if (!dialogueDisplayed)
            {          
                ShowDialogue();
            } 
            else
            {
                HideDialogue();
            }
        }

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ShowPanel(); 
            //only pick up item if player is within trigger zone
            trigger = true;

            Debug.Log("Talk? \n");
        }
        
    }

    void ShowDialogue()
    {
        HidePanel();
        dialogue.SetActive(true);
        dialogueDisplayed = true;
    }

    void HideDialogue()
    {
        //ShowPanel();
        dialogue.SetActive(false);
        dialogueDisplayed = false;
    }


    void OnTriggerExit(Collider other)
    {
        HidePanel(); 
        HideDialogue();

        trigger = false;
    }


    void ShowPanel()
    {
        talkPanel.SetActive(true);
    }

    void HidePanel()
    {
        talkPanel.SetActive(false);
    }

    


}
