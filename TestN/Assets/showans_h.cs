using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showans_h : MonoBehaviour {
	public Text rltQ1_1;
	public Text rltQ1_2;
	public Text rltQ2_1;
	public Text rltQ2_2;
	public Text rltQ3_1;
	public Text rltQ3_2;
	public Text rltQ4_1;
	public Text rltQ4_2;
	public Text rltQ5_1;
	public Text name;
	public Text glade;

	public string playername;
	public string ResQ1_1;
	public string ResQ1_2;
	public string ResQ2_1;
	public string ResQ2_2;
	public string ResQ3_1;
	public string ResQ3_2;
	public string ResQ4_1;
	public string ResQ4_2;
	public string ResQ5_1;
	
	void Start()
	{
		playername = textsave.player;
		TotalResult.totalQ=9;
		name.text = playername;
		if (textsave.glade == 0) {
			glade.text="１年生";
		}
		if (textsave.glade == 1) {
			glade.text="２年生";
		}
		if (textsave.glade == 2) {
			glade.text="３年生";
		}
		if (textsave.glade == 3) {
			glade.text="４年生";
		}
		if (AnsQ1_h.q1 == 1){
			ResQ1_1 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ1_1 = "×";
		}
		if (AnsQ1_h.q2 == 1) {
			ResQ1_2 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ1_2 = "×";
		}
		if (AnsQ2_h.q1 == 1) {
			ResQ2_1 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ2_1 = "×";
		}
		if (AnsQ2_h.q2 == 1) {
			ResQ2_2 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ2_2 = "×";
		}
		if (AnsQ3_h.q1 == 1) {
			ResQ3_1 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ3_1 = "×";
		}
		if (AnsQ3_h.q2 == 1) {
			ResQ3_2 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ3_2 = "×";
		}
		if (AnsQ4_h.q1 == 1) {
			ResQ4_1 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ4_1 = "×";
		}
		if (AnsQ4_h.q2 == 1) {
			ResQ4_2 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ4_2 = "×";
		}
		if (AnsQ5_h.q == 1) {
			ResQ5_1 = "〇";
			TotalResult.T_ans++;
		} else {
			ResQ5_1 = "×";
		}
		
		rltQ1_1.text = ResQ1_1;
		rltQ1_2.text = ResQ1_2;
		rltQ2_1.text = ResQ2_1;
		rltQ2_2.text = ResQ2_2;
		rltQ3_1.text = ResQ3_1;
		rltQ3_2.text = ResQ3_2;
		rltQ4_1.text = ResQ4_1;
		rltQ4_2.text = ResQ4_2;
		rltQ5_1.text = ResQ5_1;
		
	}
}