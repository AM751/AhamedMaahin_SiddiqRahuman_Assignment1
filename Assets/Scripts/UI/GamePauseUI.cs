using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class GamePauseUI : MonoBehaviour
{
    public GameObject gamePauseUI;
    public bool isPaused = false;

     void Update()
     {
        if (Input.GetKeyDown (KeyCode.Escape))
        {
            if (!isPaused)
            {
                GamePaused();
            }

            else
            {
                GameResumed();
            }
            
        }
     }

    public void GameResumed()
    {
        gamePauseUI.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void GamePaused()
    {
        gamePauseUI.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }
}
