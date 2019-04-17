using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 6f;
    public float rotateSpeed = 6f;

    Animator anim;
    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        float qe = Input.GetAxisRaw("Horizontal2");

        Move(h, v, qe);
        Animating(h, v);

    }

    void Animating(float h, float v)
    {
        //Did we press the horizontal axis or did we press the vertical axis?
        bool walking = h != 0f || v != 0f;
        //Debug.Log(" " + walking);
        anim.SetBool("IsWalking", walking);
    }

    private void Move(float h, float v, float qe)
    {
        //float horizontal = Input.GetAxis("Horizontal");//left and right
        //float vertical = Input.GetAxis("Vertical");//forward and back
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * v);
        //transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * h);
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime * -h);
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * qe);

    }
}
