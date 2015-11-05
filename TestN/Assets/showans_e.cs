using UnityEngine;
using UnityEngine.UI;
using System.Collections;

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
		if (AnsQ1_e.q1 == 1) {
			ResQ1_1 = "〇";
		} else {
			ResQ1_1 = "×";
		}
		if (AnsQ1_e.q2 == 1) {
			ResQ1_2 = "〇";
		} else {
			ResQ1_2 = "×";
		}
		if (AnsQ1_e.q3 == 1) {
			ResQ1_3 = "〇";
		} else {
			ResQ1_3 = "×";
		}
		if (AnsQ1_e.q4 == 1) {
			ResQ1_4 = "〇";
		} else {
			ResQ1_4 = "×";
		}
		if (AnsQ1_e.q5 == 1) {
			ResQ1_5 = "〇";
		} else {
			ResQ1_5 = "×";
		}
		if (AnsQ2_e.q1 == 1) {
			ResQ1_5 = "〇";
		} else {
			ResQ1_5 = "×";
		}
		if (AnsQ2_e.q2 == 1) {
			ResQ1_6 = "〇";
		} else {
			ResQ1_6 = "×";
		}
		if (AnsQ2_e.q3 == 1) {
			ResQ1_7 = "〇";
		} else {
			ResQ1_7 = "×";
		}
		if (AnsQ2_e.q4 == 1) {
			ResQ1_8 = "〇";
		} else {
			ResQ1_8 = "×";
		}
		if (AnsQ3_e.q1 == 1) {
			ResQ1_9 = "〇";
		} else {
			ResQ1_9 = "×";
		}
		if (AnsQ3_e.q2 == 1) {
			ResQ2_1 = "〇";
		} else {
			ResQ2_1 = "×";
		}
		if (AnsQ4_e.q == 1) {
			ResQ3_1 = "〇";
		} else {
			ResQ3_1 = "×";
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


	}
	}