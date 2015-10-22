using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TotalResult : MonoBehaviour {
    public Text success;
    public Text rate;
    public Text Rank;
    public string Suc;
    public string rat;
    public string ran;
    private int T_ans;
    // Use this for initialization
    void Start () {
//正解数の計算
        T_ans = AnsQ1.q1 + AnsQ1.q2 + AnsQ2.q1 + AnsQ2.q2 + AnsQ3.q1 + AnsQ3.q2 + AnsQ4.q1 + AnsQ4.q2 + AnsQ5.q5Ans;
       Suc= string.Format("{0}",T_ans);
        //正解率の計算
        rat = string.Format("{0}", T_ans*100/9)+"%";
        //IRTによるRANK付け


        success.text = Suc;
        rate.text = rat;
        Rank.text = ran;

	}
	
}
