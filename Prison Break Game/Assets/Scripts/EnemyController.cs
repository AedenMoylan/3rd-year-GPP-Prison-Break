using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.x < this.transform.position.x)
        {
           // this.transform.Rotate(0,180,0);

            transform.rotation = Quaternion.Euler(0,180,0);
        }
        else if (playerTransform.position.x > this.transform.position.x)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
