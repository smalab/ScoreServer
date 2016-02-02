using UnityEngine;
using System.Collections;
using System.Threading;
using NCMB;
using System.Collections.Generic;

public class getIRT_e : MonoBehaviour {
	public static int flag=0;
	// Use this for initialization
	void Start () {
		NCMBObject pullIRT = new NCMBObject ("StartIRT");
		pullIRT.ObjectId = "4rvB5LRL1CugCTYO";
		pullIRT.FetchAsync ((NCMBException e) => {
			if (e != null) {
				//検索失敗時の処理
			} else {
			}
			
		});
		Thread.Sleep (1500);
		IRT_e.Q1_1dif = (double)pullIRT["dif1"];
		IRT_e.Q1_2dif = (double)pullIRT["dif2"];
		IRT_e.Q1_3dif = (double)pullIRT["dif3"];
		IRT_e.Q1_4dif = (double)pullIRT["dif4"];
		IRT_e.Q1_5dif = (double)pullIRT["dif5"];
		IRT_e.Q1_6dif = (double)pullIRT["dif6"];
		IRT_e.Q1_7dif = (double)pullIRT["dif7"];
		IRT_e.Q1_8dif = (double)pullIRT["dif8"];
		IRT_e.Q1_9dif = (double)pullIRT["dif9"];
		IRT_e.Q2_1dif = (double)pullIRT["dif10"];
		IRT_e.Q3_1dif = (double)pullIRT["dif11"];
		IRT_e.Q4_1dif = (double)pullIRT["dif12"];
	}
	
	// Update is called once per frame
	void Update () {
		if (flag == 0) {
			NCMBObject pushIRT = new NCMBObject ("TestClass");
			pushIRT ["message"] = "IRT_e";
			pushIRT ["name"] = textsave.player;
			pushIRT ["glade"] = textsave.glade;
			pushIRT ["IRT"] = IRT_e.maxLevel;
			pushIRT.SaveAsync ();
			flag=1;
		}
	}

}
