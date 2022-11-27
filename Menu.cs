using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public void StartGame() // when ever need to trigger some code using a button , need to make sure the function 
     //create is marked as public. and can't call it start because that a function already creat by unity
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //want to load the next scene so need to get the current
        // and + 1 in the buildindex by using  (SceneManager.GetActiveScene().buildIndex + 1)
    }

    public void normallevel()
    {
        SceneManager.LoadScene(5);
    }
    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }
}
