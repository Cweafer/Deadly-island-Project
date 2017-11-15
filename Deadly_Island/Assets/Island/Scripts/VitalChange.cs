using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VitalChange : MonoBehaviour {

    public GameObject DropButton;

    // Use this for initialization
	void Start () {
        DropButton.GetComponent<Image>().color = Color.green;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
