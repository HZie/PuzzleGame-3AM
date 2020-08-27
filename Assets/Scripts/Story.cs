using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story : MonoBehaviour {

    public Animator story;
    public float speed = 0.5f;
    public int stage;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        story.speed = speed;
        if (story.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f) {
            switch (stage) {
                case 0:
                    callMain();
                    break;
                case 11:
                    callScene11();
                    break;
                case 12:
                    callScene12();
                    break;
                case 21:
                    callScene21();
                    break;
                case 22:
                    callScene22();
                    break;
                case 31:
                    callScene31();
                    break;
                case 32:
                    callScene32();
                    break;
                default:
                    break;
            }
        }


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
