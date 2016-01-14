using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Threading;
using NCMB;
using System.Collections.Generic;
public class showans_e : MonoBehaviour {
	public Text rltQ1_1;
	public Text rltQ1_2;
	public Text rltQ1_3;
	public Text rltQ1_4;
	public Text rltQ1_5;
	public Text rltQ1_6;
	public Text rltQ1_7;
	public Text rltQ1_8;
	public Text rltQ1_9;
	public Text rltQ2_1;
	public Text rltQ3_1;
	public Text rltQ4_1;
	public Text name;
	public Text glade;

	public string playername;
	public string ResQ1_1;
	public string ResQ1_2;
	public string ResQ1_3;
	public string ResQ1_4;
	public string ResQ1_5;
	public string ResQ1_6;
	public string ResQ1_7;
	public string ResQ1_8;
	public string ResQ1_9;
	public string ResQ2_1;
	public string ResQ3_1;
	public string ResQ4_1;

	void Start()
	{
		NCMBObject pushIRT = new NCMBObject ("result_E");
		playername = textsave.player;
		TotalResult.totalQ=12;
		name.text = playername;
		if (textsave.glade == 1) {
			glade.text="１年生";
		}
		if (textsave.glade == 2) {
			glade.text="２年生";
		}
		if (textsave.glade == 3) {
			glade.text="３年生";
		}
		if (textsave.glade == 4) {
			glade.text="４年生";
		}
		if (AnsQ1_e.q1 == 1) {

			ResQ1_1 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ1_1 = "×";
		}
		if (AnsQ1_e.q2 == 1) {
			ResQ1_2 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ1_2 = "×";
		}
		if (AnsQ1_e.q3 == 1) {
			ResQ1_3 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ1_3 = "×";
		}
		if (AnsQ1_e.q4 == 1) {
			ResQ1_4 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ1_4 = "×";
		}
		if (AnsQ1_e.q5 == 1) {
			ResQ1_5 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ1_5 = "×";
		}

		if (AnsQ2_e.q1 == 1) {
			ResQ1_6 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ1_6 = "×";
		}
		if (AnsQ2_e.q2 == 1) {
			ResQ1_7 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ1_7 = "×";
		}
		if (AnsQ2_e.q3 == 1) {
			ResQ1_8 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ1_8 = "×";
		}
		if (AnsQ2_e.q4 == 1) {
			ResQ1_9 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ1_9 = "×";
		}
		if (AnsQ3_e.q1 == 1) {
			ResQ2_1 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ2_1 = "×";
		}
		if (AnsQ3_e.q2 == 1) {
			ResQ3_1 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ3_1 = "×";
		}
		if (AnsQ4_e.q == 1) {
			ResQ4_1 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ4_1 = "×";
		}

		rltQ1_1.text = ResQ1_1;
		rltQ1_2.text = ResQ1_2;
		rltQ1_3.text = ResQ1_3;
		rltQ1_4.text = ResQ1_4;
		rltQ1_5.text = ResQ1_5;
		rltQ1_6.text = ResQ1_6;
		rltQ1_7.text = ResQ1_7;
		rltQ1_8.text = ResQ1_8;
		rltQ1_9.text = ResQ1_9;
		rltQ2_1.text = ResQ2_1;
		rltQ3_1.text = ResQ3_1;
		rltQ4_1.text = ResQ4_1;

		pushIRT["name"] = textsave.player;
		pushIRT["1"] = AnsQ1_e.q1;
		pushIRT["2"] = AnsQ1_e.q2;
		pushIRT["3"] = AnsQ1_e.q3;
		pushIRT["4"] = AnsQ1_e.q4;
		pushIRT["5"] = AnsQ1_e.q5;
		pushIRT["6"] = AnsQ2_e.q1;
		pushIRT["7"] = AnsQ2_e.q2;
		pushIRT["8"] = AnsQ2_e.q3;
		pushIRT["9"] = AnsQ2_e.q4;
		pushIRT["10"] = AnsQ3_e.q1;
		pushIRT["11"] = AnsQ3_e.q2;
		pushIRT["12"] = AnsQ4_e.q;
		pushIRT.SaveAsync ();
	}
	}