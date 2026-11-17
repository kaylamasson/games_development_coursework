using UnityEngine;

public class GrabObject : MonoBehaviour
{
    private Rigidbody objectRb;
    private Transform objectGrabPointTransform; 

    public GameObject player; 

    void Awake()
    {
        objectRb = GetComponent<Rigidbody>(); 
    }

    public void Grab(Transform objectGrabPointTransform)
    {
        this.objectGrabPointTransform = objectGrabPointTransform; 
        objectRb.useGravity = false;
        this.GetComponent<BoxCollider>().enabled = false;

    }

    public void Drop()
    {
        this.objectGrabPointTransform = null; 
        objectRb.useGravity = true;
        this.GetComponent<BoxCollider>().enabled = true;


    }

    void FixedUpdate()
    {
        if (objectGrabPointTransform != null)
        {
            float lerpSpeed = 10f; 
            Vector3 newPosition = Vector3.Lerp(transform.position,objectGrabPointTransform.position, Time.deltaTime * lerpSpeed); 

            objectRb.MovePosition(newPosition);   
        }
    }
}
