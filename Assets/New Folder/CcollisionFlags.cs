using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CcollisionFlags : MonoBehaviour {

	public GameObject cloneScript;
	//Scriptab
	
	void OnCollisionEnter(Collision collision){
	//	Debug.Log("colliion started");

	//cloneScript.GetComponent<AddElements>().makeObject();
	}

	void OnCollisionStay (Collision collision){
	//	Debug.Log("Stay occuring..");
	}

	void OnCollisionExit (Collision collision)
	{
	//	Debug.Log("Exit called...");
	//cloneScript.GetComponent<AddElements>().makeObject();
	if (collision.gameObject.name == "floor")
	{
		cloneScript.GetComponent<AddElements>().makeObject();
	}

	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
