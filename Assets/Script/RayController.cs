using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayController : MonoBehaviour
{
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;
    public GameObject Light5;
    public GameObject Light6;
    public GameObject Light7;
    public GameObject Light8;
    public GameObject Light9;
    public GameObject Light10;
    public GameObject Light11;
    public GameObject Light12;
    public GameObject Light13;
    public GameObject Light14;
    public GameObject Light15;
    public GameObject Light16;
    public GameObject Light17;
    public GameObject Light18;
    public GameObject Light19;
    public GameObject Light20;
    public GameObject Light21;
    public GameObject Light22;
    public GameObject Light23;
    public GameObject Light24;
    float speed = 8;
    public static float x; 

    void OnSelect()
    {
        x = Time.time;
        var headPosition = Camera.main.transform.position;
        Vector3 gazeDirection = Camera.main.transform.forward;
        RaycastHit hitInfo;

        if (Physics.Raycast(headPosition, gazeDirection, out hitInfo))
        {
            GameObject[] tagobjs = GameObject.FindGameObjectsWithTag(gameObject.tag);
            GameObject Ball = (GameObject)Instantiate(tagobjs[0],
            headPosition, Quaternion.identity);
            Ball.GetComponent<AudioSource>().enabled = false;
            Ball.GetComponent<Rigidbody>().velocity = gazeDirection * speed;

            if (gameObject.tag == "BASS1")
            {
                Instantiate(Light1, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "BASS2")
            {
                Instantiate(Light2, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "BASS3")
            {
                Instantiate(Light3, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "BASS4")
            {
                Instantiate(Light4, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "BD")
            {
                Instantiate(Light5, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "BELL1")
            {
                Instantiate(Light6, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "BELL2")
            {
                Instantiate(Light7, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "BELL3")
            {
                Instantiate(Light8, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "DELAY")
            {
                Instantiate(Light9, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "HARM1")
            {
                Instantiate(Light10, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "HARM2")
            {
                Instantiate(Light11, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "HIHAT1")
            {
                Instantiate(Light12, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "HIHAT2")
            {
                Instantiate(Light13, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "HIHAT3")
            {
                Instantiate(Light14, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "HIHAT4")
            {
                Instantiate(Light15, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "HIHAT5")
            {
                Instantiate(Light16, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "MARINBA")
            {
                Instantiate(Light17, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "PARC1")
            {
                Instantiate(Light18, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "PIZZ1")
            {
                Instantiate(Light19, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "PIZZ2")
            {
                Instantiate(Light20, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "PIZZ3")
            {
                Instantiate(Light21, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "SNARE1")
            {
                Instantiate(Light22, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "SNARE2")
            {
                Instantiate(Light23, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
            if (gameObject.tag == "SNARE3")
            {
                Instantiate(Light24, hitInfo.point, Quaternion.FromToRotation(Vector3.up, hitInfo.normal));
            }
        }
    }
}