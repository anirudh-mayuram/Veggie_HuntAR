using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    explode ex = new explode();
    settings st = new settings();
    SceneChanger sch = new SceneChanger();
    public Text scoreText;
    public Button next;
    public Button home;

    public void Next()
    {
        ex.scor = 0;
        st.difficulty++;
        SceneManager.LoadScene("mainGame");
    }

    public void Home()
    {
        SceneManager.LoadScene("UI");
        sch.Home();
    }
    // Start is called before the first frame update
    void Start()
    {
        string st = ex.ToString();
        scoreText.text = st;
    }

    // Update is called once per frame
    void Update()
    {
        next.GetComponent<Button>().onClick.AddListener(Next);
        home.GetComponent<Button>().onClick.AddListener(Home);
    }
}
