using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block_move : MonoBehaviour {
    public GameObject btn;
    Rigidbody rigidbody;
    Animator animator;

    void Start() {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        rigidbody.isKinematic = false;
    }

    void FixedUpdate() {
        Vector3 pos = this.transform.position;
        this.transform.position.Set(pos.x, pos.y, 0.5f);

        rigidbody.AddForce(Physics.gravity, ForceMode.Acceleration);


    }

    void OnMouseDown()
    {
        if (btn.activeSelf == true)
            btn.SetActive(false);
        else if (btn.activeSelf == false)
            btn.SetActive(true);
    }

    void OnMouseUp() {

        rigidbody.isKinematic = false;
    }

   /* void OnMouseDrag()
    {
        rigidbody.isKinematic = true;
        //마우스 좌표를 받아온다.
        Vector3 mousePosition
                = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 8f);
            //마우스 좌표를 스크린 투 월드로 바꾸고 이 객체의 위치로 설정해 준다.
            this.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
    }*/
}
