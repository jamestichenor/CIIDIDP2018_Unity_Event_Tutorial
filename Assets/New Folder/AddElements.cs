using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AddElements : MonoBehaviour {
	public GameObject startGo;
	public GameObject copyGo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("up"))
		{
			//Debug.Log("space key was pressed");
			makeObject();
		}
		
	}

	public void makeObject ()
	{
		//Debug.Log("space key was pressed");
		Vector3 startPos;
		Quaternion startRotation;

		startPos = startGo.transform.position;
		startRotation = startGo.transform.rotation; 
		Instantiate(copyGo,startPos,startRotation);
		 
		
	}
}
