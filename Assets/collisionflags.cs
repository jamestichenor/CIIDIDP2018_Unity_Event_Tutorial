using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class collisionflags : MonoBehaviour {

	public GameObject cloneScript;

	// Use this for initialization
	void Start () {
		
	}
	
		void OnCollisionEnter(Collision collision){
		Debug.Log("collision started");
	}

	void OnCollisionStay (Collision collision){
		Debug.Log("Stay occuring..");
	}

	void OnCollisionExit (Collision collision)
	{
		           if(collision.gameObject.name == "Floor")        
              {
	      //	Debug.Log("Exit called...");
	       cloneScript.GetComponent<AddElements>().makeObject();
	     }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
