using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coll : MonoBehaviour {

    bool One;

    void OnSelect()
    {
        if (One)
        {
            Renderer rend = GameObject.Find("_On").GetComponent<Renderer>();
            rend.enabled = false;
            Renderer rend2 = GameObject.Find("_Off").GetComponent<Renderer>();
            rend2.enabled = true;
            GameObject.Find("Cube1").GetComponent<AudioSource>().volume = 0;
            GameObject.Find("Cube2").GetComponent<AudioSource>().volume = 0;
            GameObject.Find("Cube3").GetComponent<AudioSource>().volume = 0;
            GameObject.Find("Cube4").GetComponent<AudioSource>().volume = 0;
            One = false;
        }
        else
        {
            Renderer rend = GameObject.Find("_On").GetComponent<Renderer>();
            rend.enabled = true;
            Renderer rend2 = GameObject.Find("_Off").GetComponent<Renderer>();
            rend2.enabled = false;
            GameObject.Find("Cube1").GetComponent<AudioSource>().volume = 1;
            GameObject.Find("Cube2").GetComponent<AudioSource>().volume = 1;
            GameObject.Find("Cube3").GetComponent<AudioSource>().volume = 1;
            GameObject.Find("Cube4").GetComponent<AudioSource>().volume = 1;
            One = true;
        }
    }
}
