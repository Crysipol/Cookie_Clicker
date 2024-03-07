using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMangerScript : MonoBehaviour
{
    public GameObject Cookie;
    public GameObject crusor;
    public GameObject grandma;
    public int cookiecount;
    public int cookieadd;
    public bool clicks;


    // Sets Cookiecount to zero while spawning a cookie and playing a sound
    void Start()
    {
        clicks = false;
        cookiecount = 0;
        Instantiate(Cookie);
        Debug.Log("Press space to increase cookie count");
        GetComponent<AudioSource>().Play();
    }

    // Space will increase Cookie count
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            cookieadd = 1;
            cookiecount = cookiecount + cookieadd;
        }

        if(cookiecount == 10 && clicks == false)
        {
            Debug.Log("You got a Cursor! It begains making additional cookies!");
            Instantiate(crusor);
            cookieadd += 1;
            GetComponent<AudioSource>().Play();
            clicks = true;
        }


    }
}
