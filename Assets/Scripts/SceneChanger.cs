using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public Button newGame;
    public Button settings;
    public Button about;
    public Button exit;
    public GameObject home;
    public GameObject ab;
    public GameObject set;
    public GameObject backButton;

    public void Home()
    {
        home.SetActive(true);
        ab.SetActive(false);
        set.SetActive(false);
        backButton.SetActive(false);
    }
    public void startGame()
    {
        SceneManager.LoadScene("mainGame");
    }

    public void Settings()
    {
        home.SetActive(false);
        ab.SetActive(false);
        set.SetActive(true);
        backButton.SetActive(true);
    }

    public void About()
    {
        home.SetActive(false);
        ab.SetActive(true);
        set.SetActive(false);
        backButton.SetActive(true);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void Back()
    {
        home.SetActive(true);
        ab.SetActive(false);
        set.SetActive(false);
        backButton.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        home.SetActive(true);
        ab.SetActive(false);
        set.SetActive(false);
        backButton.SetActive(false);
        newGame.GetComponent<Button>().onClick.AddListener(startGame);
        settings.GetComponent<Button>().onClick.AddListener(Settings);
        about.GetComponent<Button>().onClick.AddListener(About);
        exit.GetComponent<Button>().onClick.AddListener(exitGame);
        backButton.GetComponent<Button>().onClick.AddListener(Back);
    }
}
