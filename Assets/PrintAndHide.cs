using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 0;
    int rand;
    public Renderer rend;
    GameObject[] red;
    GameObject[] blue;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rand = UnityEngine.Random.Range((int)200, (int)251);
        red = GameObject.FindGameObjectsWithTag("Red");
        blue = GameObject.FindGameObjectsWithTag("Blue");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ": " + i);
        i++;

        foreach (GameObject r in red)
        {
            if(i == 100)
            {
                r.SetActive(false);
            }
        }
        foreach (GameObject b in blue)
        {
            if (i == rand)
            {
                gameObject.GetComponent<Renderer>().enabled = false;
                /*
                Debug.Log(gameObject.name + "'s Random.Range == " + rand + " & int i == " + i); //debug purposes only
                */
            }
        }
    }
}
