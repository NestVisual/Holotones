using UnityEngine;
using System.Collections;

public class Gif : MonoBehaviour
{
    int imageLength = 44;
    float changeFrameSecond = 0.04f;
    public string folderName;
    public string headText;
    private int firstFrameNum;
    private float dTime;
    
    void Start()
    {
        firstFrameNum = -6;
        dTime = 0.0f;
    }
    
    void FixedUpdate()
    {
        dTime += Time.deltaTime;
        if (changeFrameSecond < dTime)
        {
            dTime = 0.0f;
            firstFrameNum++;
            if (firstFrameNum > imageLength)
            {
                firstFrameNum = -6;
            }
        }
        Texture tex = Resources.Load(folderName + "/" + headText + firstFrameNum) as Texture;
        gameObject.GetComponent<Renderer>().material.SetTexture("_MainTex", tex);
    }
}