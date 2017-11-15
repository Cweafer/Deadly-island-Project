using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sName : MonoBehaviour {

    public Text myText;
    public bool displayInfo;
    public float fadeTime;

    void Start()
    {
        myText.color = Color.clear;    
    }

    void Update()
    {
        FadeText();
    }


    void OnMouseOver()
    {
        displayInfo = true;
    }

    void OnMouseExit()
    {
        displayInfo = false;
    }

    void FadeText()
    {
        if (displayInfo)
        {
            myText.color = Color.Lerp(myText.color, Color.black, fadeTime * Time.deltaTime);

        }
        else
        {
            myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
        }
    }
}
