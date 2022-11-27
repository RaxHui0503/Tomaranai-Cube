
using UnityEngine;

public class PlayerCollsion : MonoBehaviour
{

    public PlayerMovement movement; // reference to PlayerMovement script


    void OnCollisionEnter (Collision collisionInfo)  // this will run when we collision (hit) with a object
                                                     // and get the information about the collision (hit) and call it "collisionInfo"
    {
        if (collisionInfo.collider.tag == "Obstacle")  // to check if the object we collided (hit) with it has a tag called "Obstacle"
        {
            movement.enabled = false; // disable player movement
            FindObjectOfType<GameManger>().gameover(); // this is for search of the gamemanger script
            
        }
    }
}
