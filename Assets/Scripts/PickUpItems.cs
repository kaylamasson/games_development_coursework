using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PickUpItems : MonoBehaviour
{

    public InputActionReference pickUp;

    private bool trigger = false;

    private Transform item; 

    public GameObject pickUpTextPanel;

    public GrabObject grabObject; 

    public Transform objectGrabPointTransform; 

    private bool holdingItem;

    



    void Start()
    {
        pickUpTextPanel.SetActive(false); 

        holdingItem = false; 

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
        //run when Q is pressed - key for picking up items

        
        

        if (!holdingItem)
        {

            if (trigger)
            {
                grabObject = item.GetComponent<GrabObject>(); 
                grabObject.Grab(objectGrabPointTransform);
                holdingItem = true;
            }
 
        } else
        {
            grabObject.Drop();
            holdingItem = false;  
        }
        

            //hide item if player is within range
            //HideItem(); 

        
    
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            ShowPanel(); 

            //get the parent object of the trigger zone - the game object
            item = other.gameObject.transform.parent;

            //only pick up item if player is within trigger zone
            trigger = true;
            Debug.Log("Pick up? \n");
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        HidePanel();

        trigger = false;
    }

    void HideItem()
    {
        //item.GetComponent<MeshRenderer>().enabled = false;

        Debug.Log("You picked up an item.");

        item.gameObject.SetActive(false);

        trigger = false;

        HidePanel(); 

    }

    void ShowPanel()
    {
        pickUpTextPanel.SetActive(true);
    }

    void HidePanel()
    {
        pickUpTextPanel.SetActive(false);
    }

}
