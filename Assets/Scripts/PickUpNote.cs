using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PickUpNote : MonoBehaviour
{

    public InputActionReference pickUp;

    private bool trigger = false;
  
    public GameObject note; 

    private bool noteDisplayed = false;

    public GameObject lookPanel; 


    void Start()
    {
        note.SetActive(false);
    }


    void OnEnable()
    {
        pickUp.action.performed += PickUpPressed;
    }

    void OnDisable()
    {
        pickUp.action.performed -= PickUpPressed;
    }

    void PickUpPressed(InputAction.CallbackContext obj)
    {

        if (trigger)
        {
            if (!noteDisplayed)
            {          
                ShowNote();
            } else
            {
                HideNote();
            }
        }

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Note")
        {
            ShowPanel(); 
            //only pick up item if player is within trigger zone
            trigger = true;

            Debug.Log("Look? \n");
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        HidePanel(); 
        trigger = false;
    }

    void ShowNote()
    {
        HidePanel();
        note.SetActive(true); 
        noteDisplayed = true;
        
    }

    void HideNote()
    {
        note.SetActive(false);
        noteDisplayed = false;
    }

    void ShowPanel()
    {
        lookPanel.SetActive(true);
    }

    void HidePanel()
    {
        lookPanel.SetActive(false);
    }

    


}
