using UnityEngine;

public class RocketTrigger : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rocket Part")
        {
            other.gameObject.SetActive(false); 
            Debug.Log("Piece found"); 
            
        }
    }
}
