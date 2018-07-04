using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    void OnSelect()
    {
        gameObject.GetComponent<AudioSource>().enabled = false;
        gameObject.GetComponent<AudioSource>().enabled = true;
        GameObject obj = GameObject.Find("Dome");
        obj.tag = gameObject.tag;
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}