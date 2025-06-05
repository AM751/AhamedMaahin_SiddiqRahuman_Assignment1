using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public void Awake()
    {
        Time.timeScale = 0f;
    }
    public void gameStart()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
