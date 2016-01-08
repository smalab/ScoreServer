using UnityEngine;
using System.Collections;
using NCMB;
using System.Collections.Generic;

public class NCMBpush : MonoBehaviour {
	public  string q;
	// Use this for initialization
	void Start () {
		NCMBObject testClass = new NCMBObject ("TestClass");
		testClass ["message"] = "Hello, NCMB!";
		testClass ["name"] = textsave.player;
		testClass ["glade"] = textsave.glade;
		testClass.SaveAsync ();

		//TestClasssを検索するクラスを作成
		//NCMBQuery<NCMBObject> query = new NCMBQuery<NCMBObject> ("TestClass");
		//gladeの値が3と一致するオブジェクト検索
		//query.WhereEqualToで検索条件を設定
		//query.WhereEqualTo ("glade", 5);
		//query.FindAsync ((List<NCMBObject> objList ,NCMBException e) => {
		//	if (e != null) {
				//検索失敗時の処理
		//		Debug.Log ("×");
		//	} else {
				//gladeが3のオブジェクトを出力
		//		foreach (NCMBObject obj in objList) {
		//			Debug.Log ("objectId:" + obj.ObjectId);
		//			q = obj.ObjectId;
		//		}
		//	}
		//});
	
           
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
