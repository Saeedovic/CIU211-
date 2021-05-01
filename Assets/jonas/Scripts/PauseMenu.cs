using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseGame;
    public bool GamePaused;
    public string mainMenu;
    public bool Level1;
    public bool Level2;
    public bool Level3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                ResumeGame();

            }

            else
            {
                GamePaused = true;
                PauseGame.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    public void ResumeGame()
    {
        GamePaused = false;
        PauseGame.SetActive(false);
        Time.timeScale = 1f;
    }

    public void ReloadScene()
    {
        if (Level1)
        {
            SceneManager.LoadScene("Surfer's Bar");
        }

        if (Level2)
        {
            SceneManager.LoadScene("Steampunk");
        }
    }

    public void RetryGame()
    {
        if (Level1)
        {
            SceneManager.LoadScene("Gamer Room");
        }

        if (Level2)
        {
            SceneManager.LoadScene("Surfer's Bar");
        }

        if (Level3)
        {
            SceneManager.LoadScene("Steampunk");
        }
    }

    public void LeaveGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(mainMenu);
    }

}
