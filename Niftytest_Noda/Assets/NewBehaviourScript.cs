﻿using UnityEngine;
using System.Collections;
using NCMB;
using System.Collections.Generic;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject> ("TestClass");
		query.WhereEqualTo ("message", "Hello, Tarou!");
		query.FindAsync ((List<NCMBObject> objectList,NCMBException e) => {
			if (objectList.Count != 0) {
				NCMBObject obj = objectList [0];
				Debug.Log ("message : " + obj ["message"]);
			} else {
				NCMBObject testClass = new NCMBObject ("TestClass");
				testClass ["message"] = "Hello, NCMB!";
				testClass.SaveAsync ();
			}
		});
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
