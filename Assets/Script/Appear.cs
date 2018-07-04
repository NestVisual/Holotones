using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Appear : MonoBehaviour
{
    private float times;
    float count = 0;
    float x = RayController.x;
    float a = Auto.a;
    float b = Auto.b;
    float c = Auto.c;
    float d = Auto.d;
    float e = Auto.e;
    float f = Auto.f;
    float g = Auto.g;
    float h;
    float i;
    float j = Auto.j;
    float k = Auto.k;
    bool One = true;
    
    void FixedUpdate()
    {
        if (One)
        {
            if (Mathf.Abs(x - a) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 0;
            }
            if (Mathf.Abs(x - b) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 0.25f;
            }
            else if (Mathf.Abs(x - c) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 0.5f;
            }
            else if (Mathf.Abs(x - d) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 0.75f;
            }
            else if (Mathf.Abs(x - e) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 0.98f;
            }
            else if (Mathf.Abs(x - f) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 1.25f;
            }
            else if (Mathf.Abs(x - g) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 1.5f;
            }
            else if (Mathf.Abs(x - j) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 1.75f;
            }
            else if (Mathf.Abs(x - k) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 1.98f;
            }
            else
            {

            }
            i = count + h + 1.0f;
        }

        times += Time.deltaTime;

        if (h > 0 && Time.time > i)
        {
            if (times >= 2 - 0.02f)
            {
                gameObject.GetComponent<AudioSource>().enabled = false;
                gameObject.GetComponent<AudioSource>().enabled = true;
                times = 0.0f;
                One = false;
            }
        }
    }
}