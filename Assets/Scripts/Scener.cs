using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scener : MonoBehaviour {

	void callScene0101 () {
        SceneManager.LoadScene("scene01_1");
	}

	void callScene0102 () {
        SceneManager.LoadScene("scene01_2");
	}

    void callScene0201() {
        SceneManager.LoadScene("scene02_2");
    }

    void callSceneStory00() {
        SceneManager.LoadScene("Intro");
    }

    void callSceneStory01() {
        SceneManager.LoadScene("11to12");
    }

    void callSceneStory02() {
        SceneManager.LoadScene("12to21");
    }

    void callSceneStory03() {
        SceneManager.LoadScene("21to22");
    }

    void callSceneStory04() {
        SceneManager.LoadScene("22to31");
    }

    void callSceneStory05() {
        SceneManager.LoadScene("31to32");
    }

    void callSceneStory06() {
        SceneManager.LoadScene("final");
    }

}
