using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BASS1 : MonoBehaviour
{
    private Renderer _renderer;


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

    void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Update()
    {
        if (GameObject.Find("Dome").tag == gameObject.tag)
        {
            _renderer.material.EnableKeyword("_EMISSION");
            _renderer.material.SetColor("_EmissionColor", new Color(0.256719f, 0.1488971f, 0.5955882f));
        }

        else
        {
            _renderer.material.EnableKeyword("_EMISSION");
            _renderer.material.SetColor("_EmissionColor", new Color(0,0,0));
        }
    }
}