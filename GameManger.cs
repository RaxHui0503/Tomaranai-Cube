using UnityEngine.SceneManagement; // use this to change to different scene or reload the scene are already on
using UnityEngine;

public class GameManger : MonoBehaviour
{
    private static GameManger instance;
   


    bool GameHasEnded = false; // bool is use to store a value that either be true of false

    public GameObject CompletelevelUI; // a reference to the UI so can enable it when player complete the level
    public void CompleteLevel() // a function to call when player actually succeed
    {
        CompletelevelUI.SetActive(true); // true because want to enable it
    }

    public float restartDelay = 1f; 
   public void gameover () // use public void so that other scripts can find this and a function to call when player gameover
    {
        if (GameHasEnded == false) // the first time is going to be false so this is going to be true 
        {
            GameHasEnded = true; // this is true so when next time is called gameended is now going to be true 
                                 // then the if statement is going to return to false and it not going to be called 
                                 // so game only will end once
            Debug.Log("Game over");
            Invoke("Restart",restartDelay); // don't just use Restart because want delay
        }
        
    }
    void Restart() // so that the restart will jump to here
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //((SceneManager.GetActiveScene().name)) this piece of code
                                                                    // retuens the name of our current scene
    }     // and this code ( SceneManager.LoadScene) loads the scene with a given name
}
