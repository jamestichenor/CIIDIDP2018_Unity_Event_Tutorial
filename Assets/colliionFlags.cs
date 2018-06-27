using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliionFlags : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
		void OnCollisionEnter(Collision collision){
		Debug.Log("colliion started");
	}

	void OnCollisionStay (Collision collision){
		Debug.Log("Stay occuring..");
	}

	void OnCollisionExit (Collision collision)
	{
		Debug.Log("Exit called...");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
