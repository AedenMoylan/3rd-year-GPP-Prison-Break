using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private GameObject player;
   
    private Rigidbody2D rb;
    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {

        PlayerController.bulletsFired++;

        rb = GetComponent<Rigidbody2D>();

        player = GameObject.FindWithTag("Player");

        RayController raycont = player.GetComponent<RayController>();

        Vector3 pos = raycont.getMouseClickPos();

        Vector3 bulletDirection = (player.transform.position - pos) * -1;

        movement = new Vector2(bulletDirection.x, bulletDirection.y);
    }

    // Update is called once per frame
    void Update()
    {


        
       rb.MovePosition(rb.position + movement * 2 * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("kill");
        Destroy(this.gameObject);

        if (collision.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
