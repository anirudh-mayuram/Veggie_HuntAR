using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// MainMenu is the class where we have included the EasyMode(), MediumMode(), HardMode() and ExitGame() methods.
public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Below code is used to shift from current scene to the next scene
    public void EasyMode()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //Below code is used to shift from current scene to the next scene
    public void MediumMode()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
    //Below code is used to shift from current scene to the next scene
    public void HardMode()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    //ExitGame() is used to quit the game 
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }

}
