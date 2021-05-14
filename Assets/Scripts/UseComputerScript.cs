using UnityEngine;
using UnityEngine.SceneManagement;

public class UseComputerScript : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;

    void Update()
    {
        var trigger = GetComponent<TextTrigger>();

        if (Input.GetKeyDown(KeyCode.E) && trigger.IsPlayerInTrigger) 
        {
            if (!GameIsPaused)
            {
                Pause();
            }
        }
    }

    public void Close()
    {
        if (GameIsPaused)
        {
            PauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
        }
    }
    
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadRegister()
    {
        Debug.Log("suck");
    }
}
