using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bP : MonoBehaviour {


	[SerializeField]
	GameObject objC;

	bool circlePlay;


	// Use this for initialization
	void Start () {

		circlePlay = objC.GetComponent<circleTransition> ().play;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GO()
	{
		Debug.Log ("OK");
		circlePlay = true;
	}
}
