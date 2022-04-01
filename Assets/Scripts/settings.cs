using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class settings : MonoBehaviour
{
    public Button easy;
    public Button medium;
    public Button hard;
    public GameObject img;
    public int difficulty;

    public void Easy()
    {
        difficulty = 1;
        Instantiate(img, new Vector3(268, -26, 0), img.transform.rotation);
    }

    public void Medium()
    {
        difficulty = 2;
        Instantiate(img, new Vector3(268, -147, 0), img.transform.rotation);
    }

    public void Hard()
    {
        difficulty = 3;
        Instantiate(img, new Vector3(268, -272, 0), img.transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        difficulty = 1;
        Instantiate(img, new Vector3(268, -26, 0), img.transform.rotation);
        img.SetActive(true);
        easy.GetComponent<Button>().onClick.AddListener(Easy);
        medium.GetComponent<Button>().onClick.AddListener(Medium);
        hard.GetComponent<Button>().onClick.AddListener(Hard);
    }
}
