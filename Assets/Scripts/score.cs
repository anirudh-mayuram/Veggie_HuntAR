using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreText;
    explode ex = new explode();

    void Update()
    {
        string v = (ex.scor).ToString();
        scoreText.text = v;
    }
}