using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false; // this is for keep track of whether or not the game is currently pause
    // use public static (public) because waned to be accessible from other scripts 
    // and static don't want to reference this pcific pass menu scripts just want to very easily check from other scripts 
    // wether or not the game is currently pause. bool because the value can either be true of false

    public GameObject PauseMenuUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // the keycode want to check is Esc
        {
            if (GameIsPaused) // if the game is currently  pause = ture
            {
                Resume(); // when press Esc the game is already pause so need to resume it
            } else
            {
                Pause(); // when press Esc the game is not pause so need to pause it 
            }
        }
    }

    public void Resume() // use public so can trigger it from button
    {
        PauseMenuUI.SetActive(false); // bring down the pause menu 
        Time.timeScale = 1f; // set time back to normal 
        GameIsPaused = false; // change pause variable to false 
    }

    void Pause()
    {
        PauseMenuUI.SetActive(true); // bring up the pause menu
        Time.timeScale = 0f; // freeze time 
        GameIsPaused = true; // change pause variable to true 
    }

    public void LoadMenu() // public so can trigger it form button 
    {
        SceneManager.LoadScene(0); // to load the scence Menu
        Time.timeScale = 1f; // if not set time to 1 the game will continue pause after click the menu button 
    }

    public void QuitGame()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }

}
