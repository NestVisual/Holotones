using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get : MonoBehaviour
{
    public float timeOut;
    private float times;
    private float times2;
    float count = 0;
    float x;
    float a;
    float b;
    float c;
    float d;
    float e;
    float f;
    float g;
    float h;
    float i;
    float j;
    float k;

    private void Start()
    {
        gameObject.GetComponent<AudioSource>().enabled = false;
    }

    void FixedUpdate()
    {
        times += Time.deltaTime;

        if (times >= timeOut - 0.02f)
        {
            times = 0.0f;
            ++count;
            a = count + 0.125f;
            b = count + 0.25f;
            c = count + 0.375f;
            d = count + 0.5f;
            e = count + 0.625f;
            f = count + 0.75f;
            g = count + 0.875f;
            j = count + 0.0f;
            k = count + 1.0f;

        }

        if (Input.GetMouseButtonDown(0))
        {
            x = Time.time + 0.02f;
            print(x);
            if (Mathf.Abs(x - a) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 0.125f;
            }
            else if (Mathf.Abs(x - b) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 0.25f;
            }
            else if (Mathf.Abs(x - c) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 0.375f;
            }
            else if (Mathf.Abs(x - d) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 0.498f;
            }
            else if (Mathf.Abs(x - e) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 0.625f;
            }
            else if (Mathf.Abs(x - f) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 0.75f;
            }
            else if (Mathf.Abs(x - k) == Mathf.Min(Mathf.Abs(x - j), Mathf.Abs(x - k), Mathf.Abs(x - a), Mathf.Abs(x - b), Mathf.Abs(x - c), Mathf.Abs(x - d), Mathf.Abs(x - e), Mathf.Abs(x - f), Mathf.Abs(x - g)))
            {
                h = 0.98f;
            }
            else
            {
                h = 0.875f;
            }
            i = count + h + 1.0f;
            print(i);
        }


        times2 += Time.deltaTime;

        if (h > 0 && Time.time > i)
        {
            if (times2 >= timeOut - 0.02f)
            {
                gameObject.GetComponent<AudioSource>().enabled = false;
                gameObject.GetComponent<AudioSource>().enabled = true;
                GetComponent<Rigidbody>().AddForce(transform.right * 2, ForceMode.Impulse);
                times2 = 0.0f;
                print(Time.time);
            }
        }
    }
}