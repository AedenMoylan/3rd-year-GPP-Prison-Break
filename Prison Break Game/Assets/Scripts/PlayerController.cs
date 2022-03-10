using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public GameObject Player;
    public Animator anim;
    public Rigidbody2D rb;
    public RayController rayController;
    public GameObject bullet;
    public Rigidbody2D bulletrb;

    public static int bulletsFired;

    public Button leftButton;
    public Button rightButton;
    public Button upButton;
    public Button downButton;

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

        if (Input.GetKey(KeyCode.S))
        {
        moveDown();

        }

        if (Input.GetKey(KeyCode.A))
        {
        moveLeft();

        }

        if (Input.GetKey(KeyCode.W))
        {
        moveUp();

        }

        if (Input.GetKey(KeyCode.D))
        {
        moveRight();

        }














        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A))
        {
            movement = new Vector2(-1, -1);

            rb.MovePosition(rb.position + movement * 2 * Time.fixedDeltaTime);

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
            movement = new Vector2(1, -1);

            rb.MovePosition(rb.position + movement * 2 * Time.fixedDeltaTime);

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
            movement = new Vector2(1, 1);

            rb.MovePosition(rb.position + movement * 2 * Time.fixedDeltaTime);

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
            movement = new Vector2(-1, 1);

            rb.MovePosition(rb.position + movement * 2 * Time.fixedDeltaTime);

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

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullets = Instantiate(bullet, this.transform.position, Quaternion.identity);

            bulletsFired++;
        }



    }

    public int returnMoveDirection()
    {
        return moveDirection;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string SceneName = currentScene.name;

        if (collision.tag == "NextLevelShape")
        {
           if (SceneName == "Level1")
            { 
                 SceneManager.LoadScene("Level2"/*, LoadSceneMode.Additive*/);
            }

           else if (SceneName == "Level2")
            {
                SceneManager.LoadScene("Highscore"/*, LoadSceneMode.Additive*/);
            }
        }

        if (collision.tag == "Enemy")
        {
            SceneManager.LoadScene("GameOver"/*, LoadSceneMode.Additive*/);
        }
    }

    public void moveLeft()
    {
        //if (Input.GetKey(KeyCode.A))
        //{
            movement = new Vector2(-1, 0);

            rb.MovePosition(rb.position + movement * 2 * Time.fixedDeltaTime);

            moveDirection = 7;
            anim.SetBool("isDownPressed", false);
            anim.SetBool("isDownLeftPressed", false);
            anim.SetBool("isDownRightPressed", false);
            anim.SetBool("isLeftPressed", true);
            anim.SetBool("isUpLeftPressed", false);
            anim.SetBool("isUpPressed", false);
            anim.SetBool("isUpRightPressed", false);
            anim.SetBool("isRightPressed", false);
       // }
    }

    public void moveRight()
    {
        movement = new Vector2(1, 0);

        rb.MovePosition(rb.position + movement * 2 * Time.fixedDeltaTime);

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

    public void moveUp()
    {

        movement = new Vector2(0, 1);

        rb.MovePosition(rb.position + movement * 2 * Time.fixedDeltaTime);

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

    public void moveDown()
    {
        movement = new Vector2(0, -1);

        rb.MovePosition(rb.position + movement * 2 * Time.fixedDeltaTime);

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


}
