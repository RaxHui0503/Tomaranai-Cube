using UnityEngine.SceneManagement;
using UnityEngine;

public class Credit : MonoBehaviour // when ever need to trigger some code using a button , need to make sure the function 
    // create is marked as public
{
    public void Quit ()  // when the button is clicked everything inside will happen 
    {
        Debug.Log("Quit"); // not going to see game quit because unity won't quit it when inside unity only when export it will close
        // down the window so use a debug.log so when text can see it say Quit when press the button 
        Application.Quit(); // quiting the application
    }
    public void Return()
    {
        SceneManager.LoadScene(0);
    }
}
