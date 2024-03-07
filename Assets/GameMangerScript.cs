using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMangerScript : MonoBehaviour
{
    public GameObject Cookie;
    public GameObject crusor;
    public GameObject grandma;
    public int cookiecount;


    // Start is called before the first frame update
    void Start()
    {
        cookiecount = 0;
        Instantiate(Cookie);
        Debug.Log("Press space to increase cookie count");
        GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            cookiecount += 1;
        }
    }
}
