using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject audioManager;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<AudioController>().PlayMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
