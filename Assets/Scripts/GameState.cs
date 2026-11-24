using UnityEngine;

public class GameState : MonoBehaviour
{
    public Camera miniMap;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        miniMap.enabled = false;     
    }

    void Update()
    {
        if (Input.GetKeyDown("tab"))
        {
            ToggleMiniMap();
        }
    }
    void ToggleMiniMap()
    {
        
        //Debug.Log("tab pressed"); 
        if (miniMap.enabled == true)
        {
            miniMap.enabled = false;
            //Debug.Log("map hidden");

        } else
        {
            miniMap.enabled = true;
            //Debug.Log("map shown");

        }
    }
}
