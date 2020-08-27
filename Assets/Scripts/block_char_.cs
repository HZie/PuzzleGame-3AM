using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_char_ : MonoBehaviour {

    public GameObject say_nothing;
    public GameObject dialogue;
    public int count = 0;

	// Use this for initialization
	void Start () {
        say_nothing.SetActive(false);
        dialogue.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown() {
        if (count < 4)
        {
            if (say_nothing.active == true)
            {
                say_nothing.SetActive(false);
                count++;
            }
            else
                say_nothing.SetActive(true);
        }

        else if (count == 4)
        {
            dialogue.SetActive(true);
        }
    }
}
