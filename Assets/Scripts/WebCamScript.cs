using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//WebCamScript is a class where the AR rendered on the screen when the user clicked the button on the main menu.
public class WebCamScript : MonoBehaviour
{
    public GameObject WebCameraPlane;
    // Start is called before the first frame update
    void Start()
    {
        //Below code is used to render the camera when we enter into AR mode
          WebCamTexture webCamTexture = new WebCamTexture();
          WebCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCamTexture;
          webCamTexture.Play();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //ExitGame() is used to quit the game 
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}
