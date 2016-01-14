using UnityEngine;
using System.Collections;
using System.Threading;
using NCMB;
using System.Collections.Generic;

public class getIRT_b : MonoBehaviour {

	// Use this for initialization
	void Start () {
			NCMBObject pullIRT = new NCMBObject ("StartIRT");
		pullIRT.ObjectId = "4nUEe8T0pKe2KLUI";
			pullIRT.FetchAsync ((NCMBException e) => {
				if (e != null) {
					//検索失敗時の処理
				} else {
				}
				
			});
			Thread.Sleep (1500);
			IRT_b.Q1_1dif = (double)pullIRT["dif1"];
			IRT_b.Q1_2dif = (double)pullIRT["dif2"];
			IRT_b.Q2_1dif = (double)pullIRT["dif3"];
			IRT_b.Q2_2dif = (double)pullIRT["dif4"];
			IRT_b.Q3_1dif = (double)pullIRT["dif5"];
			IRT_b.Q3_2dif = (double)pullIRT["dif6"];
			IRT_b.Q4_1dif = (double)pullIRT["dif7"];
			IRT_b.Q4_2dif = (double)pullIRT["dif8"];
			IRT_b.Q5dif = (double)pullIRT["dif9"];


	}
	
	// Update is called once per frame
	void Update () {
		NCMBObject pushIRT = new NCMBObject ("TestClass");
		
		pushIRT["message"] = "IRT_b";
		pushIRT["name"] = textsave.player;
		pushIRT["glade"] = textsave.glade;
		pushIRT ["IRT"] = IRT_b.maxLevel;
		pushIRT.SaveAsync ();

	}

}
