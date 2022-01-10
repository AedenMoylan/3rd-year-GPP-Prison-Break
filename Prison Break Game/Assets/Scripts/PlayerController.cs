using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;
    public Animator anim;
    public Rigidbody2D rb;

    Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaX = Input.GetAxisRaw("Horizontal");

        float deltaY = Input.GetAxisRaw("Vertical");

        movement = new Vector2(deltaX, deltaY);

        rb.MovePosition(rb.position + movement * 2 * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isDownPressed", true);
            anim.SetBool("isDownLeftPressed", false);
            anim.SetBool("isDownRightPressed", false);
            anim.SetBool("isLeftPressed", false);
            anim.SetBool("isUpLeftPressed", false);
            anim.SetBool("isUpPressed", false);
            anim.SetBool("isUpRightPressed", false);
            anim.SetBool("isRightPressed", false);
        }

        if (Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isDownPressed", false);
            anim.SetBool("isDownLeftPressed", false);
            anim.SetBool("isDownRightPressed", false);
            anim.SetBool("isLeftPressed", true);
            anim.SetBool("isUpLeftPressed", false);
            anim.SetBool("isUpPressed", false);
            anim.SetBool("isUpRightPressed", false);
            anim.SetBool("isRightPressed", false);
        }




        if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isDownPressed", false);
            anim.SetBool("isDownLeftPressed", false);
            anim.SetBool("isDownRightPressed", false);
            anim.SetBool("isLeftPressed", false);
            anim.SetBool("isUpLeftPressed", false);
            anim.SetBool("isUpPressed", false);
            anim.SetBool("isUpRightPressed", false);
            anim.SetBool("isRightPressed", true);
        }

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isDownPressed", false);
            anim.SetBool("isDownLeftPressed", false);
            anim.SetBool("isDownRightPressed", false);
            anim.SetBool("isLeftPressed", false);
            anim.SetBool("isUpLeftPressed", false);
            anim.SetBool("isUpPressed", true);
            anim.SetBool("isUpRightPressed", false);
            anim.SetBool("isRightPressed", false);
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isDownPressed", false);
            anim.SetBool("isDownLeftPressed", true);
            anim.SetBool("isDownRightPressed", false);
            anim.SetBool("isLeftPressed", false);
            anim.SetBool("isUpLeftPressed", false);
            anim.SetBool("isUpPressed", false);
            anim.SetBool("isUpRightPressed", false);
            anim.SetBool("isRightPressed", false);
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isDownPressed", false);
            anim.SetBool("isDownLeftPressed", false);
            anim.SetBool("isDownRightPressed", true);
            anim.SetBool("isLeftPressed", false);
            anim.SetBool("isUpLeftPressed", false);
            anim.SetBool("isUpPressed", false);
            anim.SetBool("isUpRightPressed", false);
            anim.SetBool("isRightPressed", false);
        }


        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isDownPressed", false);
            anim.SetBool("isDownLeftPressed", false);
            anim.SetBool("isDownRightPressed", false);
            anim.SetBool("isLeftPressed", false);
            anim.SetBool("isUpLeftPressed", false);
            anim.SetBool("isUpPressed", false);
            anim.SetBool("isUpRightPressed", true);
            anim.SetBool("isRightPressed", false);
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            anim.SetBool("isDownPressed", false);
            anim.SetBool("isDownLeftPressed", false);
            anim.SetBool("isDownRightPressed", false);
            anim.SetBool("isLeftPressed", false);
            anim.SetBool("isUpLeftPressed", true);
            anim.SetBool("isUpPressed", false);
            anim.SetBool("isUpRightPressed", false);
            anim.SetBool("isRightPressed", false);
        }


    }
}
