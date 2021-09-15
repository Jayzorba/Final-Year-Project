using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public GameObject tutorialPanel;
    public GameObject menuPanel;

    public void LoadLevel()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void LoadPractice()
    {
        SceneManager.LoadScene("WordPractice");
    }

    public void LoadTutorial()
    {
        tutorialPanel.SetActive(true);
        menuPanel.SetActive(false);
    }

    public void ExitTutorial()
    {
        tutorialPanel.SetActive(false);
        menuPanel.SetActive(true);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
