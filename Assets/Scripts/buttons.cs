using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class buttons : MonoBehaviour {

    public GameObject PauseUI;
    public GameObject help;

    bool paused = false;

    void Start() {
        PauseUI.SetActive(false);
        help.SetActive(false);
    }

    void Update()
    {
        if (Input.GetButtonDown("Pause")) {
            paused = !paused;
        }
        if (paused) {
            PauseUI.SetActive(true);
            Time.timeScale = 0f;
        }

        if (!paused) {
            PauseUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    public void helpActivate() {
        help.SetActive(true);
    }

    public void Quit() {
        Application.Quit();
    }

    public void callIntro()
    {
        SceneManager.LoadScene("Intro");
    }

    public void callMain()
    {
        SceneManager.LoadScene("startUI");
    }

    public void callScene11()
    {
        SceneManager.LoadScene("scene01_1");
    }

    public void callScene12()
    {
        SceneManager.LoadScene("scene01_2");
    }

    public void callScene21()
    {
        SceneManager.LoadScene("scene02_1");
    }

    public void callScene22()
    {
        SceneManager.LoadScene("scene02_2");
    }

    public void callScene31()
    {
        SceneManager.LoadScene("scene03_1");
    }

    public void callScene32()
    {
        SceneManager.LoadScene("scene03_2");
    }
}
