using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // load the active scene
        SceneManager.LoadScene(1);
        // SceneManager.LoadScene(2);
    }
    public void GoToOptionsMenu()
    {
        SceneManager.LoadScene("OptionsMenu");
    }
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
