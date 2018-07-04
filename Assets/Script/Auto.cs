using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Auto : MonoBehaviour
{
    public static float times;
    public static float count;
    bool B1 = true;
    bool B2 = true;
    bool B3 = true;
    bool B4 = true;
    public static float a;
    public static float b;
    public static float c;
    public static float d;
    public static float e;
    public static float f;
    public static float g;
    public static float j;
    public static float k;

    void FixedUpdate()
    {
        times += Time.deltaTime;

        if (times >= 2 - 0.02f)
        {
            ++count;
            ++count;
            times = 0.0f;
            B1 = true;
            B2 = true;
            B3 = true;
            B4 = true;
            a = count + 0;
            b = count + 0.25f;
            c = count + 0.5f;
            d = count + 0.75f;
            e = count + 1;
            f = count + 1.25f;
            g = count + 1.5f;
            j = count + 1.75f;
            k = count + 2;
        }

        if (times >= 0 && B1)
        {
            GameObject[] tagobjs = GameObject.FindGameObjectsWithTag("0");
            foreach (GameObject obj in tagobjs)
            {
                obj.GetComponent<AudioSource>().enabled = false;
                obj.GetComponent<AudioSource>().enabled = true;
                B1 = false;
            }
        }
        
        if (times >= 0.25 * 2 - 0.02f && B2)
        {
            GameObject[] tagobjs2 = GameObject.FindGameObjectsWithTag("250");
            foreach (GameObject obj2 in tagobjs2)
            {
                obj2.GetComponent<AudioSource>().enabled = false;
                obj2.GetComponent<AudioSource>().enabled = true;
                B2 = false;
            }
        }

        if (times >= 0.5 * 2 - 0.02f && B3)
        {
            GameObject[] tagobjs4 = GameObject.FindGameObjectsWithTag("500");
            foreach (GameObject obj4 in tagobjs4)
            {
                obj4.GetComponent<AudioSource>().enabled = false;
                obj4.GetComponent<AudioSource>().enabled = true;
                B3 = false;
            }
        }

        if (times >= 0.75 * 2 - 0.02f && B4)
        {
            GameObject[] tagobjs6 = GameObject.FindGameObjectsWithTag("750");
            foreach (GameObject obj6 in tagobjs6)
            {
                obj6.GetComponent<AudioSource>().enabled = false;
                obj6.GetComponent<AudioSource>().enabled = true;
                B4 = false;
            }
        }
    }
}