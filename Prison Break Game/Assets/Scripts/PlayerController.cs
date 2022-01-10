using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;
    public Animator anim;

    bool isDownPressed = false;
    bool isDownLeftPressed = false;
    bool isDownRightPressed = false;
    bool isLeftPressed = false;
    bool isUpLeftPressed = false;
    bool isUpPressed = false;
    bool isUpRightPressed = false;
    bool isRightPressed = false;
    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            isDownPressed = true;
            isDownLeftPressed = false;
            isDownRightPressed = false;
            isLeftPressed = false;
            isUpLeftPressed = false;
            isUpPressed = false;
            isUpRightPressed = false;
            isRightPressed = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            isDownPressed = false;
            isDownLeftPressed = false;
            isDownRightPressed = false;
            isLeftPressed = true;
            isUpLeftPressed = false;
            isUpPressed = false;
            isUpRightPressed = false;
            isRightPressed = false;
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            isDownPressed = false;
            isDownLeftPressed = true;
            isDownRightPressed = false;
            isLeftPressed = false;
            isUpLeftPressed = false;
            isUpPressed = false;
            isUpRightPressed = false;
            isRightPressed = false;
        }

        if (isDownLeftPressed == true)
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

        if (isDownPressed == true)
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

            if (isLeftPressed == true)
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
        

    }
}
