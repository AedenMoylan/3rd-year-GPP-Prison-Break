
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour
{
    //public Camera m_camera;
    //public GameObject m_testCircle;
    //public Vector3 collision;
    //public Ray ray;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    public Vector3 getMouseClickPos()
    {
       Vector3 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //If the left mouse button is clicked.
        if (Input.GetMouseButtonDown(0))
        {
            //Get the mouse position on the screen and send a raycast into the game world from that position.
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            //If something was hit, the RaycastHit2D.collider will not be null.
            if (hit.collider != null)
            {
                Debug.Log(worldPoint);
                Debug.Log(hit.collider.name);
            }
        }
        return worldPoint;
    }


}
