using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour {

    Animator animator;
    public int stage_num;
    bool isActivated = false;

    void Start() {
        animator = gameObject.GetComponentInChildren<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("activated", true);
            Invoke("setActivated", 200000.0f);

            switch (stage_num)
            {
                case 0:
                    callSceneStory01();
                    break;
                case 1:
                    callSceneStory02();
                    break;
                case 2:
                    callSceneStory03();
                    break;
                case 3:
                    callSceneStory04();
                    break;
                case 4:
                    callSceneStory05();
                    break;
                case 5:
                    callSceneStory06();
                    break;
                default:
                    break;
            }

        }

    }

    void setActivated() {
        isActivated = true;
    }

    //scene manager
    void callSceneStory01()
    {
        SceneManager.LoadScene("11to12");
    }

    void callSceneStory02()
    {
        SceneManager.LoadScene("12to21");
    }

    void callSceneStory03()
    {
        SceneManager.LoadScene("21to22");
    }

    void callSceneStory04()
    {
        SceneManager.LoadScene("22to31");
    }

    void callSceneStory05()
    {
        SceneManager.LoadScene("31to32");
    }

    void callSceneStory06()
    {
        SceneManager.LoadScene("final");
    }


}
