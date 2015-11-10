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
    public static int T_ans=0;
	public static int totalQ=0;
    // Use this for initialization
    void Start () {
        //正解数の計算
        Debug.Log(TotalResult.T_ans);

        Suc = string.Format("{0}",TotalResult.T_ans);
        //正解率の計算
        rat = string.Format("{0}", T_ans*100/totalQ)+"%";
        //IRTによるRANK付け


        success.text = Suc;
        rate.text = rat;
        Rank.text = ran;
		Application.CaptureScreenshot("image.png");
	}
	
}
