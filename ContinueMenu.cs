using UnityEngine.SceneManagement;
using UnityEngine;

public class ContinueMenu : MonoBehaviour
{
    public void Continue() // when ever need to trigger some code using a button , need to make sure the function 
                            //create is marked as public. and can't call it start because that a function already creat by unity
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //want to load the next scene so need to get the current
        // and + 1 in the buildindex by using  (SceneManager.GetActiveScene().buildIndex + 1)
    }
    public void Quit()  // when the button is clicked everything inside will happen 
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
