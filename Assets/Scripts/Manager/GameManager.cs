using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Singleton implementation:
    public static GameManager instance { get; private set; }
    public enum GameState
    {
        Start,
        Playing
    }

    public GameState currentState = GameState.Start;

    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ChangeGameState(currentState);
    }

    public void ChangeGameState(GameState newState)
    {
        if (currentState == newState) return;
        currentState = newState;

        switch (currentState)
        {
            case GameState.Start:
                SceneManager.LoadScene("Main Menu");
                break;
            case GameState.Playing:
                SceneManager.LoadScene("Level 1");
                break;
        }
    }
}
