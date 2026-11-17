using UnityEngine;

public class MiniMapSettings : MonoBehaviour
{

    public GameObject player;

    // Update is called once per frame
    void Update()
    {

        //Make camera follow the player's position from above
        transform.position = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z);
    }
}
