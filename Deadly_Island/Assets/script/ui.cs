using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui: MonoBehaviour {

	public GameObject customCanvas;
	public bool displayInfo;
    public static class GlobalVariables
    {
        public static bool collected;
    }

	void Update(){
		FadeText ();
	}
		

	void OnMouseDown()
	{
		displayInfo = true;
        GlobalVariables.collected = true;
	}

	void OnMouseExit()
	{
		displayInfo = false;
	}

	void FadeText()
	{
		if (displayInfo) {
			customCanvas.SetActive (true);

		} 
		else {
			customCanvas.SetActive (false);
		}
	}
	
}
