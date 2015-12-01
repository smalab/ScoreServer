using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IRT : MonoBehaviour {
	//問題の難易度
	public static double Q1_1dif=0.310;
	public static double Q1_2dif=-0.723;
	public static double Q2_1dif=-0.985;
	public static double Q2_2dif=0.256;
	public static double Q3_1dif=-0.519;
	public static double Q3_2dif=0.704;
	public static double Q4_1dif=-1.956;
	public static double Q4_2dif=-0.213;
	public static double Q5dif=3.423;
	//問題の識別度
	public static double Q1_1se=0.247;
	public static double Q1_2se=0.241;
	public static double Q2_1se=0.245;
	public static double Q2_2se=0.246;
	public static double Q3_1se=0.239;
	public static double Q3_2se=0.257;
	public static double Q4_1se=0.287;
	public static double Q4_2se=0.240;
	public static double Q5se=0.443;
	//1PLのICC計算(正答確率）
	public static float Q1_1icct;
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
	//最大尤度推定用変数
	public static double MLE;
	public static float Pi=Mathf.PI;
	public void ICC(){
		for (double i=-5.0; i<=5.0; i=i+0.1) {
			Q1_1icct=1/(1+Mathf.Pow(Pi,(-1*(i-Q1_1dif))));
			if(AnsQ1.q1 != 1){
			Q1_1icct=1-Q1_1icct;
			}
	
			Q1_2icct=1/(1+Mathf.Pow(Mathf.PI,(-1f*(i-Q1_2dif))));
			if(AnsQ1.q2 != 1)
				Q1_2icct=1-Q1_2icct;

			Q2_1icct=1/(1+Mathf.Pow(Mathf.PI,(-1f*(i-Q2_1dif))));
			if(AnsQ2.q1 != 1)
			Q2_1icct=1-Q2_1icct;

			Q2_2icct=1/(1+Mathf.Pow(Mathf.PI,(-1*(i-Q2_2dif))));
			if(AnsQ2.q2 != 1)
			Q2_2icct=1-Q2_2icct;

			Q3_1icct=1/(1+Mathf.Pow(Mathf.PI,(-1*(i-Q3_1dif))));
			if(AnsQ3.q1 != 1)
			Q3_1icct=1-Q3_1icct;

			Q3_2icct=1/(1+Mathf.Pow(Mathf.PI,(-1*(i-Q3_2dif))));
			if(AnsQ3.q2 != 1)
			Q3_2icct=1-Q3_2icct;

			Q4_2icct=1/(1+Mathf.Pow(Mathf.PI,(-1*(i-Q4_2dif))));
			if(AnsQ4.q2 != 1)
			Q4_2icct=1-Q4_2icct;		

			Q4_1icct=1/(1+Mathf.Pow(Mathf.PI,(-1*(i-Q4_1dif))));
			if(AnsQ4.q1 != 1)
			Q4_1icct=1-Q4_1icct;

			Q5icct=1/(1+Mathf.Pow(Mathf.PI,(-1*(i-Q5dif))));
			if(AnsQ5.q5Ans != 1)
			Q5icct=1-Q5icct;
			MLE=Q1_1icct*Q1_2icct*Q2_1icct*Q2_2icct*Q3_1icct*Q3_2icct*Q4_1icct*Q4_2icct*Q5icct;

			max=Mathf.Max(max,MLE);
	}

	}}
