using UnityEngine;
using System.Collections;
using System.Threading;
using NCMB;
using System.Collections.Generic;

public class getIRT_h : MonoBehaviour {
	public static int flag=0;
	// Use this for initialization
	void Start () {
		NCMBObject pullIRT = new NCMBObject ("StartIRT");
		pullIRT.ObjectId = "OBPCl7iRntMpTwyT";
		pullIRT.FetchAsync ((NCMBException e) => {
			if (e != null) {
				//検索失敗時の処理
			} else {
			}
			
		});
		Thread.Sleep (1500);
		IRT_h.Q1_1dif = (double)pullIRT["dif1"];
		IRT_h.Q1_2dif = (double)pullIRT["dif2"];
		IRT_h.Q2_1dif = (double)pullIRT["dif3"];
		IRT_h.Q2_2dif = (double)pullIRT["dif4"];
		IRT_h.Q3_1dif = (double)pullIRT["dif5"];
		IRT_h.Q3_2dif = (double)pullIRT["dif6"];
		IRT_h.Q4_1dif = (double)pullIRT["dif7"];
		IRT_h.Q4_2dif = (double)pullIRT["dif8"];
		IRT_h.Q5dif = (double)pullIRT["dif9"];

	}
	
	// Update is called once per frame
	void Update () {
		if (flag == 0) {
			NCMBObject pushIRT = new NCMBObject ("TestClass");
			pushIRT ["message"] = "IRT_ｈ";
			pushIRT ["name"] = textsave.player;
			pushIRT ["glade"] = textsave.glade;
			pushIRT ["IRT"] = IRT_h.maxLevel;
			pushIRT.SaveAsync ();
			flag = 1;
		}
	}


}
