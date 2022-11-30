using UnityEngine.SceneManagement; // for changing the scence
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel() // public void that call LoadNextLevel
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // the scence want to load is going to depend on what level player are currently on 
        // so just load the next level so instead of using the scene name 
        // use the build index (build index is the number in build setting at the right which the 
        // first scence is 0 because first player is on level 1 and leve 1 build index is 1 
        // so when + 1 the scence will change to level2 which is build index 2
        // SceneManager.GetActiveScene this is the get the scence that player is currently on
        // .buildIndex is to get the buildIndex player are currently on
        // the hole code is to ask unity to load scene with the build index that is = to the player currently loaded scene +1
    }
}
