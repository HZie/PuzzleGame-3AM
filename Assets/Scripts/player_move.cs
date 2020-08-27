using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour {

    public float movePower = 1f;
    public float jumpPower = 1f;

    public Camera main;
    public Camera under;
    public Camera light;
    public Camera portal;
    public Camera hole;
    public Camera hole2;

    public GameObject fake_upper;
    Vector3 fake_pos;

    Rigidbody rigid;
   Animator animator;
    SpriteRenderer renderer;

    Vector3 movement;
    bool isJumping = false;

	// Use this for initialization
	void Start () {
        Physics.IgnoreLayerCollision(0, 5);

        rigid = gameObject.GetComponent<Rigidbody>();
        animator = gameObject.GetComponentInChildren<Animator>();
        renderer = gameObject.GetComponentInChildren<SpriteRenderer>();

        fake_pos = fake_upper.transform.position;

        main.gameObject.SetActive(true);
        hole.gameObject.SetActive(false);
        light.gameObject.SetActive(false);
        portal.gameObject.SetActive(false);
        under.gameObject.SetActive(false);
        hole2.gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {

        

        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            animator.SetBool("isMoving", false);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            animator.SetBool("isMoving", true);
        }
        else if (Input.GetAxisRaw("Horizontal") > 0) {
            animator.SetBool("isMoving", true);
        }
        if (Input.GetButtonDown("Jump") && !animator.GetBool("isJumping"))
        {
            isJumping = true;
            animator.SetBool("isJumping", true);
            animator.SetTrigger("doJumping");

        }
    }

    void FixedUpdate() {
        Move();
        Jump();
    }

    void Move() {
        Vector3 moveVelocity = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveVelocity = Vector3.left;
            renderer.flipX = true;
            
        }
        else if (Input.GetAxisRaw("Horizontal") > 0) {
            moveVelocity = Vector3.right;
            renderer.flipX = false;

        }

        transform.position += moveVelocity * movePower * Time.deltaTime;
    }

    void Jump() {
        if (!isJumping)
            return;

        rigid.velocity = Vector3.zero;
        Vector3 jumpVelocity = new Vector3(0, jumpPower, 0f);
        rigid.AddForce(jumpVelocity, ForceMode.Impulse);

        isJumping = false;
    }

    void OnTriggerEnter(Collider other) {

        Debug.Log("OnTriggrEnter : " + other.gameObject.layer);

        if (other.gameObject.layer == 8) 
            animator.SetBool("isJumping", false);   //landing

        if (other.gameObject.layer == 9)    //아래
        {
            main.gameObject.SetActive(false);
            light.gameObject.SetActive(false);
            portal.gameObject.SetActive(false);
            under.gameObject.SetActive(true);
            hole.gameObject.SetActive(false);
            hole2.gameObject.SetActive(false);
        }
        else if (other.gameObject.layer == 10)  //빛
        {
            main.gameObject.SetActive(false);
            light.gameObject.SetActive(true);
            portal.gameObject.SetActive(false);
            under.gameObject.SetActive(false);
            hole.gameObject.SetActive(false);
            hole2.gameObject.SetActive(false);
        }
        else if (other.gameObject.layer == 11)  //포탈
        {
            main.gameObject.SetActive(false);
            light.gameObject.SetActive(false);
            portal.gameObject.SetActive(true);
            under.gameObject.SetActive(false);
            hole.gameObject.SetActive(false);
            hole2.gameObject.SetActive(false);
        }
        else if (other.gameObject.layer == 12)  //메인
        {
            main.gameObject.SetActive(true);
            light.gameObject.SetActive(false);
            portal.gameObject.SetActive(false);
            under.gameObject.SetActive(false);
            hole.gameObject.SetActive(false);
            hole2.gameObject.SetActive(false);
        }

        else if (other.gameObject.layer == 13)
        {
            this.transform.position = fake_pos;
        }
        else if (other.gameObject.layer == 14)
        {    //구멍
            main.gameObject.SetActive(false);
            light.gameObject.SetActive(false);
            portal.gameObject.SetActive(false);
            under.gameObject.SetActive(false);
            hole.gameObject.SetActive(true);
            hole2.gameObject.SetActive(false);
        }
        else if (other.gameObject.layer == 15) {    //구멍2
            main.gameObject.SetActive(false);
            light.gameObject.SetActive(false);
            portal.gameObject.SetActive(false);
            under.gameObject.SetActive(false);
            hole2.gameObject.SetActive(true);
            hole.gameObject.SetActive(false);
        }
        
            

    }

    void OnTriggerExit(Collider other) {
        Debug.Log("OnTriggerExit : " + other.gameObject.layer);
    }

}