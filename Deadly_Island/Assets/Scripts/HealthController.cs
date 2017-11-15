using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour {

	public float Value = 1.0f;
	public float Fade = 0.01f;
	public float Period = 10.0f;

	public GUIBarScript GBS;

	// Use this for initialization
	void Start () {
		GBS = GetComponent<GUIBarScript>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > Period){
			Period = Period + 10.0f;
			Value = Value - 0.01f;
			GBS.Value = Value;
	}
}
}
