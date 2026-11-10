using UnityEngine;
using UnityEngine.InputSystem;

public class PickUpItems : MonoBehaviour
{

    public InputActionReference pickUp; 

    void Start()
    {
     
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
        Debug.Log("Q pressed"); 
    }


    void Update()
    {

    }

}
