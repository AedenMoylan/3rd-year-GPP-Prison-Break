using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource Music;
    bool isMusicPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        Music = GetComponent<AudioSource>();
        if (isMusicPlaying == false)
        {
            Music.Play();
            isMusicPlaying = true;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayMusic()
    {
        if (Music.isPlaying) return;
        Music.Play();
    }
}
