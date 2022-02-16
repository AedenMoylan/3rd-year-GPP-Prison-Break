using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;
    public Animator anim;
    public Rigidbody2D rb;
    public RayController rayController;
    public GameObject bullet;
    public Rigidbody2D bulletrb;

    // between 1 - 8 clockwise with 1 being up
    private int moveDirection;
    Vector2 movement;


    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        rayController = GetComponent<RayController>();
        bulletrb = GetComponent<Rigidbody2D>();

        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
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
            moveDirection = 5;
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
            moveDirection = 7;
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
            moveDirection = 3;
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
            moveDirection = 1;
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
            moveDirection = 6;
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
            moveDirection = 4;
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
            moveDirection = 2;
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
            moveDirection = 8;
            anim.SetBool("isDownPressed", false);
            anim.SetBool("isDownLeftPressed", false);
            anim.SetBool("isDownRightPressed", false);
            anim.SetBool("isLeftPressed", false);
            anim.SetBool("isUpLeftPressed", true);
            anim.SetBool("isUpPressed", false);
            anim.SetBool("isUpRightPressed", false);
            anim.SetBool("isRightPressed", false);
        }

        if(Input.GetMouseButtonDown(0))
        {
            GameObject bullets = Instantiate(bullet, this.transform.position, Quaternion.identity);
        }
            


    }

    public int returnMoveDirection()
    {
        return moveDirection;
    }
}
