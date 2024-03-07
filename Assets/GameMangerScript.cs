using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMangerScript : MonoBehaviour
{
    public GameObject Cookie;
    public GameObject crusor;
    public GameObject grandma;
    public GameObject farm;
    public GameObject explosionPrefab;
    public ulong cookiecount;
    public uint cookieadd;
    public bool clicks;


    // Sets Cookiecount to zero while spawning a cookie and playing a sound
    void Start()
    {
        clicks = false;
        cookieadd = 1;
        cookiecount = 1;
        Instantiate(Cookie);
        Debug.Log("Press space to increase cookie count");
        GetComponent<AudioSource>().Play();
    }

    // Space will increase Cookie count
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            cookiecount = cookieadd + cookiecount;
        }

        if(cookiecount % 10 = 0 && cookiecount != 0)
        {
            cookiecount * 2;
        }
        
        if(cookiecount == 10 && clicks == false)
        {
            Debug.Log("You got a Cursor! It begains making additional cookies!");
            clicks = true;
            GetComponent<AudioSource>().Play();
            Instantiate(crusor);
            Instantiate(explosionPrefab);
        }
        
        if(cookiecount == 20 && clikcs == true)
        {
            Debug.Log("You got a grandma! She begins making additional cookies!");
            clicks = false;
            GetComponent<AudioSource>().Play();
            Instantiate(grandma);
            Instantiate(explosionPrefab);
        }
        
        if(cookiecount == 30 && clicks == false)
        {
            Debug.Log("You got a cookie farm! It begins producing additional cookies!");
            clicks = true;
            GetComponent<AudioSource>().Play();
            Instantiate(farm);
            Instantiate(explosionPrefab);
        }

    }
}
