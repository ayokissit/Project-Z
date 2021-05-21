using UnityEngine;
using UnityEngine.SceneManagement;

public class UseComputerScript : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject ComputerUI;
    private TextTrigger Trigger;

    void Start()
    {
        Trigger = GetComponent<TextTrigger>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Close();

        if (Input.GetKeyDown(KeyCode.E) && Trigger.IsPlayerInTrigger) 
        {
            if (!GameIsPaused)
            {
                Pause();
            }
        }
    }

    public void Close()
    {
        ComputerUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    
    void Pause()
    {
        ComputerUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadRegister()
    {
        Debug.Log("urcute");
    }
}
