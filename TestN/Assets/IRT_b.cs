using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IRT_b: MonoBehaviour {
	public string textmax;
	//問題の難易度
	public static double Q1_1dif=0.511;
	public static double Q1_2dif=-0.556;
	public static double Q2_1dif=-0.746;
	public static double Q2_2dif=0.358;
	public static double Q3_1dif=-0.415;
	public static double Q3_2dif=0.779;
	public static double Q4_1dif=-2.075;
	public static double Q4_2dif=-0.083;
	public static double Q5dif=3.352;
	//問題の認識度　a
	public static double Q1_1a=0.242;
	public static double Q1_2a=0.231;
	public static double Q2_1a=0.232;
	public static double Q2_2a=0.238;
	public static double Q3_1a=0.230;
	public static double Q3_2a=0.249;
	public static double Q4_1a=0.282;
	public static double Q4_2a=0.232;
	public static double Q5a=0.417;
	//1PLのICC計算(正答確率）
	public static double Q1_1icct;
	public static double Q1_2icct;
	public static double Q2_1icct;
	public static double Q2_2icct;
	public static double Q3_1icct;
	public static double Q3_2icct;
	public static double Q4_1icct;
	public static double Q4_2icct;
	public static double Q5icct;

	//最大尤度
	public static double max=-5;
	public static double maxLevel=-5;
	//最大尤度推定用変数
	public static double MLE;
	public static float Pi=Mathf.PI;
	 void Start(){

		for (double i=-5.0; i<=5.0; i=i+0.1) {

			Q1_1icct=1/(1+Mathf.Pow(Pi,(float)(-1.7*Q1_1a*(i-Q1_1dif))));
			if(AnsQ1.q1 != 1){
			Q1_1icct=1-Q1_1icct;
			}
	
			Q1_2icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1.7*Q1_2a*(i-Q1_2dif))));
			if(AnsQ1.q2 != 1)
				Q1_2icct=1-Q1_2icct;

			Q2_1icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1.7*Q2_1a*(i-Q2_1dif))));
			if(AnsQ2.q1 != 1)
			Q2_1icct=1-Q2_1icct;

			Q2_2icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1.7*Q2_2a*(i-Q2_2dif))));
			if(AnsQ2.q2 != 1)
			Q2_2icct=1-Q2_2icct;

			Q3_1icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1.7*Q3_1a*(i-Q3_1dif))));
			if(AnsQ3.q1 != 1)
			Q3_1icct=1-Q3_1icct;

			Q3_2icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1.7*Q3_2a*(i-Q3_2dif))));
			if(AnsQ3.q2 != 1)
			Q3_2icct=1-Q3_2icct;

			Q4_2icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1.7*Q4_2a*(i-Q4_2dif))));
			if(AnsQ4.q2 != 1)
			Q4_2icct=1-Q4_2icct;		

			Q4_1icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1.7*Q4_1a*(i-Q4_1dif))));
			if(AnsQ4.q1 != 1)
			Q4_1icct=1-Q4_1icct;

			Q5icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1.7*Q5a*(i-Q5dif))));
			if(AnsQ5.q5Ans != 1)
			Q5icct=1-Q5icct;
			MLE=Q1_1icct*Q1_2icct*Q2_1icct*Q2_2icct*Q3_1icct*Q3_2icct*Q4_1icct*Q4_2icct*Q5icct;
			if(MLE>max){
			max=Mathf.Max((float)max,(float)MLE);
			maxLevel=Mathf.Max((float)maxLevel,(float)i);
			}
	}
		IRTforUser.selectdif=7;
		IRTforUser.result = maxLevel;
		Debug.Log (max);
	}}
