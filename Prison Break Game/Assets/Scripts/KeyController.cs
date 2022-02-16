using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class KeyController : MonoBehaviour
{
    private bool isKeyCollected;
    public Rigidbody2D rb;
    private GameObject player;
    private int moveDirection;
    private PlayerController pc;
    private Vector2 moveDeviation;
    private GameObject gateBlocker;
    // Start is called before the first frame update
    void Start()
    {
        moveDeviation = new Vector2(0, 0);
        moveDirection = 0;
        isKeyCollected = false;
        rb = this.GetComponent<Rigidbody2D>();
        player = GameObject.FindWithTag("Player");
        gateBlocker = GameObject.FindWithTag("GateBlocker");
        pc = player.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isKeyCollected == true)
        {
            gateBlocker.SetActive(false);
            moveDirection = pc.returnMoveDirection();

            switch (moveDirection)
            {
                case 1:
                    moveDeviation = new Vector2(0, -0.5f);
                    break;
                case 2:
                    moveDeviation = new Vector2(-0.5f, -0.5f);
                    break;
                case 3:
                    moveDeviation = new Vector2(-0.5f, 0);
                    break;
                case 4:
                    moveDeviation = new Vector2(-0.5f, 0.5f);
                    break;
                case 5:
                    moveDeviation = new Vector2(0, 0.5f);
                    break;
                case 6:
                    moveDeviation = new Vector2(0.5f, 0.5f);
                    break;
                case 7:
                    moveDeviation = new Vector2(0.5f, 0);
                    break;
                case 8:
                    moveDeviation = new Vector2(0.5f, -0.5f);
                    break;
                default:
                    // code block
                    break;
            }
            Vector2 move = new Vector2(player.transform.position.x + moveDeviation.x, player.transform.position.y + moveDeviation.y);
            rb.MovePosition(move);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isKeyCollected = true;
    }
}
