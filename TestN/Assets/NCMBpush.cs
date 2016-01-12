using UnityEngine;
using System.Collections;
using System.Threading;
using NCMB;
using System.Collections.Generic;

public class NCMBpush : MonoBehaviour {
	public  string q;

	// Use this for initialization
	void Start () {

		NCMBObject testClass = new NCMBObject ("TestClass");
		NCMBObject KKK = new NCMBObject ("TestClass");

		testClass ["message"] = "Hello, NCMB!";
		testClass ["name"] = textsave.player;
		testClass ["glade"] = textsave.glade;
		testClass.SaveAsync ();

		KKK.ObjectId = "gYXqokSGFFXs9Ci";
		KKK.FetchAsync ((NCMBException e) => {
			if (e != null) {
				//検索失敗時の処理
			} else {
			}

		});
		Thread.Sleep (3000);
		q = (string)KKK["name"];
		Debug.Log (q);
           
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
