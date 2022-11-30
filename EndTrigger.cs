
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManger GM; // whenever we hit our end levle trigger need to tell GameManger to display some UI in the screen 
                          // so to do that need to reference to a GameManger
                          // dont use FindObjectOfType but is easier to reference it directly 
                          // call the new public Gamemanger GM so wont be confuse
    void OnTriggerEnter () // to detect if somethings has hit the end level trigger just like (detect the collision by using void on collision)
                            // on collisionenter will not work if collider is marked as trigger so need to write 
                            // OnTtiggerEnter instead
    {
        GM.CompleteLevel();
        
    }
}
