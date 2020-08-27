using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour {

    public int count = 1;
    public Transform[] childs;
    public GameObject character;

	// Use this for initialization
	void Start () {
        childs = this.GetComponentsInChildren<Transform>();
        childs[1].gameObject.SetActive(true);
        for (int i = 2; i < childs.Length; i++) {
            childs[i].gameObject.SetActive(false);//false
        }
	}

    void OnMouseDown() {
        count++;
        if (count < childs.Length)
        {
            childs[count].gameObject.SetActive(true);
            childs[count - 1].gameObject.SetActive(false);

        }
        else
        {
            character.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
