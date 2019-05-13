using UnityEngine;

//Inicjalizuje poczatkowe ustawienia gry
//Kontroluje poczatek i koniec gry
//Kontroluje czas gry
public class GameManager : MonoBehaviour
{
    bool gameRunning;
    bool gamePaused;

    public FloatVariable Timer;
    public IntVariable Score;
    public GameParameters InitialParameters;
    public GameParameters Parameters;
    public GameEvent GameStartEvent;
    public GameEvent GameEndEvent;

    private void Awake()
    {
        Parameters.MinExplodeTime = InitialParameters.MinExplodeTime;
        Parameters.MaxExplodeTime = InitialParameters.MaxExplodeTime;
        Parameters.SpawnTime = InitialParameters.SpawnTime;
        Score.Value = 0;
        Timer.Value = 0;
    }

    void Update()
    {
        if (gameRunning)
        {
            Timer.Value += Time.deltaTime;
        }
    }

    public void StartGame()
    {
        if (!gameRunning)
        {
            gameRunning = true;
            GameStartEvent.Raise();
        }
    }

    public void EndGame()
    {
        if (gameRunning)
        {
            gameRunning = false;
            GameEndEvent.Raise();
        }
    }

    public void ToggleGamePause()
    {
        if (gamePaused)
            ResumeGame();
        else
            PauseGame();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        gamePaused = true;
    }
}
