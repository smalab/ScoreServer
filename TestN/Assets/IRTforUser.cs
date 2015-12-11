using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IRTforUser : MonoBehaviour {
	public static double result;
	public static int selectdif;
	public Text resulttext;
	public string Rtext;
	// Use this for initialization
	void Start () {
	if(result<-3){
			Rtext="[１年生レベルかも・・・]";
	}
   if(result>=-3 && result <0){
			Rtext="[ノーマル小学生！]";
	}
   if(result>=0 && result<2){
			Rtext="[デキる小学生]";
	}
	if(result>=2 && result<4){
			Rtext="[スーパー小学生]";
	}
	if (result >= 4) {
			Rtext="[中学生レベル！？]";
	}
		resulttext.text = Rtext;
	}
}
