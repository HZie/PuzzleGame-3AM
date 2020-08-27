using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_Btn : MonoBehaviour {

    public GameObject block;
    public static int rotate = 0;
    public float place_y = 2;
    public float place_x = 2;
    Vector3 y_rotate = new Vector3(0,90,0); //y축 회전
    Vector3 x_rotate = new Vector3(90, 0, 0);   //x축 회전
    Vector3 block_location;
    float x,y;

    public float duration = 15f;
    public static bool rotating = false;

    void Start() {
        block_location = block.transform.position;
        x = block_location.x + place_x;
        y = block_location.y + place_y;
        block_location.Set(x, y, 2);
        this.transform.position = block_location;
    }

    void Update() {
        block_location = block.transform.position;
        x = block_location.x + place_x;
        y = block_location.y + place_y;
        block_location.Set(x, y, 2);
        this.transform.position = block_location;
    }

    void OnMouseDown() {
        rotating = true;
        this.transform.parent = null;
        
        
        switch (rotate) {
            case 0:
                startRotation_y();
                // block.transform.Rotate(y_rotate, Space.Self);
                rotate = 1;
                break;
            case 1:
                startRotation_y();
                //block.transform.Rotate(y_rotate, Space.Self);
                rotate = 2;
                break;
            case 2:
                startRotation_y();
                //block.transform.Rotate(y_rotate, Space.Self);
                rotate = 3;
                break;
            case 3:
                startRotation_y();
                //block.transform.Rotate(y_rotate, Space.Self);
                rotate = 4;
                break;
            case 4:
                startRotation_x();
                //block.transform.Rotate(y_rotate, Space.Self);
                rotate = 5;
                break;
            case 5:
                startRotation_x();
                //block.transform.Rotate(y_rotate, Space.Self);
                rotate = 6;
                break;
            case 6:
                startRotation_x();
                //block.transform.Rotate(y_rotate, Space.Self);
                rotate = 7;
                break;
            case 7:
                startRotation_x();
                //block.transform.Rotate(y_rotate, Space.Self);
                rotate = 0;
                break;
            default:
                break;
        }

}

    IEnumerator rotating_Anim_y() {  //y축으로 90도씩 회전하는 애니메이션
        rotating = false;

        Quaternion startRotation = block.transform.rotation;
        Quaternion endRotation = Quaternion.Euler(y_rotate) * startRotation;
        for (float t = 0; t < duration; t += duration*Time.deltaTime)
        {
            block.transform.rotation = Quaternion.Lerp(startRotation, endRotation, t / 10);
            yield return null;
        }
        block.transform.rotation = endRotation;

        rotating = true;

    }

    IEnumerator rotating_Anim_x() {
        rotating = false;

        Quaternion startRotation = block.transform.rotation;
        Quaternion endRotation = Quaternion.Euler(x_rotate) * startRotation;
        for (float t = 0; t < duration; t += duration * Time.deltaTime)
        {
            block.transform.rotation = Quaternion.Lerp(startRotation, endRotation, t / 10);
            yield return null;
        }
        block.transform.rotation = endRotation;

        rotating = true;
    }

    public void startRotation_y() {
        if (rotating) {
            StartCoroutine(rotating_Anim_y());
        }
    }

    public void startRotation_x() {
        if (rotating) {
            StartCoroutine(rotating_Anim_x());
        }
    }

}




