using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IRT_e: MonoBehaviour {
	public string textmax;
	//問題の難易度
	public static double Q1_1dif=-2.425;
	public static double Q1_2dif=-2.425;
	public static double Q1_3dif=-1.664;
	public static double Q1_4dif=-2.831;
	public static double Q1_5dif=-2.425;
	public static double Q1_6dif=-0.531;
	public static double Q1_7dif=-2.831;
	public static double Q1_8dif=-0.849;
	public static double Q1_9dif=-2.831;
	public static double Q2_1dif=0.784;
	public static double Q3_1dif=-1.414;
	public static double Q4_1dif=0.548;
	//1PLのICC計算(正答確率）
	public static double Q1_1icct;
	public static double Q1_2icct;
	public static double Q1_3icct;
	public static double Q1_4icct;
	public static double Q1_5icct;
	public static double Q1_6icct;
	public static double Q1_7icct;
	public static double Q1_8icct;
	public static double Q1_9icct;
	public static double Q2_1icct;
	public static double Q3_1icct;
	public static double Q4_1icct;

	
	//最大尤度
	public static double max=0;
	public static double maxLevel=-5;
	//最大尤度推定用変数
	public static double MLE;
	public static float Pi=Mathf.PI;
	void Start(){
		
		for (double i=-5.0; i<=5.0; i=i+0.1) {
			
			Q1_1icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1*(i-Q1_1dif))));
			if(AnsQ1_e.q1 == 0){
				Q1_1icct=1-Q1_1icct;
			}

			Q1_2icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1*(i-Q1_2dif))));
			if(AnsQ1_e.q2 == 0){
				Q1_2icct=1-Q1_2icct;
			}

			Q1_3icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1*(i-Q1_3dif))));
			if(AnsQ1_e.q3 == 0){
				Q1_3icct=1-Q1_3icct;
			}
			
			Q1_4icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1*(i-Q1_4dif))));
			if(AnsQ1_e.q4 == 0){
				Q1_4icct=1-Q1_4icct;
			}

			Q1_5icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1*(i-Q1_5dif))));
			if(AnsQ1_e.q5 == 0){
				Q1_5icct=1-Q1_5icct;
			}
			
			Q1_6icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1*(i-Q1_6dif))));
			if(AnsQ2_e.q1 == 0){
				Q1_6icct=1-Q1_6icct;
			}

			Q1_7icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1*(i-Q1_7dif))));
			if(AnsQ2_e.q2 == 0){
				Q1_7icct=1-Q1_7icct;
			}
			
			Q1_8icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1*(i-Q1_8dif))));
			if(AnsQ2_e.q3 == 0){
				Q1_8icct=1-Q1_8icct;
			}

			Q1_9icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1*(i-Q1_9dif))));
			if(AnsQ2_e.q4 == 0){
				Q1_1icct=1-Q1_1icct;
			}

			Q2_1icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1*(i-Q2_1dif))));
			if(AnsQ3_e.q1 == 0){
				Q2_1icct=1-Q2_1icct;
			}

			Q3_1icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1*(i-Q3_1dif))));
			if(AnsQ3_e.q2 == 0){
				Q3_1icct=1-Q3_1icct;
			}

			
			Q4_1icct=1/(1+Mathf.Pow(Mathf.PI,(float)(-1*(i-Q4_1dif))));
			if(AnsQ4_e.q == 0){
				Q4_1icct=1-Q4_1icct;		
			}

			

			MLE=Q1_1icct*Q1_2icct*Q1_3icct*Q1_4icct*Q1_5icct*Q1_6icct*Q1_7icct*Q1_8icct*Q1_9icct*Q2_1icct*Q3_1icct*Q4_1icct;
			if(MLE>max){
				max=Mathf.Max((float)max,(float)MLE);
				maxLevel=i;

			}
		}
		IRTforUser.selectdif=12;
		IRTforUser.result =maxLevel;
		Debug.Log (max);
	}}