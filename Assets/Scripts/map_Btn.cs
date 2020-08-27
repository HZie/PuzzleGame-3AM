using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class map_Btn : MonoBehaviour {

    public GameObject map;

    void Start() {
        map.SetActive(false);
    }

    // Use this for initialization
    void OnMouseDown() {
        if (map.active)
            map.SetActive(false);
        else
            map.SetActive(true);
    }
}
